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


