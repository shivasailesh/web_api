using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample1
{
    class Animal:Zoo,IAnimal
    {
       public  string Aname { get; set; }
       public string Abreed { get; set; }
       public   string Acount { get; set; }
        
       // string time1 { get; set; }
        //string time2 { get; set; }
        // string time3 { get; set; }


        public override  void Zoodetails()//method overriding
       {

            Console.WriteLine("ZOO  NAME::" +zname);
            Console.WriteLine("ZOO  CITY: " + zcity);
            Console.WriteLine("ZOO  STATE:" + zstate);
        }

        public void Animaldetails()
        {
           Console.WriteLine("ANIMAL  NAME::"+ Aname);
            Console.WriteLine("ANIMAL  BREED: "+ Abreed); 
            Console.WriteLine("ANIMAL  COUNT:"+ Acount);
            Console.ReadLine();
        }
     /*   public void Foodtiming()
        {
            Console.WriteLine("MORNING TIME:"+ time1);
        }
        public void Foodtiming1()
        {
            Console.WriteLine("AFTERNOON TIME:"+ time2);
            Console.WriteLine("NIGHT TIME:"+ time3);
            ;*/
        }
    }


