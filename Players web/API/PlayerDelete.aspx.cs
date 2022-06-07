using Players_web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Players_web.API
{
    public partial class PlayerDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);

            PlayerRepository pr = new PlayerRepository();
            pr.DeletePlayer(id);
        }
    }
}