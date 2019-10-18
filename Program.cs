using Amazon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Channels;

namespace Test
{
    class Program
    {
        

        static void Main(string[] args)
        {

               Shape shape = new TextTwo();
               TextTwo text = (TextTwo) shape;
               
               

               // Composition 
               //StackOVerFlow();
               //StopWatch();

        }

        public static void Composition()
        {
            var dbmigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

             

            dbmigrator.Migrate();
            installer.Install();
        }

        // Down here I have created different types of exercises for my self to train. Feel free to try them out. Write the static void method in Main to get started.
        
        static void UseParam()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 3));
            Console.WriteLine(calculator.Add(1, 3, 6));

        }

        static void UseTry()
        {
            try
            {
                var num = int.Parse("ABC");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed");
                throw;
            }

            int number;
            var result = int.TryParse("ABC", out number);
            if (result)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("It failed");
            }
        } 
        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("point is at({0}, {1})",
                    point.X, point.Y);
                point.Move(100, 200);
                Console.WriteLine("HElllo ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                throw;
            }
        }

        static void StackOVerFlow()
        {
            var post = new Post();

            Console.WriteLine("Create a post for StackOverFlow, Start with Title");
            Console.WriteLine("Title:");
            // 
            post.Title = Console.ReadLine();
            Console.WriteLine("Description");

            post.Description = Console.ReadLine();
            post.Posted = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.Posted);


            Console.WriteLine(@"Post you vote. u = up and d = down press any other key to get total.");
            while (true)
            {
                var input = Console.ReadLine()?.ToLower();

                if (input != null && input.Contains("u"))
                {
                    post.UpVote();
                    Console.WriteLine("Post up-voted");
                }
                else if (input.Contains(("d")))
                {
                    post.DownVote();
                    Console.WriteLine("Post down-voted");
                }
                else
                {
                    Console.WriteLine("Total {0}", post.VoteValue);
                    return;
                }
            }

        }

        static void StopWatch()
        {
            var stopWatch = new Stopwatch();
            while (true)
            {
                Console.WriteLine("enter 'start' to start StopWatch\nEnter 'stop' to end StopWatch\n ");
                var input = Console.ReadLine()?.ToLower();
                if (input != null && (!input.Contains("start") && !input.Contains("stop")))
                    return;
                else
                {
                    switch (input)
                    {
                        case "start":
                            stopWatch.Start();
                            break;
                        case "stop":
                            Console.WriteLine("Duration :{0}", stopWatch.Stop());
                            break;
                        default:
                            Console.WriteLine("Invalid command");
                            break;
                    }

                }


            }
        }
    }
}
