using System.Collections;
using System.Collections.Generic;

namespace HashTableAndTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Hash Table Program");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0","To");
            hash.Add("1"," be");
            hash.Add("2","or");
            hash.Add("3","not");
            hash.Add("4","to");
            hash.Add("5","be");



            hash.Remove("2");
            string hash2 = hash.Get("2");
            Console.WriteLine("2nd index Value:  " + hash2);
        }
    }
}
