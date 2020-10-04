using Refit;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace ConsoleUBOTS
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var rc = new System.Net.Http.HttpClient();
            //This response is the JSON Array (see posts above)
        
            var json = await rc.GetAsync("http://www.mocky.io/v2/598b16291100004705515ec5");
            string contactsJson = await json.Content.ReadAsStringAsync();

            if (contactsJson != "")
            {
                //Converting JSON Array Objects into generic list  
                var Newtempdata = JsonConvert.DeserializeObject<List<Cliente>>(contactsJson);
                Console.WriteLine($"\nNome:{Newtempdata[1].Nome}");


                var json2 = await rc.GetAsync("http://www.mocky.io/v2/598b16861100004905515ec7");
                string contactsJson2 = await json2.Content.ReadAsStringAsync();

                if (contactsJson2 != "")
                {
                    //Converting JSON Array Objects into generic list  
                    var Newtempdata2 = JsonConvert.DeserializeObject<List<HistVendas>>(contactsJson2);
                    Console.WriteLine($"\nNome:{Newtempdata2[1].Cpf}");

                    ListarClientes(Newtempdata, Newtempdata2);
                }
            }

                   

            Console.ReadKey();
        }

    

        static void ListarClientes(List<Cliente> iCliente, List<HistVendas> iHistVendas)
        {
            List<HistVendas> objList = iHistVendas.OrderBy(HistVendas => HistVendas.ValorTotal).ToList();

            foreach(HistVendas element in objList)
            {
                
                Cliente result = iCliente.FindLast ( cli => cli.Cpf == element.Cpf);
                if (result != null)
                {
                    Console.WriteLine($"Cliente:{result.Nome} Valor Total # {element.ValorTotal.ToString()}");
                }
            }


        }


    }

}
