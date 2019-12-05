using Dominio.Validacao;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string PasswordUsuario { get; set; }
        public string EnderecoUsuario { get; set; }

        public void password(string password, string confirmPassword)
        {

            AssertionConcern.AssertArgumentNotNull(password, "Senha Inválida");
            AssertionConcern.AssertArgumentNotNull(confirmPassword, "As senhas não Conferem");
            AssertionConcern.AssertArgumentLength(password, 6, 20, "Senha Inválida");
            AssertionConcern.AssertArgumentEquals(password, confirmPassword, "Senha Inválida");

            string Resultado = Encrypt(password);

        }


        public static string Encrypt(string password)
        {
            password += "|2d331cca-f6c0-40c0-bb43-6e32989c2881";
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] data = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(password));
            System.Text.StringBuilder sbString = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sbString.Append(data[i].ToString("x2"));
            return sbString.ToString();
        }
    }
}
