using demoEntityFramework.DbManager;
using demoEntityFramework.Model;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("===Demo Entity ");

using AppDbContex db = new AppDbContex();


db.Database.Migrate();


db.Personne.Add(new Personne("Toto", "Tata", 30, "0123456789", "test@test.com"));
db.SaveChanges();
