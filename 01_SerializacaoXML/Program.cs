using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Biblioteca;
using System.Xml.Serialization;
using System.IO;

namespace _01_SerializacaoXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { nome = "João Rafael Menezes", cpf = "000.000.000-22", email = "joao@teleconsistemas.com.br"};

            XmlSerializer xml = new XmlSerializer(typeof(Usuario));
            //XmlSerializer xml = new XmlSerializer(usuario.GetType());

            StreamWriter writer = new StreamWriter(@"C:\Telecon_Sistemas\cebola.xml");

            xml.Serialize(writer, usuario);

            Console.WriteLine("Arquivo cebola.xml criado com sucesso.");
            Console.ReadLine();
        }
    }
}
