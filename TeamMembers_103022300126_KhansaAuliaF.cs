using System;
using System.Collection.Generic;
using System.IO;
using System.Text.Json;

namespace Modul7_103022300126
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
        public string gender { get; set; }
    }

    public class TeamMember
    {
        public List<Member> members { get; set; }
    }

    public class TeamMembers103022300126 {
        public void ReadJSON(string json)
        {
            try
            {

                string jsonPath = "jurnal7_2_103022300126.json";
                string jsonString = File.ReadAllText(jsonPath);

               TeamMembers103022300126 m = JsonSerializer.Deserialize<TeamMembers103022300126>(jsonString);

                Console.WriteLine($"{m.nim} {m.FirstName} {m.LastName} ({m.age} {m.gender})");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
        }
    }

    class program {

        static void Main(string[] args)
        {
            var data = new Mahasiswa10302230012();
            data.ReadJSON();

            Console.WriteLine();

            var team = new TeamMembers103022300126();
            team.ReadJSON();
        }
    }
}