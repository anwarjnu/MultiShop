using System;
using System.Web;
using System.Configuration;

public class FileUpload : IHttpModule
{
	private static readonly string _uploadTooBigErrorMessage = Guid.NewGuid().ToString();
	private const string _uploadCookieKey = "FileTooBigKey";

	public void Dispose()
	{
	}

	public void Init(HttpApplication application)
	{
		application.BeginRequest += ValidateUploadRequest;
		application.EndRequest += ProcessUploadRequestEnd;
		application.Error += HandleFileUploadError;
	}

	private static void ValidateUploadRequest(object source, EventArgs e)
	{
		HttpApplication context = source as HttpApplication;

		if (context == null)
			return;

		if (!IsValidFileUploadRequest(context))
			return;

		EnsureUploadedFileIsSmallEnough(context);
	}

	private static bool IsValidFileUploadRequest(HttpApplication context)
	{
		if (!IsUploadRequest(context))
			return false;

		// Do something more sensible/appropriate here to check if the request requires upload size validation for ex: return context.Request.Path.Contains("FileUploadPathIdentifier");
		return true;
	}

	private static bool IsUploadRequest(HttpApplication context)
	{
		return context.Request.HttpMethod.ToUpperInvariant() == "POST";
	}

	private static void EnsureUploadedFileIsSmallEnough(HttpApplication context)
	{
		int maxFileSizeInMB;

		if (!TryGetMaxAllowedFileSize(out maxFileSizeInMB))
			return;

		if (!IsUploadedFileSmallEnough(context.Request.ContentLength, maxFileSizeInMB))
			throw new InvalidOperationException(_uploadTooBigErrorMessage);
		else
			CleanUpErrorCookie(context);
	}

	private static bool TryGetMaxAllowedFileSize(out int maxFileSizeInMB)
	{
		return int.TryParse(ConfigurationManager.AppSettings["MaxFileUploadSize"], out maxFileSizeInMB);
	}

	private static bool IsUploadedFileSmallEnough(int requestLengthInBytes, int maxFileSizeInMB)
	{
		int requestLengthInMB = requestLengthInBytes / 1024 / 1024;
		return requestLengthInMB <= maxFileSizeInMB;
	}

	private static void ProcessUploadRequestEnd(object source, EventArgs e)
	{
		HttpApplication context = source as HttpApplication;

		if (context == null)
			return;

		if (!IsValidFileUploadRequest(context))
			return;

		EnsureUploadedFileIsSmallEnough(context);
	}

	private static void HandleFileUploadError(object sender, EventArgs e)
	{
		HttpApplication context = sender as HttpApplication;

		if (context == null)
			return;

		Exception thrownException = context.Server.GetLastError();

		if (thrownException.Message == _uploadTooBigErrorMessage)
		{
			context.Server.ClearError();
			AddErrorCookie(context);

			context.Response.Redirect(context.Request.Path, true);
		}
	}

	private static void AddErrorCookie(HttpApplication context)
	{
		HttpCookie errorCookie = new HttpCookie(_uploadCookieKey, "UploadedFileTooBig");
		context.Response.SetCookie(errorCookie);
	}

	private static void CleanUpErrorCookie(HttpApplication context)
	{
		if (context.Response.Cookies[_uploadCookieKey] != null)
			context.Response.Cookies[_uploadCookieKey].Value = "";

		if (context.Request.Cookies[_uploadCookieKey] != null)
			context.Request.Cookies[_uploadCookieKey].Value = "";
	}
}