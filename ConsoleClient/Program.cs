using ConsoleClient.ServiceAcademy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFvsAPI1;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Service1Client Ser = new Service1Client();       

            //Console.WriteLine(Ser.GetData(5));

            //CompositeType T = new CompositeType();
            //T.BoolValue = true;
            //T.StringValue = "FASV1";


            //CompositeType resp = Ser.GetDataUsingDataContract(T);

            //Console.WriteLine(resp.StringValue + " " + resp.BoolValue);          

            string palabra2 = "";
            foreach (var item in Ser.BuscarLista(palabra2))
            {
                Console.WriteLine(item.Snippet.Title);
                Console.WriteLine(item.Id.VideoId);              
            }
            Console.ReadKey();

        }
    }
}
