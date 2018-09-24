using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb.ViewBusiness
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LnkNavAdministracion_Click(object sender, EventArgs e)
        {
            LinkButton btn = sender as LinkButton;
            switch (btn.ID)
            {
                case ("lnkNuevoAdmin"):
                    string script1 = "OpenProfileAdministrador1();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "OpenProfileAdministrador1()", script1, true);
                    break;
                case ("lnkNombreAdmin"):
                    string script2 = "OpenProfileAdministrador2();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "OpenProfileAdministrador2()", script2, true);
                    break;
                case ("lnkCotrasenaAdmin"):
                    string script3 = "OpenProfileAdministrador3();";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "OpenProfileAdministrador3()", script3, true);
                    break;
            }
        }
    }
}