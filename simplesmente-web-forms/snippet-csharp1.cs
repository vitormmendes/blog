using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Teste
{
    public partial class Pagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Olá, bem-vindo a minha primeira pagina usando ASP.NET");
        }
    }
}