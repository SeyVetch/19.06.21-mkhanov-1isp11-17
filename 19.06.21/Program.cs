using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._06._21
{
    class Feline
    {
        public string colour;
        public string pattern;
        public int gender;
        public string size;
        public bool domesticated;
        public void Call()
        {
            Console.WriteLine((domesticated ? "ручн" : "не ручн") + (gender == 0 ? "ая кошачья " : "ой кошачий ") + colour + " цвета с " + pattern + " типом окраски");
        }


    }
    class Cat : Feline
    {
        new public string size = "small";
        new public bool domesticated = true;
        new public void Call()
        {
            Console.WriteLine("ручн" + (gender == 0 ? "ая кошка " : "ой кот ") + colour + " цвета с " + pattern + " типом окраски");
        }

        class Tiger : Feline
        {
            new public string size = "big";
            new public void Call()
            {
                Console.WriteLine("не ручн" + (gender == 0 ? "ая тигра " : "ой ктигрот ") + colour + " цвета с " + pattern + " типом окраски");
            }
        }
    }
class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
