using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using _00_Biblioteca;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            StreamReader reader = new StreamReader(@"C:\Telecon_Sistemas\Tomate.json");

            string arquivo = reader.ReadToEnd();

            reader.Close();

            Usuario usuario = (Usuario) serializer.Deserialize(arquivo, typeof(Usuario));

            Console.WriteLine("Nome: " + usuario.nome);
            Console.WriteLine("CPF: " + usuario.cpf);
            Console.WriteLine("Email: " + usuario.email);

            Console.ReadLine();
        }
    }
}
