## Curso C# da cod3r do básico ao avançado

#### Commentary Line, Block, Summary and Commentary of documentation
```.cs
using System;

namespace CursoCSharp.Fundamentos
{   
   
    class Comentarios
    {  
        /// <summary>
        /// Documentacão do método de uma class -- Comentárido de Documentação
        /// </summary>
        /// <param name="nome">Nome do usuário</param>
        public static void Executar()
        {
            // Cuidado com comentários desnecessários -- Comentário de Linha

            Console.WriteLine("Class Comentários");

            /*
             * Bloco de Comentários
             */
        }
    }
}

```
__Obs: para gerar um summary digite três a tecla /__

#### Tags pré-definidas para comentário de métodos
> param and property name
```.cs
/// <summary>
/// Documentacão do método de uma class
/// </summary>
/// <param name="Nome do Parâmetro">Descrição</param>

    public static void Executar(string nome)
     {
        Console.WriteLine("Class Comentários");
     }
```

#### Difference in between System.Console.Write, System.Console.WriteLine and Console.WriteLine
Falaremos um pouco sobre algumas diferença entre o Objeto Console e de seus métodos <br>
__Write__, __WriteLine__ and about System com o using e o System.Object.

##### With System.Console.Write
Utilizamos o System.Console.Write quando queremos escrever no console do sistema, mas sem quebra a linha <br>
na qual o próximo comando será executado.

##### With System.Console.WriteLine
Utilizamos o System.Console.WriteLine quando queremos escrever no console do sistema e quebra a linha <br>
para que o próxinmo comando seja executado na próxima linha do console.

##### With Console.WriteLine and without System
Utilizamos o Console.WriteLine quando usamos o namespace System no module que estamos criando o código,
assim já é carregado para o module dos os Objects ou Class de dentro do System.

#### Constant and Variable
> Define constant
```.cs
    const double PI = 3.14;
```
> Define Variable
```.cs
    double raio = 3.5;
```

#### Concatenation 
```.cs
    Console.WriteLine("Área é " + area);
```

#### Types in CSharp

##### Type Boolean
```.cs
    // Tipo bool = True | False;
    
    bool visivel = true;
```

##### Type Long, ULong, Int, UInt, Short, Byte, SByte, Decimal, Double, Float, 
```.cs
            // Area da Circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415

            double area = PI * raio * raio;

            Console.WriteLine("Área é " + area);

            // bool True or False
            bool estaChovendo = true;

            Console.WriteLine("Está Chovendo " + estaChovendo);

            // byte 0 a 256
            byte idade = 45;
            Console.WriteLine(idade);

            // sbyte -128 a 127
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols + " a " + sbyte.MaxValue);

            // short -32768 a 32767
            Console.WriteLine("Type Short: "+short.MinValue + " a " + short.MaxValue);

            // int -2b a 2b
            Console.WriteLine("Type Int: " + int.MinValue + " a " + int.MaxValue);

            // uint 0 a 4b
            Console.WriteLine("Type Int: " + uint.MinValue + " a " + uint.MaxValue);

            // long -9....... a 9.........
            Console.WriteLine("Type Int: " + ulong.MinValue + " a " + ulong.MaxValue);

            // long 0 a 18.....
            Console.WriteLine("Type Int: " + ulong.MinValue + " a " + ulong.MaxValue);

            // Ponto flutuante
            // Float 
            float precoComputador = 1299.99f;
            Console.WriteLine("Valor 1299.99 tipo float como float: " + precoComputador);
            Console.WriteLine("Float Min e Max: " + float.MinValue +" a "+ float.MaxValue);

            // Double
            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de Mercado da Apple :" + valorDeMercadoDaApple);
            Console.WriteLine("Double Min e Max:" + double.MinValue + " a " + double.MinValue);

            
            //Char 
            char letra = 'a';
            Console.WriteLine(letra);

            //String
            string text = "André Da Silva";
            Console.WriteLine(text);
```