using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _14._12._2023
{
    public class Ref1
    {
        public void Main(string[] args) // Убрал static, потому что выдавало ошибку
        {
            Console.WriteLine(Output());
            Console.WriteLine(AddInts(1, 2));
        }
        public string Output()
        {
            return "Test-Output";
        }
        public int AddInts(int i1, int i2)
        {
            return i1 + i2;
        }
    }
}
