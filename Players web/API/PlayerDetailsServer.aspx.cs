using Players_web.Models;
using Players_web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Players_web.API
{
    public partial class PlayerDetailsServer : System.Web.UI.Page
    {
        public Player ShownPlayer;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);
            PlayerRepository pr = new PlayerRepository();
            ShownPlayer = pr.ReturnPlayer(id);
        }
    }
}