using System;
namespace DemoXamarin.Models
{
    public class Usuario
    {
        public string nomeUsuario { get; set; }
        public string respostaSecreta { get; set; }

        public Usuario() {}

        public Usuario(string nomeUsuario, string respostaSecreta)
        {
            this.nomeUsuario = nomeUsuario;
            this.respostaSecreta = respostaSecreta;
        }

        public bool ValidarLogin(string respostaSecreta)
        {
            if (respostaSecreta == null)
                return false;

            
            if(!this.nomeUsuario.Equals("") && !this.respostaSecreta.Equals(""))
            {
                if (respostaSecreta.Equals("palmeiras"))
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
