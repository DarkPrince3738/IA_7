using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User(651651,
                "Tom",
                "Riddle",
                "Male",
                "aekmhaemh@gmail.com",
                "Not Hack",
                new DateTime(1991, 12, 05),
                "Active");

            Console.WriteLine(user1.GetShortInfo());
            
            Console.WriteLine(user1.GetAllInfo());

            user1.ChangePassword("newPassword");

            Console.WriteLine($"" +
                $"id - {user1.Id}\n" +
                $"FirstName - {user1.FirstName}\n" +
                $"LastName - {user1.LastName}\n" +
                $"DateOfBirth - {user1.DateOfBirth}\n" +
                $"Gender - {user1.Gender}\n" +
                $"email - {user1.email}\n" +
                $"Password - {user1.Password}\n" +
                $"status - {user1.status}\n");











            var user4 = new User(651651,
                 "Tom",
                 "Riddle",
                 "Male",
                 "aekmhaemh@gmail.com",
                 "Not Hack");
            var user5 = new User(651651,
                 "Tom",
                 "Riddle",
                 "Male",
                 "aekmhaemh@gmail.com",
                 "Not Hack",
                new DateTime(1991, 12, 05));

            /*user1.Id = 651651;
            user1.FirstName = "Tom";
            user1.LastName = "Riddle";
            user1.DateOfBirth = new DateTime(1991,12,05);
            user1.Gender = "Male";
            user1.email = "aekmhaemh@gmail.com";
            user1.Password = "Not Hack";
            user1.status = "Active";*/
            /*Console.WriteLine($"" +
                $"id - {user1.Id}\n" +
                $"FirstName - {user1.FirstName}\n" +
                $"LastName - {user1.LastName}\n" +
                $"DateOfBirth - {user1.DateOfBirth}\n" +
                $"Gender - {user1.Gender}\n" +
                $"email - {user1.email}\n" +
                $"Password - {user1.Password}\n" +
                $"status - {user1.status}\n");

            var user2 = new User(); 

            user2.Id = 3678;
            user2.FirstName = "Chuvak";
            user2.LastName = "Chuvakenko";
            user2.DateOfBirth = new DateTime(2019, 08, 12);
            user2.Gender = "Female";
            user2.email = "givemoney@gmail.com";
            user2.Password = "angryChuvak";
            user2.status = "Unactive";
            Console.WriteLine($"" +
                $"id - {user2.Id}\n" +
                $"FirstName - {user2.FirstName}\n" +
                $"LastName - {user2.LastName}\n" +
                $"DateOfBirth - {user2.DateOfBirth}\n" +
                $"Gender - {user2.Gender}\n" +
                $"email - {user2.email}\n" +
                $"Password - {user2.Password}\n" +
                $"status - {user2.status}\n");

            var user3 = new User(); 
            
            user3.Id = 5621;
            user3.FirstName = "Person";
            user3.LastName = "Nosrep";
            user3.DateOfBirth = new DateTime(1923, 10, 07);
            user3.Gender = "Male";
            user3.email = "";
            user3.Password = "";
            user3.status = "";
            Console.WriteLine($"" +
                $"id - {user3.Id}\n" +
                $"FirstName - {user3.FirstName}\n" +
                $"LastName - {user3.LastName}\n" +
                $"DateOfBirth - {user3.DateOfBirth}\n" +
                $"Gender - {user3.Gender}\n" +
                $"email - {user3.email}\n" +
                $"Password - {user3.Password}\n" +
                $"status - {user3.status}\n");*/
        }
    }
}
