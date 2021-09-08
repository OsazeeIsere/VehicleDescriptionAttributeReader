using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplyingAttributes;
using AttributedCarLibrary;

namespace VehicleDescriptionAttributeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value of VehicleDescriptionAttribute \n");
            RelectOnAttributeUsingEarlyBinding();
            Console.ReadLine();

        }

        private static void RelectOnAttributeUsingEarlyBinding()
        {
            //Get a type  representing on Winnebago.
            Type t = typeof(Winnebago);

            //Get all attributes on the Winnebago.
            object[] customAtts = t.GetCustomAttributes(false);

            //print the description.
          foreach(VehicleDescriptionAttribute v in  customAtts)
                Console.WriteLine("{0} \n,",v.Description);

        }
    }
}
