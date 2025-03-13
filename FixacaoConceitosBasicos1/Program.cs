
/*
 * As classes a serem dsenvolvidas devem atender aos seguintes requisitos:
 * - Devem estar na pasta Model
 * - Para a classe SomaDoisNumeros, deve-se criar um método estático chamado Somar que recebe dois inteiros e retorna a soma deles
 * - Para a classe MetrosMilimetros, deve-se criar um método estático chamado Converter que recebe um double e retorna o valor em milímetros
 * - A  classe CalculaAumento deve ter um método estático chamado Calcular que recebe um double salario e um double aumento e retorna o valor do salário com o aumento aplicado
 * A classe CalculaDesconto deve ter um método estático chamado Calcular que recebe um double valor e um double desconto e retorna o valor com o desconto aplicado
 * - A classe CalculaAluguelCarro deve ter um método estático chamado Calcular que recebe um int dias, um int quilometragemInicial, um int quilometragemFinal e retorna o valor total do aluguel
 */

//PRIMEIRA TAREFA REALIZADA

using System;
using System.Reflection;
using System.Threading.Channels;
using FixacaoConceitosBasicos1.Model;

int opcaoSelecionada;

do
{
    try
    {
        Console.WriteLine("Escolha uma opcao:");
        Console.WriteLine("[0] - Sair");
        Console.WriteLine("[1] - Somar dois numeros");
        Console.WriteLine("[2] - Converter metros para milimetros");
        opcaoSelecionada = int.Parse(Console.ReadLine());

        if (opcaoSelecionada == 0)
        {
            break;
        }
        if (opcaoSelecionada == 1)
        {
            Console.Write("digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"a soma dos valores é {SomaDoisNumeros.Somar(num1, num2)}");
        }
        if (opcaoSelecionada == 2)
        {
            Console.Write("digite o valor para converter: ");
            double num3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"o valor convertido é {MetrosMilmetros.Converter(num3)}");
        }
    }
    catch (Exception e)
    {
        break;
    }
   

}
while (opcaoSelecionada != 0);


