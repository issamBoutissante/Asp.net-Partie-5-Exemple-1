using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Partie_5_Exemple_1
{
    public partial class Page_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = $"Bienvenue {Session["Nom"]} {Session["Prenom"]}";
        }
    }
}