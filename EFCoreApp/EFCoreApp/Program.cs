using System;

class Program
{
    static void Main(string[] args)
    {
        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();

            db.Users.AddRange(
                new User { FirstName = "����", LastName = "������", Age = 20 },
                new User { FirstName = "����", LastName = "������", Age = 29 },
                new User { FirstName = "�����", LastName = "��������", Age = 25 }
            );
            db.SaveChanges();

            Console.WriteLine("������������ � ����:");
            foreach (var user in db.Users)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName}, �������: {user.Age}");
            }
        }
    }
}
