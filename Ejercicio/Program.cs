using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> diccionario= new Dictionary<string, string>();
            diccionario.Add("hello my name is karla", "hola mi nombre es karla");
            diccionario["see you later"] = "hasta luego";

            Console.WriteLine(diccionario["hello my name is karla"]);
            

                if (diccionario.ContainsKey("adios"))
                    Console.WriteLine(diccionario["adios"]);
                char[] delimitador = { ',', ' ' };
                string[] palabras = ("hola mi nombre es karla").Split(delimitador);
                int i;
                for (i=0;i<palabras.Length; i++)
                {
                   
                    Console.WriteLine("fragmento{0}={1}", i + 1, palabras[i]);

                }  

         Console.ReadKey();

        }
    }
        
}
