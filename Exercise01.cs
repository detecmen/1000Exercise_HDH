//Bài 1: Tính S(n) = 1 + 2 + 3 + … + n
using System;
using System.Text;
namespace Exercise01;
class Program
    {
        static void  Main(string[] arfgs)
       { 
        Console.InputEncoding=Encoding.Unicode;
        Console.OutputEncoding=Encoding.Unicode;
        Console.Write("Nhập số nguyên n : ");
        int n = Convert.ToInt32(Console.ReadLine());
        // Gọi hàm tính tổng ra kết quả 
        Console.WriteLine ($"Sum(n) = { n*(n+1)/2 }");

       }
    }