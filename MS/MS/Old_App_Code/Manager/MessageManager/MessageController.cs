using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;

public enum MessageType
{
    Confirmation,
    Error,
    Information,
    Warning
}

public enum MessageCode
{
    _SaveSucceeded,
    _SaveFailed,
    _UpdateSucceeded,
    _UpdateFailed,
    _DeleteSucceeded,
    _DeleteFailed,
    _SelectImage,
    _SubmitSucceeded,
    _SubmiFailed,
    _RegistrationSucceeded,
    _strPublishSucceeded,
    _strUnPublishSucceeded,
    _sendSucceeded,
    _sendFailed
}

public class MessageController
{
    private static string _strSaveSucceeded = "Saved successfully.";
    private static string _strSaveFailed = "Save failed.";
    private static string _strUpdateSucceeded = "Updated successfully.";
    private static string _strUpdateFailed = "Update failed.";
    private static string _strDeleteSucceeded = "Deleted successfully.";
    private static string _strDeleteFailed = "Delete failed.";
    private static string _strSelectImage = "Please select gif/jpeg/bmp/png image.";
    private static string _SubmitSucceeded = "Submitted successfully.";
    private static string _SubmitFailed = "Submission failed.";
    private static string _strRegistrationSucceeded = "Registration successfully. Please wait for admin approval.";
    private static string _strPublishSucceeded = "Publish successfully.";
    private static string _strUnPublishSucceeded = "UnPublish successfully.";
    private static string _sendSucceeded = "Send successfully.";
    private static string _sendFailed = "Send failed.";

    public static void Show(MessageCode enmMessegeCode, MessageType enmMessageType, Page p)
    {
        switch (enmMessageType)
        {
            case MessageType.Confirmation:
                {
                    ShowMessage(GetMessage(enmMessegeCode), "Confirmation", "msgConfirmation", p);
                    break;
                }
            case MessageType.Error:
                {
                    ShowMessage(GetMessage(enmMessegeCode), "Error", "msgError", p);
                    break;
                }
            case MessageType.Information:
                {
                    ShowMessage(GetMessage(enmMessegeCode), "Information", "msgInformation", p);
                    break;
                }
            case MessageType.Warning:
                {
                    ShowMessage(GetMessage(enmMessegeCode), "Warning", "msgWarning", p);
                    break;
                }
            default:
                break;
        }
    }


    public static void Show(string strMessage, MessageType enmMessageType, Page currentPage)
    {
        switch (enmMessageType)
        {
            case MessageType.Confirmation:
                {
                    ShowMessage(strMessage, "Confirmation", "msgConfirmation", currentPage);
                    break;
                }
            case MessageType.Error:
                {
                    ShowMessage(strMessage, "Error", "msgError", currentPage);
                    break;
                }
            case MessageType.Information:
                {
                    ShowMessage(strMessage, "Information", "msgInformation", currentPage);
                    break;
                }
            case MessageType.Warning:
                {
                    ShowMessage(strMessage, "Warning", "msgWarning", currentPage);
                    break;
                }
            default:
                break;
        }
    }

    private static string GetMessage(MessageCode enmMessegeCode)
    {
        switch (enmMessegeCode)
        {
            case MessageCode._RegistrationSucceeded:
                return _strRegistrationSucceeded;
            case MessageCode._SaveSucceeded:
                return _strSaveSucceeded;
            case MessageCode._SaveFailed:
                return _strSaveFailed;
            case MessageCode._UpdateSucceeded:
                return _strUpdateSucceeded;
            case MessageCode._UpdateFailed:
                return _strUpdateFailed;
            case MessageCode._DeleteSucceeded:
                return _strDeleteSucceeded;
            case MessageCode._DeleteFailed:
                return _strDeleteFailed;
            case MessageCode._SelectImage:
                return _strSelectImage;
            case MessageCode._SubmitSucceeded:
                return _SubmitSucceeded;
            case MessageCode._SubmiFailed:
                return _SubmitFailed;
            case MessageCode._strPublishSucceeded:
                return _strPublishSucceeded;
            case MessageCode._strUnPublishSucceeded:
                return _strUnPublishSucceeded;
            case MessageCode._sendSucceeded:
                return _sendSucceeded;
            case MessageCode._sendFailed:
                return _sendFailed;
            default:
                return "Something strange happened. Please contact your system administrator.";
        }
    }

    private static void ShowMessage(string strMessage, string strTitle, string strCSSClassName, Page p)
    {
        ((Panel)p.Master.FindControl("MessagePanel1").FindControl("pnlMessage")).Visible = true;
        ((Label)(((Panel)p.Master.FindControl("MessagePanel1").FindControl("pnlMessage")).FindControl("lblMessageTitle"))).Text = strTitle;
        ((Label)(((Panel)p.Master.FindControl("MessagePanel1").FindControl("pnlMessage")).FindControl("lblMessageDetails"))).Text = strMessage;
        ((Label)(((Panel)p.Master.FindControl("MessagePanel1").FindControl("pnlMessage")).FindControl("lblMessageDetails"))).CssClass = strCSSClassName;
    }

    public static void Clear(Page p)
    {
        ((Panel)p.Master.FindControl("MessagePanel1").FindControl("pnlMessage")).Visible = false;
        ((Label)(((Panel)p.Master.FindControl("MessagePanel1").FindControl("pnlMessage")).FindControl("lblMessageTitle"))).Text = "";
        ((Label)(((Panel)p.Master.FindControl("MessagePanel1").FindControl("pnlMessage")).FindControl("lblMessageDetails"))).Text = "";
    }
} // Class