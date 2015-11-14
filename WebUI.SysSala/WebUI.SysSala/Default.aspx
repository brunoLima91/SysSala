<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebUI.SysSala._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>SysSala</h1>
        <p class="lead">O SysSala é um sistema de gerenciamento de ambientes que dar suporte aos alunos realizarem buscas, Professores realizarem reservas de Salas
            E os Administradores conseguem gerenciar os ambientes acadêmicos.
        </p>
        <p><a href="/SysSala/Alunos/HomeAlunos.aspx" class="btn btn-primary btn-lg">Entrar &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>UFBA Acontence</h2>
            <p>
                Fique por dentro das novidades e o que está acontencendo na sua universidades.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Visite &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Sistema Acadêmico - Universidade Federal da Bahia</h2>
            <p>
                O SiAC é o sistema acadêmico da UFBA, tenha acesso as suas notas, matriculas web e muito mais.
            </p>
            <p>
                <a class="btn btn-default" href="www.siac.ufba.br">Visite &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Novo Moodle UFBA</h2>
            <p>
                Este é o ambiente virtual de aprendizagem da Universidade Federal da Bahia que utiliza o software Moodle na sua versão 2.x. O NovoMoodle (www.novomoodle.ufba.br) foi disponibilizado em 2014, em paralelo com a utilização do antigo Moodle (www.moodle.ufba.br). Esta utilização em paralelo das duas versões do Moodle será mantida enquanto for necessária a utilização do Moodle antigo.
            </p>
            <p>
                <a class="btn btn-default" href="http://www.novomoodle.ufba.br/">Visite &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
