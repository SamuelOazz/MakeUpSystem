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
    public partial class ManageMakeUp : System.Web.UI.Page
    {
        protected List<MakeUp> makeup = new List<MakeUp>();
        protected List<MakeUpBrand> brand = new List<MakeUpBrand>();
        protected List<MakeUpType> type = new List<MakeUpType>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null || Session["role"].ToString() != "admin")
            {
                Response.Redirect("~/Views/Login.aspx");
            }
            makeup = MakeUpController.GetAllMakeUps();
            brand = BrandController.GetAllMakeUpBrand();
            type = TypeController.GetAllMakeUpTypes();

            var action = Request.Params.Get("action");
            var item = Request.Params.Get("item");
            var id = int.Parse(Request.Params.Get("Id") ?? "-1");

            if (action == null || item == null || action != "delete" || id == -1)
            {
                return;
            }

            switch (item)
            {
                case "makeup":
                    deleteMakeUp(id);
                    break;
                case "type":
                    deleteType(id);
                    break;
                case "brand":
                    deleteBrand(id);
                    break;
            }

        }

        private void deleteMakeUp(int id)
        {
            var err = MakeUpController.DeleteMakeUp(id);
            if(err != "")
            {
                return;
            }
            Response.Redirect("~/Views/ManageMakeUp.aspx");
        }

        private void deleteBrand(int id)
        {
            var err = MakeUpController.DeleteMakeUpBrand(id);
            if (err != "")
            {
                return;
            }
            Response.Redirect("~/Views/ManageMakeUp.aspx");
        }

        private void deleteType(int id) 
        {
            var err = MakeUpController.DeleteTypeByID(id);
            if (err != "")
            {
                return;
            }
            Response.Redirect("~/Views/ManageMakeUp.aspx");
        }

    }
}