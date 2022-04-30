using System;

namespace CalculoSalarioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nome do Funcionario
            Console.WriteLine("Digite o nome do funcionário: ");
            String funcionario = Console.ReadLine();

            //Salario Inicial
            Console.WriteLine("Digite o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine().ToString());

            //Calculo Reajuste de porcentagem
            double reajuste1 = (salario * 20) / 100;
            double reajuste2 = (salario * 13) / 100;
            double reajuste3 = (salario * 10) / 100;
            double reajuste4 = (salario * 5) / 100;


            //Condições do salário em porcentagem,salário em dolar e EUR.
            if(salario < 1200)
            {
                Console.WriteLine("O salário do funcionário com os reajustes ficou R$"+(salario + reajuste1));
                Console.WriteLine("O salário do funcionário reajustado na cotação do dolar ficou $"+(salario + reajuste1)/4,70f);
                Console.WriteLine("O salário do funcionário reajustado na cotação do Euro ficou EUR" + (salario + reajuste1) / 5, 20f);
            }
            if(salario>=1200 && salario <= 2000)
            {
                Console.WriteLine("O salário do funcionário com os reajustes ficou :" +(salario+reajuste2));
                Console.WriteLine("O salário do funcionário reajustado na cotação do dolar ficou $" + (salario + reajuste2) / 4, 70f);
                Console.WriteLine("O salário do funcionário reajustado na cotação do Euro ficou EUR" + (salario + reajuste2) / 5, 20f);
            }
            if(salario>2000 && salario <= 2500)
            {
                Console.WriteLine("O salário do funcionário com os reajustes ficou :" + (salario + reajuste3));
                Console.WriteLine("O salário do funcionário reajustado na cotação do dolar ficou $" + (salario + reajuste3) / 4, 70f);
                Console.WriteLine("O salário do funcionário reajustado na cotação do Euro ficou EUR" + (salario + reajuste3) / 5, 20f);
            }
            if (salario > 2500)
            {
                Console.WriteLine("O salário do funcionário com os reajustes ficou :" + (salario + reajuste4));
                Console.WriteLine("O salário do funcionário reajustado na cotação do dolar ficou $" + (salario + reajuste4) / 4, 70f);
                Console.WriteLine("O salário do funcionário reajustado na cotação do Euro ficou EUR" + (salario + reajuste4) / 5, 20f);
            }







        }
    }
}
