
using Microsoft.EntityFrameworkCore;
using PersonRegister.Data;
using PersonRegister.Data.Models;

namespace PersonRegister
{
    public class StartUp
    {
        static async Task Main(string[] args)
        {

            var contextFactory = new PersonRegisterDbContextFactory();

            var dbContext = contextFactory.CreateDbContext(args);

            await dbContext.Database.MigrateAsync();
            //Person person = new Person();
            //person.FirstName = "zonzo";
            //person.LastName = "the";
            //person.City = "mix";
            //person.Age = 33;

            // dbContext.Person.Add(person);
            //await dbContext.SaveChangesAsync();

            var person = dbContext.Person.Where(p => p.FirstName == "zonzo").ToList();

            foreach (var p in person)
            {
                await Console.Out.WriteLineAsync($"{p.FirstName} is from {p.LastName} {p.City}");
            }
        }


    }
}
