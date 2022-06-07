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
    public partial class PlayersServer : System.Web.UI.Page
    {
        public Player[] Players;
        protected void Page_Load(object sender, EventArgs e)
        {

            string page = Request["page"];
            string count = Request["count"];
            string filter = Request["filter"];

            int pageInt = 1;
            int countInt = 5;

            if (page != null)
                pageInt = Convert.ToInt32(page);

            if (count != null)
                countInt = Convert.ToInt32(count);

            PlayerRepository pr = new PlayerRepository();
            Players = pr.ReturnAllPlayers(pageInt, countInt, filter);

        }
    }
}