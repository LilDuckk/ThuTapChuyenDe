using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string[] canArray = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
        string[] chiArray = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi","Thân","Dậu","Tuất","Hợi",
                              // Lặp lại các giá trị CHI để tạo chu kỳ 60 năm
                              // (12 giá trị CHI * 5 giá trị CAN)
                              // Ví dụ: Năm 2013 tương ứng với Mậu Đinh (4,3)
                              // => Chu kỳ tiếp theo sẽ là Quý Mão (5,4)
                            };

        int startYear = 2010;
        string startCan = canArray[6]; // Canh
        string startChi = chiArray[2]; // Dần
        int currentYear;

        Console.Write("Nhập một năm bất kỳ: ");
        currentYear = Convert.ToInt32(Console.ReadLine());

        int yearDifference = currentYear - startYear;

        int canIndex = (yearDifference + Array.IndexOf(canArray, startCan)) % canArray.Length;
        int chiIndex = (yearDifference + Array.IndexOf(chiArray, startChi)) % chiArray.Length;

        string nextCanChiValue = canArray[canIndex] + ' ' + chiArray[chiIndex];

        Console.WriteLine($"CAN + CHI tương ứng với năm {currentYear} là: {nextCanChiValue}");
    }
}