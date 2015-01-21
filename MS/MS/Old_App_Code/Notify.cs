using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using VIT.ExceptionManager;
using System.Configuration;

/// <summary>
/// Summary description for Notify
/// </summary>
public class Notify
{

    #region NotifyMembers

    private string _Template;
    private string _Email;
    private string _Subject;
    private string _Applicant;

    public string Subject
    {
        get { return _Subject; }
        set { _Subject = value; }
    }
    public string Template
    {
        get { return _Template; }
        set { _Template = value; }
    }
    public string Email
    {
        get { return _Email; }
        set { _Email = value; }
    }
   
    #endregion

    

    public Notify()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    

    public Notify(string strTemplate, string strEmail, string strSubject)
    {
        Template = strTemplate;
        Email = strEmail;
        Subject = strSubject;
    }


    public void runme()
    {
        try
        {
            SendEmail.Send(Email, Subject, Template);
        }
        catch (Exception ex)
        {
            ExceptionController.HandleException(ex.Message);
        }
    }
}
