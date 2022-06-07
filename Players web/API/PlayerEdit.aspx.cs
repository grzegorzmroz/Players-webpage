using Players_web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Players_web.API
{
    public partial class PlayerEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);
            string name = Request["name"];
            string surname = Request["surname"];
            string nationality = Request["nationality"];
            DateTime birthDate = Convert.ToDateTime(Request["birth"]);
            int weight = Convert.ToInt32(Request["weight"]);
            int height = Convert.ToInt32(Request["height"]);

            PlayerRepository pr = new PlayerRepository();
            pr.EditPlayer(id, name, surname, nationality, birthDate, height, weight);


        }
    }
}