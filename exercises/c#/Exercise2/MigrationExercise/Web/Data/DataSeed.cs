using System.Collections.Generic;
using System.Linq;
using Web.Data.Models;

namespace Web.Data
{
    public static class DataSeed
    {
        public static List<Person> People = new List<Person>() {
            new Person() { Name = "Test1" },
            new Person() { Name = "Test2" }
        };

        public static void AddData(ExerciseDbContext context)
        {
            if (!context.Person.Any())
            {
                foreach (var person in People)
                {
                    context.Person.Add(person);
                    context.SaveChanges();
                }
            }
        }
    }
}
