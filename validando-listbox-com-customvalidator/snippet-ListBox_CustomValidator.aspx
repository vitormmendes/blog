<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListBox_CustomValidator.aspx.cs" 
    Inherits="Project_ListBox_CustomValidator.ListBox_CustomValidator" %> 
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"> 
<html xmlns="http://www.w3.org/1999/xhtml"> 
<head runat="server"> 
    <title>Validando ListBox com CustomValidator</title> 
    <script src='<%= ResolveUrl("~/Scripts/jquery-1.7.2.min.js")%>' src="" type="text/javascript"></script> 
    <script type="text/javascript" language="javascript"> 
        function ValidarListBoxJavaScript(sender, args) { 
            //Recuperando opções do ListBox 
            var options = document.getElementById("<%=lstCoresJavaScript.ClientID%>").options; 
 
            //Verificando se existe alguma opção marcada 
            for (var i = 0; i < options.length; i++) { 
                if (options[i].selected == true) { 
                    args.IsValid = true; 
                    return; 
                } 
            } 
 
            //Caso tenha chegado aqui, não existe nenhuma opção marcada 
            args.IsValid = false; 
        } 
 
        function ValidarListBoxJQuery(sender, args) { 
            //Verificando se tem alguma opção marcada no ListBox 
            args.IsValid = $('#<%=lstCoresJQuery.ClientID%> :checked').length > 0; 
        } 
    </script> 
</head> 
<body> 
    <form id="form1" runat="server"> 
    <asp:ScriptManager ID="ScriptManager" runat="server" /> 
    <div style="width: 400px"> 
        <fieldset> 
            <legend>Server</legend> 
            <asp:ListBox ID="lstCoresServer" ValidationGroup="ValidaNoServer" runat="server" 
                SelectionMode="Multiple" Height="100px"> 
                <asp:ListItem Text="Azul" /> 
                <asp:ListItem Text="Vermelho" /> 
                <asp:ListItem Text="Amarelo" /> 
            </asp:ListBox> 
            <asp:CustomValidator ID="CustomValidatorServer" ValidationGroup="ValidaNoServer" 
                runat="server" ErrorMessage="Selecione uma cor!" OnServerValidate="ValidarListBoxServer"> 
            </asp:CustomValidator> 
            <br /> 
            <asp:Button ID="btnValidarServer" runat="server" ValidationGroup="ValidaNoServer" 
                Text="Validar no Server" /> 
        </fieldset> 
        <br /> 
        <br /> 
        <fieldset> 
            <legend>JavaScript</legend> 
            <asp:ListBox ID="lstCoresJavaScript" ValidationGroup="ValidarComJavaScript" runat="server" 
                SelectionMode="Multiple" Height="100px"> 
                <asp:ListItem Text="Azul" /> 
                <asp:ListItem Text="Vermelho" /> 
                <asp:ListItem Text="Amarelo" /> 
            </asp:ListBox> 
            <asp:CustomValidator ID="CustomValidatorJavaScript" ValidationGroup="ValidarComJavaScript" 
                runat="server" ErrorMessage="Selecione uma cor!" ClientValidationFunction="ValidarListBoxJavaScript"></asp:CustomValidator> 
            <br /> 
            <asp:Button ID="btnValidarComJavaScript" runat="server" ValidationGroup="ValidarComJavaScript" 
                Text="Validar com JavaScript" /> 
        </fieldset> 
        <br /> 
        <br /> 
        <fieldset> 
            <legend>JQuery</legend> 
            <asp:ListBox ID="lstCoresJQuery" ValidationGroup="ValidarComJQuery" runat="server" 
                SelectionMode="Multiple" Height="100px"> 
                <asp:ListItem Text="Azul" /> 
                <asp:ListItem Text="Vermelho" /> 
                <asp:ListItem Text="Amarelo" /> 
            </asp:ListBox> 
            <asp:CustomValidator ID="CustomValidatorJQuery" ValidationGroup="ValidarComJQuery" 
                runat="server" ErrorMessage="Selecione uma cor!" ClientValidationFunction="ValidarListBoxJQuery"></asp:CustomValidator> 
            <br /> 
            <asp:Button ID="btnValidarComJQuery" runat="server" ValidationGroup="ValidarComJQuery" 
                Text="Validar com JQuery" /> 
        </fieldset> 
    </div> 
    </form> 
</body> 
</html> 