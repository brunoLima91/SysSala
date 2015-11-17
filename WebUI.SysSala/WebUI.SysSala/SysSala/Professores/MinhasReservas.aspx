<%@ Page Title="" Language="C#" MasterPageFile="~/SysSala/Professores/ProfessorMaster.Master" AutoEventWireup="true" CodeBehind="MinhasReservas.aspx.cs" Inherits="WebUI.SysSala.SysSala.Professores.MinhasReservas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Minhas Reservas Ativas</h1>
    <div>
        <asp:GridView ID="gdvReservas" runat="server" AutoGenerateColumns="False" CssClass="gridviewListagem"
            CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="ID" Width="100%">
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <Columns>
                <asp:BoundField DataField="Sala.Text" HeaderText="Sala" />
                <asp:BoundField DataField="HorarioAula.Descricao" HeaderText="Horário Aula" />
                <asp:BoundField DataField="Turma.Descricao" HeaderText="Turma" />
                <asp:BoundField DataField="Periodo" HeaderText="Período" />
                <asp:BoundField DataField="Turma.Disciplina.Descricao" HeaderText="Disiciplina" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#4b6c9e" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </div>
</asp:Content>
