using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7._1
{
    internal class AnCo
    {

        // Lớp Bo
        public class Bo
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            // Constructor
            public Bo(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Bo - ID: {ID}, Name: {Name}, Weight: {Weight} kg");
            }
        }

        // Lớp Trau
        public class Trau
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            // Constructor
            public Trau(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Trau - ID: {ID}, Name: {Name}, Weight: {Weight} kg");
            }
        }

        // Lớp De
        public class De
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            // Constructor
            public De(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"De - ID: {ID}, Name: {Name}, Weight: {Weight} kg");
            }
        }
    }

}

