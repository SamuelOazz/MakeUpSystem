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
    public partial class TransactionQueue : System.Web.UI.Page
    {
        protected List<TransactionHeader> transactions = new List<TransactionHeader>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null || Session["role"].ToString() != "admin")
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            transactions = TransactionHeaderController.GetAllTransactionHeader();
            var Id = int.Parse(Request.Params.Get("Id") ?? "-1");
            if(Id == -1)
            {
                return;
            }
            handle(Id);
        }

        private void handle(int Id)
        {
            OrderController.ManageTransaction(Id, "handled");
            Response.Redirect("~/Views/TransactionQueue.aspx",true);
        }
    }
}