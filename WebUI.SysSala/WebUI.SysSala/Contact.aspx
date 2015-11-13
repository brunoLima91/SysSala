<%@ Page Title="Contato" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebUI.SysSala.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Entre em contato.</h3>
    <address>
        Brasil, Bahia, Salvador<br />
        Universidade Federal da Bahia<br />
        <abbr title="Telefone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Dúvidas e Sugestões:</strong>   <a href="mailto:Support@syssala.com">Support@syssala.com</a><br />        
        <strong>Facebook:</strong>   <a href="www.facebook.com.br">www.facebook.com.br</a><br />
        <strong>Twitter:</strong>   <a href="www.twitter.com.br">www.twitter.com.br</a><br />
    </address>
</asp:Content>
