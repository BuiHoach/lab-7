using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7._3
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TheoryMark { get; set; }
        public double LabMark { get; set; }

        // Constructor
        public Student(int id, string name, double theoryMark, double labMark)
        {
            Id = id;
            Name = name;
            TheoryMark = theoryMark;
            LabMark = labMark;
        }

        // Phương thức kiểm tra điểm hợp lệ
        public void ValidateMarks()
        {
            if (TheoryMark < 0 || TheoryMark > 10)
            {
                throw new InvalidMarkException("Điểm lý thuyết phải nằm trong khoảng từ 0 đến 10.");
            }

            if (LabMark < 0 || LabMark > 10)
            {
                throw new InvalidMarkException("Điểm thực hành phải nằm trong khoảng từ 0 đến 10.");
            }
        }
    }
}

