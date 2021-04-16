using System;
using System.Data.Entity;
using System.Collections.Generic;






namespace Kartkw
{
    class Student
    {
        public int ID { get; set; }
        public int Deficyt { get; set; }

        public string Name { get; set; }
    }

    class AiRW4 : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AiRW4())
            {
                var s = new Student() { Deficyt = 11, Name="Chad" };

                db.Students.Add(s);
                db.SaveChanges();


                foreach(var st in db.Students)
                {
                    Console.WriteLine($"ID: {st.ID} Imie: {st.Name} Deficy:{st.Deficyt}");

                }
                Console.ReadLine();


            }
        }
    }
}
