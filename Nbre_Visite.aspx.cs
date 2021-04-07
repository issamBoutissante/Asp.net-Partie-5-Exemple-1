using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Partie_5_Exemple_1
{
    public partial class Nbre_Visite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Application.Lock();
            //Application["visites"] = (int)Application["visites"] + 1;
            //Application.UnLock();
            Message.Text = $"Nombre de visites : {Application["visites"]}";
        }
    }
}