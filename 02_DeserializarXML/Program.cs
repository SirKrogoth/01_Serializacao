using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace _02_DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Usuario));

            StreamReader reader = new StreamReader(@"C:\Telecon_Sistemas\cebola.xml");

            Usuario usuario = (Usuario) serializer.Deserialize(reader);

            Console.WriteLine("Nome: " + usuario.nome);
            Console.WriteLine("CFP: " + usuario.cpf);
            Console.WriteLine("Email: " + usuario.email);

            Console.ReadLine();
        }
    }
}
