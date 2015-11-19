<%@ Page Title="" Language="C#" MasterPageFile="~/SysSala/Professores/ProfessorMaster.Master" AutoEventWireup="true" CodeBehind="SolicitarReserva.aspx.cs" Inherits="WebUI.SysSala.SysSala.Professores.SolicitarReserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section id="contextAluno" class="contex">
        <h1>Solicitar Reserva</h1>
        <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
            <p class="text-danger">
                <asp:Literal runat="server" ID="FailureText" />
            </p>
        </asp:PlaceHolder>
        <asp:PlaceHolder runat="server" ID="SucessMessage" Visible="false">
            <p class="ok">
                <asp:Literal runat="server" ID="SucessText" />
            </p>
        </asp:PlaceHolder>
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
                    <asp:TextBox ID="txtDataFinal" CssClass="form-control" Width="22%" TextMode="Date" runat="server"></asp:TextBox>
                </div>

                <div style="margin: auto;">
                    Turma
                <br />
                    <asp:DropDownList ID="ddlTurma" Width="280px" CssClass="form-control" runat="server" DataValueField="Id" DataTextField="Text"></asp:DropDownList>
                </div>
                <div style="margin: auto;">
                    Dia
                <br />
                    <asp:DropDownList ID="ddlDia" Width="280px" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDia_SelectedIndexChanged"></asp:DropDownList>
                </div>
                <div style="margin: auto;">
                    Horário da Aula
                <br />
                    <asp:DropDownList ID="ddlHorarioAula" Width="280px" CssClass="form-control" runat="server" DataValueField="Id" DataTextField="Text"></asp:DropDownList>
                </div>
            </div>
        </div>
    </section>
    <div class="form-group">
        <div class="col-md-offset-2 col-md-10">
            <asp:Button runat="server" Text="Pesquisar" CssClass="btn btn-default" OnClick="btnPesquisar_Click" />
        </div>
    </div>
    <hr />
    <asp:Panel ID="pnlReservas" runat="server" CssClass="panel-body" Visible="false">
        <div>
            <fieldset class="groupbox">
                <legend class="legenda">Selecione as salas de sua preferência</legend>
                <asp:GridView ID="gdvSalas" runat="server" AutoGenerateColumns="False" CssClass="gridviewListagem"
                    CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="ID" Width="100%">
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox runat="server" ID="chkbox" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Text" HeaderText="Sala" />
                        <%--<asp:BoundField DataField="HorarioAula.Descricao" HeaderText="Horário Aula" />
                        <asp:BoundField DataField="Turma.Descricao" HeaderText="Turma" />
                        <asp:BoundField DataField="Turma.Professor.Nome" HeaderText="Professor" />
                        <asp:BoundField DataField="Turma.Disciplina.Descricao" HeaderText="Disiciplina" />--%>
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <HeaderStyle BackColor="#4b6c9e" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
            </fieldset>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" Text="Reservar" CssClass="btn btn-default" OnClick="btnSolicitar_Click" />
            </div>
        </div>
    </asp:Panel>
    <hr />
    <asp:Panel ID="pnlMinhasReservas" runat="server" CssClass="panel-body" >
        <div>
            <fieldset class="groupbox">
                <legend class="legenda">Minhas Solicitações</legend>
                <asp:GridView ID="gdvMinhasSolicitacoes" runat="server" AutoGenerateColumns="False" CssClass="gridviewListagem"
                    CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="ID" Width="100%">
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <Columns>
                        <asp:BoundField DataField="Periodo" HeaderText="Período" />
                        <asp:BoundField DataField="Sala.Text" HeaderText="Sala" />
                        <asp:BoundField DataField="HorarioAula.Descricao" HeaderText="Horário Aula" />
                        <asp:BoundField DataField="Turma.Descricao" HeaderText="Turma" />
                        <asp:BoundField DataField="StatusSolicitacao" HeaderText="Status" />
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
    </asp:Panel>

</asp:Content>
