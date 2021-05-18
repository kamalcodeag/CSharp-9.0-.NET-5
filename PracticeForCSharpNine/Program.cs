using System;

#region Top-level statements
//First way
//Console.WriteLine("Top-level statements remove unnecessary ceremony from many applications");
//Second way
//System.Console.WriteLine("Top-level statements remove unnecessary ceremony from many applications");
#endregion

namespace PracticeForCSharpNine
{
    class Program
    {
        static void Main(string[] args)
        {
            #region INIT keyword
            //Person p = new Person
            //{
            //    FirstName = "Soft",
            //    LastName = "Dev"
            //};

            ////p.FirstName = "SoftUp"; //Compile time error due to "init" keyword in class
            //p.LastName = "DevUp";

            //Console.WriteLine(p.FirstName + "\r\n" + p.LastName); //Soft DevUp
            #endregion


            #region RECORD keyword
            //Standard properties
            //User user = new User
            //{
            //    UserName = "softdev",
            //    Password = "1234sd_"
            //};

            //Console.WriteLine(user.UserName + "\r\n" + user.Password); //softdev 1234sd_

            //Positional parameters("init" keyword is automatically given to properties)
            //User user = new("softdev", "1234sd_");
            //Console.WriteLine(user.UserName + "\r\n" + user.Password); //softdev 1234sd_
            //user.UserName = "softdevUp"; //Compile time error due to "init" keyword which is automatically given to properties in record

            //Value equality
            //User user1 = new("softdev", "softdev");
            //User user2 = new("softdev", "softdev");

            //Console.WriteLine(user1 == user2); //true
            //Console.WriteLine(ReferenceEquals(user1, user2)); //false

            //Nondestructive mutation("with" keyword)
            //User user1 = new("softdev", "1234sd_") { Age = 26 };
            //Console.WriteLine(user1.UserName + "\r\n" + user1.Password + "\r\n" + user1.Age); //softdev 1234sd_ 26

            //User user2 = user1 with { Age = 27 };
            //Console.WriteLine(user2.UserName + "\r\n" + user2.Password + "\r\n" + user2.Age); //softdev 1234sd_ 27

            //user2 = user1 with { UserName = "softdevUp" };
            //Console.WriteLine(user2.UserName + "\r\n" + user2.Password + "\r\n" + user2.Age); //softdevUp 1234sd_ 26

            //user2 = user1 with { };
            //Console.WriteLine(user2.UserName + "\r\n" + user2.Password + "\r\n" + user2.Age); //softdev 1234sd_ 26
            #endregion
        }
    }
}