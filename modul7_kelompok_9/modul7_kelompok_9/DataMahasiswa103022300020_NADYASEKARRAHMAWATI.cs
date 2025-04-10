using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using modul7_kelompok_9;

namespace modul7_kelompok_9
{
    internal class DataMahasiswa103022300020_NADYASEKARRAHMAWATI
    {
        public class Addres
        {
            public string StreetAdrres { get; set; }
            public string City { get; set; }
            public string State { get; set; }
        }

        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class DataMahasiswa1003022300020_NADYASEKARRAHMAWATI
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Gender { get; set; }

            public string Age { get; set; }

            public Addres Addres { get; set; }

            public List<Course> Courses { get; set; }

            public static void ReadJSON()
            {
                string jsonString = File.ReadAllText("jurnal7_1_103022300020.json");
                var data = JsonSerializer.Deserialize<DataMahasiswa1003022300020_NADYASEKARRAHMAWATI>(jsonString);

                Console.WriteLine($"Name : {data.FirstName} {data.LastName}");
                Console.WriteLine($"Gender : {data.Gender}");
                Console.WriteLine($"Age : {data.Age}");
                Console.WriteLine("Addres:");
                Console.WriteLine($"Street : {data.Addres.StreetAdrres}");
                Console.WriteLine($"City : {data.Addres.City}");
                Console.WriteLine($"Stage : {data.Addres.State}");

                Console.WriteLine("Course:");
                foreach (var course in data.Courses)
                {
                    Console.WriteLine($" {course.code} {course.name}");
                }
            }
        }

        internal static void ReadJSON()
        {
            throw new NotImplementedException();
        }
    }
}

class program
{
    static void main(string[] args)
    {
        DataMahasiswa103022300020_NADYASEKARRAHMAWATI.ReadJSON();
    }
}