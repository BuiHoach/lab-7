using System.Text;

namespace lab_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Minh họa InvalidCastException
            try
            {
                object obj = "Hello, World!";
                int number = (int)obj;  // Sẽ gây ra InvalidCastException
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Lỗi InvalidCastException: " + ex.Message);
            }

            // Minh họa IndexOutOfRangeException
            try
            {
                int[] numbers = new int[3];
                numbers[5] = 10;  // Sẽ gây ra IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Lỗi IndexOutOfRangeException: " + ex.Message);
            }

            // Minh họa ArrayTypeMismatchException (sửa lỗi này)
            try
            {
                object[] objects = new object[3];
                objects[0] = 1;  // Sử dụng kiểu int
                objects[1] = 2;  // Sử dụng kiểu int
                objects[2] = 3;  // Sử dụng kiểu int

                // Kiểm tra mảng và ép kiểu hợp lệ
                int[] numbers = Array.ConvertAll(objects, item => (int)item); // Chuyển đổi từ object[] sang int[] một cách hợp lệ
                Console.WriteLine("Mảng sau khi chuyển: " + string.Join(", ", numbers));
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine("Lỗi ArrayTypeMismatchException: " + ex.Message);
            }

            Console.WriteLine("Chương trình kết thúc!");
        }
    }
}

