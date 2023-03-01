using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------------------------------------

            //        Programa1

            //int metro, mm, cm;

            //Console.WriteLine("Quantos metros : ");
            //metro = int.Parse(Console.ReadLine());

            //mm = metro * 1000;
            //cm = metro * 100;

            //Console.WriteLine("São " + cm + " centimetros");
            //Console.WriteLine("São " + mm + " milimetros");


            //Console.ReadKey();



            //--------------------------------------------------------------------------------------------------------------------

            //Programa2 a

            //float f, c;

            //Console.WriteLine("Quantos graus fahrenheit são ? ");
            //f = int.Parse(Console.ReadLine());
            //c = (f - 32.0f) * (5.0f / 9.0f);

            //Console.WriteLine("São " + c + "° Celsius");
            //Console.ReadKey();

            //-------------------------------------------------------------------------------------------------------------------

            //Programa2 b

            //int f, c;

            //Console.WriteLine("Quantos graus fahrenheit são ? ");
            //f = int.Parse(Console.ReadLine());
            //c = (f - 32) * (5 / 9);

            //Console.WriteLine("São " + c + "° Celsius");
            //Console.ReadKey();

            //O valor sempre da zero por conta de ser somente o float quem trabalha com virgulas

            //-------------------------------------------------------------------------------------------------------------------

            //Programa3 

            //double Imc, peso, alt;

            //Console.WriteLine("Qual seu Peso ? ");
            //peso = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual sua altura ? ");
            //alt = double.Parse(Console.ReadLine());

            //Imc = peso / (alt * alt);

            //Console.WriteLine("Seu índice de massa corporal é " + Imc);
            //Console.ReadKey();

            //------------------------------------------------------------------------------------------------------------------

            //Programa4

            //float num1, num2, num3, peso1, peso2, peso3, result;

            //Console.WriteLine("Digite um número: ");
            //num1 = float.Parse(Console.ReadLine());  

            //Console.WriteLine("Digite um número: ");
            //num2 = float.Parse(Console.ReadLine());  

            //Console.WriteLine("Digite um número: ");
            //num3 = float.Parse(Console.ReadLine());  

            //Console.WriteLine("Digite um peso: ");
            //peso1 = float.Parse(Console.ReadLine());  

            //Console.WriteLine("Digite um peso: ");
            //peso2 = float.Parse(Console.ReadLine());  

            //Console.WriteLine("Digite um peso: ");
            //peso3 = float.Parse(Console.ReadLine());  

            //result = (num1 + num2 + num3 + peso1 + peso2 + peso3);


            //Console.WriteLine("O valor da média é: " + result / 6.0f);


            //Console.ReadKey();  

            //---------------------------------------------------------------------------------------------------------------

            //Programa5 (Velocidade escalar média)

            //float dist, temp, velo;

            //Console.WriteLine("Qual a distancia ? ");
            //dist = float.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o tempo ? ");
            //temp = float.Parse(Console.ReadLine());

            //velo = dist / temp;

            //Console.WriteLine("A sua velocidade é " + velo);
            //Console.ReadKey();

            //---------------------------------------------------------------------------------------------------------------

            //Programa6

            //float salario, result;

            //Console.WriteLine("Qual o seu salario ? ");
            //salario = float.Parse(Console.ReadLine());

            //result = salario * 25 / 100 + salario;

            // Console.WriteLine("O seu salario foi para " + result );

            //Console.ReadKey();

            //---------------------------------------------------------------------------------------------------------------

            //Programa7

            //float dolar, real, result;

            //Console.WriteLine("Informe o valor em reais ");
            //real = float.Parse(Console.ReadLine());

            //Console.WriteLine("Informe a cotação do dolar ");
            //dolar = float.Parse(Console.ReadLine()); 

            //result = real / dolar;

            //Console.WriteLine("O valor em dolares é " + result);

            //---------------------------------------------------------------------------------------------------------------

            //Programa8

            //int num1, result3,result1, result2;

            //Console.WriteLine("Qual o numero ? ");
            //num1 = int.Parse(Console.ReadLine());

            //result1 = (num1 * 3) + 1;
            //result2 = (num1 * 2) - 1;
            //result3 = result1 + result2;

            //Console.WriteLine("O valor final é " + result3);

            //Console.ReadKey();  

            //---------------------------------------------------------------------------------------------------------------

            //Programa9

            //Ex
            //P-> 0 1 2 3
            //V-> 9 8 7 6

            //P-> 0 1 2 3 4
            //V->M A R I A


            //var num = "";
            //do {
            //    Console.WriteLine("Insira um numero de 4 digitos ");
            //    num = Console.ReadLine();
            //} while (num.Length != 4); //condicao

            //for (var i = 0; i < num.Length; i++)

            //    Console.WriteLine(num[i]);

            //Console.ReadKey();

            //---------------------------------------------------------------------------------------------------------------

            //Programa10

            //float invest = 1000,dia1,dia2,dia3;

            //invest = invest - ((invest * 3.4f) / 100);
            //invest = invest + ((invest * 2.8f) / 100);
            //invest = invest + ((invest * 14f) / 100);
            //invest = invest - ((invest * 8.5f) / 100);


            //Console.WriteLine(invest);

            //Console.ReadKey();  

            //---------------------------------------------------------------------------------------------------------------

            //Programa11

            //float num, cubo, quad;

            //Console.WriteLine("Informe um numero ");
            //num = float.Parse(Console.ReadLine());

            //quad = num * num;
            //cubo = num * num * num;

            //Console.WriteLine("Seu numero ao quadrado é " + quad );  
            //Console.WriteLine("Seu numero ao quadrado é " + cubo);

            //Console.ReadKey();

            //---------------------------------------------------------------------------------------------------------------

            //Programa12

            //float h, pesoman, pesowoman;

            //Console.WriteLine("Informe sua altura ");
            //h = float.Parse(Console.ReadLine());

            //pesoman = (72.7f * h) - 58f;
            //pesowoman = (62.1f * h) - 44.7f;

            //Console.WriteLine("Para um homem de altura " + h + " o peso ideal é " + pesoman);
            //Console.WriteLine("Para uma muher de altura " + h + " o peso ideal é " + pesowoman);

            //Console.ReadKey();

            //--------------------------------------------------------------------------------------------------------------

            //Github

            //GitHub é uma plataforma para gerenciar seu código e criar um ambiente de colaboração entre devs, utilizando o Git como sistema de controle.
            //Git

            //Estes sistemas de controle possuem a função de registrar quaisquer alterações feitas em cima de um código, armazenando essas informações e permitindo que, caso seja necessário, um(a) programador(a) possa regredir a versões anteriores de uma aplicação de modo simples e rápido.
            //Exemplos de Git

            //Criar um novo banch e trocar
            //git checkout -b bug-456

            //Criar um stash
            //git stash

            //Iniciar pesquisa binaria
            //git bisect start

            //Comitar um arquivo
            //git commit meu_arquivo.txt

            //Setar e-mail
            //git config --global user.email leonardo@software-ltda.com.br

            //Adicionar arquivos
            //git add .	

            //Remover arquivo
            //git rm meu_arquivo.txt

            //Exibir historico
            //git log

            //Listar configuracoes 
            //git config --list

            //Criar um novo repositorio 
            //git init



        }
    }
}
