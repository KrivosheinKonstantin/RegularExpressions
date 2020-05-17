using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //IP
            string str;
            str = "255.255.255.0  130.0.2.7 250.0.0.0 ghyvg nefgag ag as gsa gas gas gas250.0.0.0\n1300.0.0.0\n1111.0.0.0";
            Console.WriteLine(str);
            foreach (string item in str.IP())
                Console.WriteLine("Ip: {0}", item);

            Console.WriteLine("\n\n\n");
            //GUID
            str = "e02fd0e4-00fd-090A-ca30-0d00a0038ba0 e02fd0e400fd090Aca300d00a0038ba0";
            Console.WriteLine(str);
            foreach (string item in str.GUID())
                Console.WriteLine("GUID: {0}", item);
            Console.WriteLine("\n\n\n");

            //URL
            str = "http://www.example.com http://example.com example.com/13afa/acap ex.com:8080/index.html?id=103131#13131 http://a.com Just Text";
            Console.WriteLine(str);
            foreach (string item in str.URL())
                Console.WriteLine("URL: {0}", item);
            Console.WriteLine("\n\n\n");

            //DATA
            str = "29/02/2000 30/04/2003 29/02/2001 30-04-2003 1/1/1899 01/01/2003";
            Console.WriteLine(str);
            foreach (string item in str.DATA())
                Console.WriteLine("DATA: {0}", item);
            Console.WriteLine("\n\n\n");
            //RUB

            str = "Есть текст с ценами в рублях. Извлечь из него цены. 23.78 руб. 22 р., 0.002 руб. 25 руб. 0 руб. 0.021. руб. ";
            Console.WriteLine(str);
            foreach (string item in str.RUB())
                Console.WriteLine("RUB: {0}", item);
            Console.WriteLine("\n\n\n");
            //PAS
            str = "fajFJfa13 8139Hjadadadadadad_        11111131GAGAafafaafafaa231     C00l.    Cool_pass,";
            Console.WriteLine(str);
            foreach (string item in str.PAS())
                Console.WriteLine("PAS: {0}", item);
            Console.WriteLine("\n\n\n");

            Console.ReadKey();

        }
    }
}
