using System;

namespace Partie_5_Exemple_1
{
    public partial class Page_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Envoyer_Click(object sender, EventArgs e)
        {
            Session["Nom"] = Nom.Text;
            Session["Prenom"] = Prenom.Text;
            Response.Redirect("Page2.aspx");
        }
    }
}