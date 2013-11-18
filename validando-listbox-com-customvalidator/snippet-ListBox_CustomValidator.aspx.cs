using System; 
using System.Linq; 
using System.Web.UI.WebControls; 
 
namespace Project_ListBox_CustomValidator 
{ 
    public partial class ListBox_CustomValidator : System.Web.UI.Page 
    { 
        protected void Page_Load(object sender, EventArgs e) 
        { 
 
        } 
 
        protected void ValidarListBoxServer(object source, ServerValidateEventArgs args) 
        { 
            try 
            { 
                //Verificando se existe algum cor selecionada no ListBox 
                args.IsValid = lstCoresServer.Items.Cast<ListItem>().Any(t => t.Selected); 
            } 
            catch 
            { 
                args.IsValid = false; 
            } 
        } 
    } 
}