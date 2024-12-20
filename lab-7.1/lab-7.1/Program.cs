using System.Text;

namespace lab_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Khởi tạo các đối tượng trong namespace AnCo
            AnCo.Bo bo = new AnCo.Bo(1, "Bo 1", 500);
            AnCo.Trau trau = new AnCo.Trau(2, "Trau 1", 600);
            AnCo.De de = new AnCo.De(3, "De 1", 30);

            // Khởi tạo các đối tượng trong namespace AnThit
            AnThit.CaSau caSau = new AnThit.CaSau(1, "Ca Sau 1", 80);
            AnThit.Ho ho = new AnThit.Ho(2, "Ho 1", 150);
            AnThit.SuTu suTu = new AnThit.SuTu(3, "Su Tu 1", 200);

            // Hiển thị thông tin
            bo.DisplayInfo();
            trau.DisplayInfo();
            de.DisplayInfo();

            caSau.DisplayInfo();
            ho.DisplayInfo();
            suTu.DisplayInfo();
        }
    }
}

