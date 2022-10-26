using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Works works = new Works();
            Works worksTwo = new Works();
            works.name = "ali";works.surname = "pehlivan"; works.country = "izmir";
            worksTwo.name = "onur"; worksTwo.surname = "kopuz"; worksTwo.country = "izmir";
            works.info();worksTwo.info();
            Console.ReadLine();

        }



    }
    class Works
    {
        public string name;
        public string surname;
        public string country;

        public void info()
        {
            Console.Write(name + " " + surname + " " + country);



        }


        
    }
    
}

