using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7._1
{
    internal class AnThit
    {
        // Lớp CaSau
        public class CaSau
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            // Constructor
            public CaSau(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"CaSau - ID: {ID}, Name: {Name}, Weight: {Weight} kg");
            }
        }

        // Lớp Ho
        public class Ho
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            // Constructor
            public Ho(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Ho - ID: {ID}, Name: {Name}, Weight: {Weight} kg");
            }
        }

        // Lớp SuTu
        public class SuTu
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            // Constructor
            public SuTu(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"SuTu - ID: {ID}, Name: {Name}, Weight: {Weight} kg");
            }
        }
    }

}

