using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace sample1
{
    class Program:Animal
    {

        static void Main(string[] args)
        {


            IList<Animal> animallist = new List<Animal>() {
                new Animal.add({zname="Nehru Zoological Park",zcity="Hyderabad",zstate="Telangana",Aname="TIGER",Abreed="BENGALI TIGER",Acount="5",Zoodetails() )
                 new Animal(){zname="Nehru Zoological Park",zcity="Hyderabad",zstate="Telangana",Aname="TIGER",Abreed="BENGALI TIGER",Acount="5"},
                  new Animal(){zname="Nehru Zoological Park",zcity="Hyderabad",zstate="Telangana",Aname="TIGER",Abreed="BENGALI TIGER",Acount="5"},

            };

            foreach (var el in animallist)
                Console.WriteLine(el);
            Console.ReadLine();
        }
    }
       

       
        
        
    }

