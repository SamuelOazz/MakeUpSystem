using Lab.Controller;
using Lab.Dataset;
using Lab.Models;
using Lab.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab.Views
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null || Session["role"].ToString() != "admin")
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            var rpt = new CrystalReport2();
            CrystalReportViewer2.ReportSource = rpt;
            var data = GetData(TransactionHeaderController.GetAllTransactionHeader(), TransactionDetailController.GetAllTransactionDetails());
            rpt.SetDataSource(data);
        }

        private DataSet1 GetData(List<TransactionHeader> Transactions, List<TransactionDetail> transactiondetail)
        {
            DataSet1 data = new DataSet1();
            var header = data.Transactions;
            var detail = data.Transactions_Detail;
            foreach (TransactionHeader th in Transactions)
            {
                var hrow = header.NewRow();
                hrow["transaction_id"] = th.Id;
                hrow["user_id"] = th.UserId;
                hrow["transaction_date"] = th.TransactionDate;
                hrow["grand_total"] = th.TransactionDetails.Sum(td => td.Quantity * td.MakeUp.Price);
                header.Rows.Add(hrow);
            }

            foreach(TransactionDetail td in transactiondetail)
            {
                var drow = detail.NewRow();
                drow["transaction_id"] = td.TransactionId;
                drow["item_id"] = td.MakeupId;
                drow["quantity"] = td.Quantity;
                drow["item_price"] = td.MakeUp.Price;
                drow["sub_total"] = td.Quantity * td.MakeUp.Price;
                detail.Rows.Add(drow);
            }
            return data;
        }

    }
}