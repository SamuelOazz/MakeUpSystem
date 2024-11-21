using Lab.Controller;
using Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Views
{
    public partial class History : System.Web.UI.Page
    {
        protected bool IsADMIN = false;
        protected List<TransactionHeader> th = new List<TransactionHeader>();
        protected TransactionHeader Selectedhead = null;
        protected List<TransactionDetail> Selecteddetail = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("~/Views/Login.aspx");
            }

            if (Session["role"].ToString() != "user")
            {
                IsADMIN = true;
                th = TransactionHeaderController.GetAllTransactionHeader();
            }
            else
            {
                var UserId = int.Parse(Session["Id"].ToString());
                th = TransactionHeaderController.GetUserTransactionHeader(UserId);
            }


            var id = int.Parse(Request.Params.Get("id") ?? "-1");
            if (id == -1)
            {
                Selectedhead = null;
                Selecteddetail = null;
                return;
            }
            string error;
            (Selectedhead, Selecteddetail, error) = OrderController.GetTransactionID(id);

            if (error == "") return;

            if (Selectedhead.UserId != int.Parse(Session["Id"].ToString()))
            {
                Selectedhead = null;
                Selecteddetail = null;
                return;
            }

            Selectedhead = null;
            Selecteddetail = null;

        }
    }
}