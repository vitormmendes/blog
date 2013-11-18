using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplicationTeste
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //Código que sera executado, apos a aplicação ser iniciada
            Application["UsuariosOnline"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            //Código executado, quando a sessão é iniciada
            Application.Lock();
            Application["UsuariosOnline"] =  Convert.ToInt32(Application["UsuariosOnline"]) + 1;
            Application.UnLock();
        }

        protected void Session_End(object sender, EventArgs e)
        {
            //Código executando, quando a sessão é finalizada
            Application.Lock();
            Application["UsuariosOnline"] = Convert.ToInt32(Application["UsuariosOnline"]) - 1;
            Application.UnLock();
        }
    }
}