using Players_web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Players_web.API
{
    public partial class PageCountServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PlayerRepository pr = new PlayerRepository();
            int count = Convert.ToInt32(Request["pcount"]);

            int result = pr.ReturnPageCount(count);
            Response.Write(result);
        }
    }
}