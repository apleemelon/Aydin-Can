using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument Dosya = XDocument.Load("Ports.xml");
            XName X = XName.Get("hosting", Dosya.Root.Name.NamespaceName);
            foreach (XElement data in Dosya.Descendants(X))
            {
                Console.WriteLine(data.ToString());
                Dosya.Save("Kayıtlı.xml");
            }
            Console.ReadKey();
        }
    }
}
