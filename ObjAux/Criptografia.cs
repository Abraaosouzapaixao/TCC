using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistro.ObjAux
{
    class Criptografia
    {

        public string Criptografar(string mensagem)
        {
            // Cria objeto para criptografia 
            System.Security.Cryptography.TripleDES des = System.Security.Cryptography.TripleDES.Create();
            des.Mode = System.Security.Cryptography.CipherMode.CBC;
            des.KeySize = 192;

            byte[] chaveBytes;
            byte[] criptografiaBytes;
            byte[] mensagemBytes;
            string criptografia;

            // Transforma chave e mensagem em array de byts
            chaveBytes = Encoding.UTF8.GetBytes("chavede16digitos");
            mensagemBytes = Encoding.UTF8.GetBytes(mensagem);

            // Realiza criptografia
            System.Security.Cryptography.ICryptoTransform cryptor = des.CreateEncryptor(chaveBytes, chaveBytes);
            criptografiaBytes = cryptor.TransformFinalBlock(mensagemBytes, 0, mensagemBytes.Length);
            cryptor.Dispose();
            
            // Transforma criptografia em string
            criptografia = Convert.ToBase64String(criptografiaBytes);
            return criptografia;
        }

        public string Descriptografar(string criptografia)
        {
            // Cria objeto para criptografia 
            System.Security.Cryptography.TripleDES des = System.Security.Cryptography.TripleDES.Create();
            des.Mode = System.Security.Cryptography.CipherMode.CBC;
            des.KeySize = 192;

            byte[] chaveBytes;
            byte[] criptografiaBytes;
            byte[] mensagemBytes;
            string mensagem;
            
            // Transforma chave e mensagem em array de byts
            chaveBytes = Encoding.UTF8.GetBytes("chavede16digitos");
            mensagemBytes = Convert.FromBase64String(criptografia);

            // Realiza criptografia
            System.Security.Cryptography.ICryptoTransform cryptor = des.CreateDecryptor(chaveBytes, chaveBytes);
            criptografiaBytes = cryptor.TransformFinalBlock(mensagemBytes, 0, mensagemBytes.Length);
            cryptor.Dispose();

            // Transforma criptografia em string
            mensagem = Encoding.UTF8.GetString(criptografiaBytes);
            return mensagem;
        }
    }
}

