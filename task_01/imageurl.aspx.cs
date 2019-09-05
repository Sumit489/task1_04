using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task_01
{
    public partial class imageurl : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["string"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(Server.MapPath("Images")))
            {
                Directory.CreateDirectory(Server.MapPath("Images"));
            }
            string imageurl = (Server.MapPath("Images") + "\\" + image.FileName);
            image.SaveAs(imageurl);



        }
    }
}