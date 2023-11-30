using System.Text;

namespace Lession1_Lab1
{
    internal class Program
    {
        ///<summary>
        ///
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Khai báo biến 
            int Id = 1;
            string name = "Test";
            int age = 23;
            string gender = "Male";
            //int gender = 1;
            //char gender = 'M';

            //Khai báo hằng số
            const float percent = 100;

            //Hiển thị giá trị 
            Console.WriteLine(Id);
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(gender);

            //------------------------------BAI 1 ----------------------------------
            Console.WriteLine("Bài 1");
            Console.WriteLine("");
            Console.WriteLine("    +++++++++++++                   ++++        ++++");
            Console.WriteLine("  ++++++++++++++++            ++++++++++++++++++++++++++");
            Console.WriteLine(" ++++           +++         ++++++++++++++++++++++++++");
            Console.WriteLine("++++                            ++++        ++++");
            Console.WriteLine("++++                           ++++        ++++");
            Console.WriteLine("++++          ++++       +++++++++++++++++++++++++");
            Console.WriteLine("+++++++++++++++++       +++++++++++++++++++++++++");
            Console.WriteLine("  +++++++++++++             ++++       ++++");
            Console.WriteLine("");

            //------------------------------BAI 2 ----------------------------------
            Console.WriteLine("Bài 2");
            Console.WriteLine("");
            string MNV;
            string TenNV;
            DateTime DateofBirth;
            string Address;
            int SDT;
            string Email;

            Console.WriteLine("Nhập mã NV: ");
            MNV = Console.ReadLine();
            Console.WriteLine("Nhập Tên: ");
            TenNV = Console.ReadLine();
            Console.WriteLine("Nhập sinh nhật (Năm Tháng Ngày): ");
            DateofBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhập Địa chỉ: ");
            Address = Console.ReadLine();
            Console.WriteLine("Nhập Số điện thoại: ");
            SDT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập email: ");
            Email = Console.ReadLine();

            Console.WriteLine(MNV);
            Console.WriteLine(TenNV);
            Console.WriteLine(DateofBirth.ToString("dd-MM-yyyy"));
            Console.WriteLine(Address);
            Console.WriteLine(SDT);
            Console.WriteLine(Email);
        }
    }
}