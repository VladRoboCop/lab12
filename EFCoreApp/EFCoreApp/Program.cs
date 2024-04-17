using System;

class Program
{
    static void Main(string[] args)
    {
        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();

            db.Users.AddRange(
                new User { FirstName = "Иван", LastName = "Иванов", Age = 20 },
                new User { FirstName = "Петр", LastName = "Петров", Age = 29 },
                new User { FirstName = "Мария", LastName = "Сидорова", Age = 25 }
            );
            db.SaveChanges();

            Console.WriteLine("Пользователи в базе:");
            foreach (var user in db.Users)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName}, возраст: {user.Age}");
            }
        }
    }
}
