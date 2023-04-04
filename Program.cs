using Microsoft.EntityFrameworkCore;
using System;
using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repository;

namespace WiredBrainCoffee.StorageApp
{
    class program
    {
        static void Main(string[] args)
        {
            Employee();
            organization();
        }

        private static void organization()
        {
            var org = new SqlRepository<Organization, string>(new StorageAppDbContext());
            AddOrganization(org);
        }

        private static void AddOrganization(IRepository<Organization, string> org)
        {
            org.AddItem(new Organization { Name = "pluralsight" });
            org.AddItem(new Organization { Name = "soprasteia" });
            org.PrintItem();

            Console.WriteLine($"organization with id no 2 is: {org.GetById(2)} ");
        }

        private static void Employee()
        {
            var manager = new ListRepository<Employee, int>();
            AddEmployee(manager);
            WriteAllToConsole(manager);
        }

        private static void WriteAllToConsole(IRepository<EntityBase, int> manager)
        {
            var items = manager.GetAll();
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void AddEmployee(IRepository<Employee, int> manager)
        {
            manager.AddItem(new Employee { FirstName = "vinay " });
            manager.AddItem(new Employee { FirstName = "Ramu" });
            manager.AddItem(new Employee { FirstName = "punit" });
            manager.PrintItem();
            Console.WriteLine($"employee with id no 3 is: {manager.GetById(3)} ");
        }
    }
}