using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TESTE_GUNA.projeto.model
{
    public class Validador
    {
        public string email;
        public Validador(string email) 
        {
            this.email = email;
        }
        public static bool ValidarEmail(string email)
        {
            try
            {
                if(!string.IsNullOrEmpty(email)) { }
                MailAddress mailadress = new MailAddress(email);
                return true;
                
            }
            catch (Exception)
            {

                MessageBox.Show($"Email Inválido {email} ");
                return false;
            }
        }


        
    }
}
