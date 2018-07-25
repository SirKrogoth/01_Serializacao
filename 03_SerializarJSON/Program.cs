using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;//utilizado para JSON
using _00_Biblioteca;
using System.IO;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { nome = "Caroline Kisner da Silva", cpf = "007.215.411-22", email = "CarolineKisner@teleconsistemas.com.br" };

            JavaScriptSerializer serializer = new JavaScriptSerializer();            

            string objetoSerializado = serializer.Serialize(usuario);

            StreamWriter writer = new StreamWriter(@"C:\Telecon_Sistemas\tomate.json");
            
            writer.WriteLine(objetoSerializado);

            writer.Close();
        }
    }
}
