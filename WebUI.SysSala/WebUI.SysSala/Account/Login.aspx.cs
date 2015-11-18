using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WebUI.SysSala.Models;
using SysSala.BLL;
using SysSala.DTO;

namespace WebUI.SysSala.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            // Enable this once you have account confirmation enabled for password reset functionality
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            //OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            try
            {
                var usu = UsuarioBLL.VerificarCrendeciais(Email.Text, Password.Text);

                if (usu != null)
                {
                    if (usu.TipoUsuario == ETipoUsuario.Professor)
                        Response.Redirect("~/SysSala/Professores/MinhasReservas.aspx",false);
                    else
                        Response.Redirect("~/SysSala/Professores/MinhasReservas.aspx", false);

                    Session["UsuarioId"] = usu.Id;
                }
                else
                {
                    FailureText.Text = "Usuário não cadastrado.";
                    ErrorMessage.Visible = true;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}