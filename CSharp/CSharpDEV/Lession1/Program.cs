namespace Lession1
{


    internal class Program
    {
        static void Main(string[] args)
        {
            //Kiểu dữ iệu
            //Kiểu số nguyên: int, long short, byte
            int number = 12;
            Console.WriteLine(number);

            //Kiểu số thực: float, double, decimal
            //float: Kiểu số thực có độ chính xác kém nhất
            //double: Kiểu số thực có độ chính xác cao
            //deciaml: Kiểu số thực có độ chính xác cao
            double mark = 2.5;
            Console.WriteLine(mark);

            //Kiểu ký tự và chuỗi
            //char: Kiểu dữ liệu Unicode, có kích thước 16-bit
            //string: kiểu chuỗi ký tự
            string name = "Devmaster";
            Console.WriteLine(name);

            //kiểu logic
            //bool: Trả về giá trị "True" hoặc "False"
            bool check = false;
            Console.WriteLine(check);

            //kiểu ngày và thời gian
            //DateTime: Biểu diễn ngày và thời gian
            //TimeScan: Biểu diễn một khoảng thời gian
            DateTime dateOfBirth = new DateTime(2023, 9, 18);
            Console.WriteLine(dateOfBirth);
            Console.WriteLine(dateOfBirth.ToString("dd-MM-yyyy"));

            //Đặt tên biến
            string fullName = "DevMaster";
            string FullName = "DEV";
            Console.WriteLine(FullName);

            //Các toán tử
            //Số học
            int a = 1;
            int b = 2;

            int c = a % b;
            Console.WriteLine(c);

            //So sánh
            bool d = a < b;
            Console.WriteLine(d);

            //Logic
            int e = 2;
            bool f = a > b || b == e;
            Console.WriteLine(f);

            //Gán
            int g = 3;
            g *= 3;

            Console.WriteLine(g);

            //Tăng giảm
            int h = 4;
            int i = 5;

            h++;
            i--;
            Console.WriteLine(i);
            Console.WriteLine(h);

            //Nối chuỗi
            string str1 = "DEV";
            string str3 = "  ";
            string str2 = "Master";

            string result = str1 + str3 + str2;
            Console.WriteLine(result);

            //Điều kiện
            int k = 1;
            int m = 2;

            string numberResult = (k > m) ? "k lớn m" : "k nhỏ hơn m";

            Console.WriteLine(numberResult);
        }
    }
}