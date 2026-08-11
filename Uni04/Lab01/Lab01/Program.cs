using System;
using System.IO;
using System.Xml;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lector de archivos!\n");

            Console.WriteLine("\nPrimer método:\n");

            FileStream lector = new FileStream("agenda.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            while (lector.Length > lector.Position)
            {
                Console.Write((char)lector.ReadByte());
            }
            lector.Close();

            Console.WriteLine("\nSegundo método:\n");
            Leer();

            //Console.WriteLine("\nIngreso de dato nuevo:\n");
            //Escribir();
            //Leer();

            Console.WriteLine("\nCreación de XML!");
            EscribirXML();
            Console.WriteLine("Creación completada\n");
            LeerXML();

            Console.ReadKey();
        }

        private static void Leer()
        {
            StreamReader lector2 = File.OpenText("agenda.txt");
            string? linea;
            Console.WriteLine("Nombre\tApellido\tCorreo\t\t\tTelefono");

            do
            {
                linea = lector2.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", valores[0], valores[1], valores[2], valores[3]);
                }
            } while (linea != null);
            lector2.Close();
        }

        private static void Escribir()
        {
            StreamWriter escritor = File.AppendText("agenda.txt");
            Console.WriteLine("Ingrese el contacto:");
            string rta = "S";
            while (rta.ToUpper() == "S")
            {
                Console.Write("Ingrese el Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Ingrese el Apellido: ");
                string apellido = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Ingrese el Correo: ");
                string correo = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Ingrese el Telefono: ");
                string telefono = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                escritor.WriteLine("{0};{1};{2};{3}", nombre, apellido, correo, telefono);

                Console.WriteLine("Contacto guardado exitosamente.");
                Console.WriteLine();
                Console.Write("Desea ingresar otro contacto? (S/N): ");
                rta = Console.ReadLine();
            }
            escritor.Close();
        }
        private static void EscribirXML()
        {
            XmlTextWriter escritorXML = new XmlTextWriter("agendaxml.xml", null);
            escritorXML.Formatting = Formatting.Indented;
            escritorXML.WriteStartDocument(true);
            escritorXML.WriteStartElement("DocumentElement");

            StreamReader lector = File.OpenText("agenda.txt");
            string? linea;
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    escritorXML.WriteStartElement("contactos");
                    escritorXML.WriteStartElement("nombre");
                    escritorXML.WriteValue(valores[0]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteStartElement("apellido");
                    escritorXML.WriteValue(valores[1]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteStartElement("email");
                    escritorXML.WriteValue(valores[2]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteStartElement("telefono");
                    escritorXML.WriteValue(valores[3]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteEndElement();
                }
            }
            while (linea != null);
            escritorXML.WriteEndElement();
            escritorXML.WriteEndDocument();
            escritorXML.Close();

            lector.Close();
        }

        private static void LeerXML()
        {
            XmlTextReader lectorXML = new XmlTextReader("agendaxml.xml");

            string tagAnterior = "";
            while (lectorXML.Read())
            {
                if (lectorXML.NodeType == XmlNodeType.Element)
                {
                    tagAnterior = lectorXML.Name;
                }
                else if (lectorXML.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine(tagAnterior + ": " + lectorXML.Value);
                }
            }
            lectorXML.Close();
        }
    }
}
