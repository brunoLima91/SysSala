<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomeAlunos.aspx.cs" Inherits="WebUI.SysSala.SysSala.Alunos.HomeAlunos" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section id="contextAluno" class="contex">
        <h1>Encontre sua sala</h1>
        <div class="row">
            <div class="col-md-8">

                <div style="margin: auto;">
                    Data Inicial
                <br />
                    <asp:TextBox ID="txtDataInicio" Width="22%" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
                </div>

                <div style="margin: auto;">
                    Data Final
                <br />
                    <asp:TextBox ID="TextBox2" CssClass="form-control" Width="22%" TextMode="Date" runat="server"></asp:TextBox>
                </div>

                <div style="margin: auto;">
                    Professor
                <br />
                    <asp:DropDownList ID="DropDownList1" Width="280px" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>

                <div style="margin: auto;">
                    Turma
                <br />
                    <asp:DropDownList ID="DropDownList4" Width="280px" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>

                <div style="margin: auto;">
                    Disciplina
                <br />
                    <asp:DropDownList ID="DropDownList5" Width="280px" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
            </div>
        </div>
    </section>
    <br />
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <asp:Button runat="server" Text="Pesquisar" CssClass="btn btn-default" />
        </div>
    </div>
    <hr />

    <fieldset class="groupbox">
        <legend class="legenda">Salas</legend>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </fieldset>

</asp:Content>

