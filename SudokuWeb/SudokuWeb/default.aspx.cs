using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SudokuWeb
{
    public partial class _default : System.Web.UI.Page
    {
        private  Engine.EngineUtil FuncionUtil = new Engine.EngineUtil();
        private Models.EngineModel ModeloDb = new Models.EngineModel();
        private Engine.MailNotificacion Mail = new Engine.MailNotificacion();

        protected void Page_Load(object sender, EventArgs e)
        {
         
        }
    }
}