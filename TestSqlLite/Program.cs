using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using TestSqlLite.models;
using TestSqlLite.data;

class Program
{
    static async Task Main(String[] args)
    {
        using (var db = new DataBaseContext())
        {
            await db.Database.EnsureCreatedAsync();

            var usuario = new User()
            {
                user = "Luis José",
                passwd = "Suneon10",
                alias = "Ersun"
            };
            var usuario2 = new User()
            {
                user = "Jonathan",
                passwd = "Cazanubes10",
                alias = "Darki"
            };
            db.users.Add(usuario);
            db.users.Add(usuario2);

            await db.SaveChangesAsync();
        }
    }

   
}

