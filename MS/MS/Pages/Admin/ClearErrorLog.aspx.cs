using System;
using multishopbd.BLL;


public partial class ClearErrorLog : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
       

       if (!IsPostBack)
       {
           
           tbxDate.Text = DateTime.Today.ToString("dd-MMM-yyyy");
       }
    }



    public void OnBtnSave_Click(object sender, EventArgs e)
    {
        new bllCommon().ClearErrorLog(Convert.ToDateTime(tbxDate.Text));
        lblError.Text = "Error Log Cleared.";
    }


}
