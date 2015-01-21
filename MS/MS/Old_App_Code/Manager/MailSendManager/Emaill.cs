using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Collections;
using System.Web.UI;
using System.Web.Security;

/// <summary>
/// Summary description for MailSend
/// </summary>
public class SendEmail
{
    public SendEmail()
    {
    }


    public static void Send(string Email, string Subject , string Body)
    {
        MailMessage objMessage;
        SmtpClient objClient;
        try
        {
            MailAddress From = new MailAddress(ConfigurationManager.AppSettings.Get("MailSender"));
            
            string[] Emails = Email.Split(',');
            objMessage = new MailMessage();
            objMessage.From = From;

            for (int i = 0; i<Emails.Length; i++ )
            {
                if (Emails[i].Trim() != "")
                    objMessage.To.Add(new MailAddress(Emails[i].Trim()));
            }

            objMessage.IsBodyHtml = true;
            objMessage.Subject = Subject;
            objMessage.Body = Body;
            objMessage.Priority = MailPriority.Normal;
            objClient = new SmtpClient();
            objClient.Send(objMessage);
        }
        catch (Exception)
        {
            throw;
        }
    }
}