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
                    <asp:DropDownList ID="ddlProfessor" Width="280px" CssClass="form-control" runat="server" DataValueField="Id" DataTextField="Nome"></asp:DropDownList>
                </div>

                <div style="margin: auto;">
                    Turma
                <br />
                    <asp:DropDownList ID="ddlTurma" Width="280px" CssClass="form-control" runat="server" DataValueField="Id" DataTextField="Descricao"></asp:DropDownList>
                </div>

                <div style="margin: auto;">
                    Disciplina
                <br />
                    <asp:DropDownList ID="ddlDisciplina" Width="280px" CssClass="form-control" runat="server" DataValueField="Id" DataTextField="Descricao"></asp:DropDownList>
                </div>
            </div>
        </div>
    </section>
    <br />
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <asp:Button runat="server" Text="Pesquisar" CssClass="btn btn-default" OnClick="Unnamed1_Click" />
        </div>
    </div>
    <hr />
    <div >
        <fieldset class="groupbox">
            <legend class="legenda">Salas</legend>
            <asp:GridView ID="gdvReservas" runat="server" AutoGenerateColumns="False" CssClass="gridviewListagem"
                CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="ID" Width="100%">
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <Columns>
                    <asp:BoundField DataField="Sala.Text" HeaderText="Sala" />
                    <asp:BoundField DataField="HorarioAula.Descricao" HeaderText="Horário Aula" />
                    <asp:BoundField DataField="Turma.Descricao" HeaderText="Turma" />
                    <asp:BoundField DataField="Turma.Professor.Nome" HeaderText="Professor" />
                    <asp:BoundField DataField="Turma.Disciplina.Descricao" HeaderText="Disiciplina" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <HeaderStyle BackColor="#4b6c9e" Font-Bold="True" ForeColor="White" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
        </fieldset>
    </div>


</asp:Content>

