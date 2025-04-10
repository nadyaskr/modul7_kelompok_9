using System;
using System.Collection.Generic;
using System.IO;
using System.Text.Json;

namespace Modul7_103022300126 {

    public class Name {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class Mahasiswa103022300126 {
        public Name name { get; set; }
        public long nim { get; set; }
        public string fakult { get; set; }
     
    }
    public void ReadJSON(string json)
        {
            try {

                string jsonPath = "jurnal7_1_103022300126.json";
                string jsonString = File.ReadAllText(jsonPath);

                Mahasiswa103022300126 mhs = JsonSerializer.Deserialize<Mahasiswa103022300126>(jsonString);

                Console.WriteLine($"Name {mhs.Name.depan} {mhs.name.belakang} dengan nim {mhs.nim} dari fakultas {mhs.Fakultas}");

            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);

            }
        }

        class Program {
        static void Main(string[] args) {
            var data = new Mahasiswa103022300126();
            data.ReadJSON();
        }
    }
}

