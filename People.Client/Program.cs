using System;
using People.Client.Services;

namespace People.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DisplayResults();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static void DisplayResults()
        {
            Console.WriteLine("OUTPUT 1 - Sorted by GENDER:\n");
            foreach (var person in PeopleHelperService.RecordsByGender)
            {
                Console.WriteLine($"{person.LastName}\t{person.FirstName}\t{person.Gender}\t{person.DateOfBirth.ToString("M/d/yyyy")}\t{person.FavoriteColor}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("OUTPUT 2 - Sorted by BIRTH DATE:\n");
            foreach (var person in PeopleHelperService.RecordsByBirthday)
            {
                Console.WriteLine($"{person.LastName}\t{person.FirstName}\t{person.Gender}\t{person.DateOfBirth.ToString("M/d/yyyy")}\t{person.FavoriteColor}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("OUTPUT 3 - Sorted by NAME:\n");
            foreach (var person in PeopleHelperService.RecordsByName)
            {
                Console.WriteLine($"{person.LastName}\t{person.FirstName}\t{person.Gender}\t{person.DateOfBirth.ToString("M/d/yyyy")}\t{person.FavoriteColor}");
            }
        }
    }
}
