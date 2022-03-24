using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodoAtras
{
    public class ImputData
    {
       public void inserirData()
        {
            Console.WriteLine("Digite o ano!!");
            string ano = Console.ReadLine();
            int intano = Convert.ToInt32(ano);
            Console.WriteLine("Digite o dia!!");
            string dia = Console.ReadLine();
            int intdia = Convert.ToInt32(dia);
            Console.WriteLine("Digite o mes!!");
            string mes = Console.ReadLine();
            int intmes = Convert.ToInt32(mes);
           

            DateTime DATA = new DateTime(intano, intmes, intdia);
            DateTime dataAtual = new DateTime(2022, 03, 24);
            TimeSpan diferencaDias = dataAtual - DATA;
            

            int quantidadeAnos = diferencaDias.Days / 365;
            int a = quantidadeAnos * 365;
            int sobra = diferencaDias.Days - a;
            int quantidadeMeses = sobra / 30;
            int b = quantidadeMeses * 30;
            int sobra1 = diferencaDias.Days - a - b;
            int quantidadeSemanas = sobra1 / 7;
            int c = quantidadeSemanas * 7;
            int quantidadeDias = diferencaDias.Days - a - b - c;

            Console.WriteLine("O dia: {0}/{1}/{2} foi há: ", intdia, intmes, intano);
            Console.WriteLine("{0} anos atras" ,quantidadeAnos);
            Console.WriteLine("{0} meses atras ", quantidadeMeses);
            Console.WriteLine("{0} semanas atras ", quantidadeSemanas);
            Console.WriteLine("{0} dias atras", quantidadeDias);
            ************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************       }
        


    }
}
