using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7._3
{
    public class InvalidMarkException : Exception
    {
        // Constructor không tham số
        public InvalidMarkException() : base("Điểm không hợp lệ. Điểm phải nằm trong khoảng từ 0 đến 10.") { }

        // Constructor có tham số là thông báo lỗi
        public InvalidMarkException(string message) : base(message) { }
    }
}


