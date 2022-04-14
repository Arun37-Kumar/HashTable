using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table Problem!\n---------------");
            MyMapNode<string, string> hashAdd = new MyMapNode<string, string>(5);

            //Add data
            hashAdd.Add("0", "To");
            hashAdd.Add("1", "be");
            hashAdd.Add("2", "or");
            hashAdd.Add("3", "not");
            hashAdd.Add("4", "to");
            hashAdd.Add("5", "be");

            //Get Value and Display
            string hash5 = hashAdd.Get("5");
            Console.WriteLine("5th index  value : {0}", hash5);

            //Get Value and Display
            string hash2 = hashAdd.Get("2");
            Console.WriteLine("2nd index  value : {0}", hash2);

            Console.WriteLine("========================================");

            int key=0;
            string paragraphPhrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] paragraph = paragraphPhrase.Split(new[] { ' ' });

            MyMapNode<int, string> myMapNode = new MyMapNode<int, string>(paragraph.Length);
            //Add 
            foreach (string word in paragraph)
            {
                myMapNode.Add(key, word);
                key++;
            }

            //Display
            Console.WriteLine("Frequency of words ");

            for (key = 0; key < paragraph.Length; key++)
            {
                string value = myMapNode.Get(key);
                Console.WriteLine(key + " - " + value);
            }
            Console.ReadLine();
        }
    }
}