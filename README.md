## Curso C# da cod3r do básico ao avançado

#### Commentary Line, Block, Summary and Commentary of documentation
> 
```.cs
using System;

// Commentary in Line

/*
    Commnentary of Block
*/

namespace CursoCSharp.Fundamentos
{   
    /// <summary>
    /// Documentaçao da Class Comentarios 
    /// </summary>

   
    class Comentarios
    {  

        /// <summary>
        /// Documentacão do método de uma class
        /// </summary>
        /// <param name="nome">Nome do usuário</param>

        public static void Executar(string nome)
        {
            // Cuidado com comentários desnecessários
            Console.WriteLine("Class Comentários");
        }
    }
}
```