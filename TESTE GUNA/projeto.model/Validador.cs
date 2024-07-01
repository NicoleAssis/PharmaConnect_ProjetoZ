using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using TESTE_GUNA.projeto.view;

namespace TESTE_GUNA.projeto.model
{
    public class Validador
    {
        public string email;
        public Validador(string email) 
        {
            this.email = email;
        }

        public Validador()
        {
            
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
                FrmMessageBox message = new FrmMessageBox();
                message.Mensagem($"Email Inválido {email} ");
                message.ShowDialog();
                return false;
            }
        }

        public string RemoveAccents(string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }



    }
}
