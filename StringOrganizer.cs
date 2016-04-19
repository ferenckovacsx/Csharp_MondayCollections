using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayCollections_OrganizeStrings
{
    class StringOrganizer
    {
        public static void Main()
        {
            ArrayList arrayOfStrings = new ArrayList();
            string input = "";

            Console.WriteLine("Write some text then press Enter. This text will be added to the list.");
            input = Console.ReadLine();
            arrayOfStrings.Add(input);

            while (input.Length > 0)
            {
                Console.WriteLine("Add another string then press Enter. Submit an empty string when you are done!");
                input = Console.ReadLine();
                arrayOfStrings.Add(input);
            }

            Console.WriteLine("Below you can find the original list of strings (unsorted): ");

            foreach (var item in arrayOfStrings)
            {
                Console.WriteLine(item);
            }

            arrayOfStrings.Sort();

            Console.WriteLine("Here is the list of strings organized alphabetically: ");

            foreach (var item in arrayOfStrings)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
