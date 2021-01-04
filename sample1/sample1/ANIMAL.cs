using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample1
{
    abstract class Zoo
    {
         public  string zname { get; set; }
         public string zcity { get; set; }
         public string zstate { get; set; }



        public virtual  void Zoodetails()
        {
            Console.WriteLine("ZOO  NAME::" + zname);
            Console.WriteLine("ZOO  CITY: " + zcity);
            Console.WriteLine("ZOO  STATE:" + zstate);

        }


    }
}
