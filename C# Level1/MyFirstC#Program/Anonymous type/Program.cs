using System;

namespace Main
    {
        internal class Program
        {


       
        static void Main(string[] args)
            {
            
            //you dont specify any type here , automatically will be specified
            var student = new { Id = 20, FirstName = "Ibraim", LastName = "Imad" };

            Console.WriteLine("\nExample1:\n");
            Console.WriteLine(student.Id); 
            Console.WriteLine(student.FirstName); 
            Console.WriteLine(student.LastName); 
           
            //You can print like this:
            Console.WriteLine(student);

           
            //anonymous types are read-only
            //you cannot change the values of properties as they are read-only.

           // student.Id = 2;//Error: cannot chage value
           // student.FirstName = "Ali";//Error: cannot chage value


           //An anonymous type's property can include another anonymous type.
           var student2 = new
            {
                Id = 20,
                FirstName = "Ibrahim",
                LastName = "Imad",
                Address = new { Id = 1, City = "Baghdad", Country = "Iraq" }
            };

            Console.WriteLine("\nExample2:\n");
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);

            Console.WriteLine(student2.Address.Id);
            Console.WriteLine(student2.Address.City);
            Console.WriteLine(student2.Address.Country);
            Console.WriteLine(student2.Address);


            }
        }
    }