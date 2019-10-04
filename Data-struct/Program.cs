using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias = DateTime.Now.Day;
            int meses = DateTime.Now.Month;
            int anos = DateTime.Now.Month;

            if (dias % 2 == 0)
            {
                Console.WriteLine($"Hoje é dia: {dias} \nHoje é um dia par.");
            } else
            {
                Console.WriteLine($"Hoje é dia: {dias} \nHoje é um dia impar.");
            }

            ShowDate data;

            data = new ShowDate() { dia = 10, mes = meses, ano = anos};

            if (dias < 10)
            {
                Console.WriteLine($"Data: 0{data.dia}/{data.mes}/{data.ano}");
            }
            else
            {
                Console.WriteLine($"Data: {data.dia}/{data.mes}/{data.ano}");
            }
            
        }
        struct ShowDate
        {
            public int dia;
            public int mes;
            public int ano;
        }
    }
}
