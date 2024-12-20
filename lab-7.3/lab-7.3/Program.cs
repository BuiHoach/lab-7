using System.Text;

namespace lab_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            try
            {
                // Nhập thông tin sinh viên
                Console.WriteLine("Nhập ID sinh viên:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhập tên sinh viên:");
                string name = Console.ReadLine();

                Console.WriteLine("Nhập điểm lý thuyết:");
                double theoryMark = double.Parse(Console.ReadLine());

                Console.WriteLine("Nhập điểm thực hành:");
                double labMark = double.Parse(Console.ReadLine());

                // Tạo đối tượng sinh viên
                Student student = new Student(id, name, theoryMark, labMark);

                // Kiểm tra tính hợp lệ của điểm
                student.ValidateMarks();

                Console.WriteLine("Thông tin sinh viên hợp lệ.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập đúng kiểu dữ liệu.");
            }
            catch (InvalidMarkException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi không xác định: " + ex.Message);
            }
        }
    }
}
