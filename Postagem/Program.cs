using System;

namespace Postagem
{
    class Program
    {
        static void Main(string[] args)
        {
            var postagem = new DadosPostagem()
            {
                Titulo = "Utilidades da injeção de depêndencia",
                Descricao = "Lorem ipsum"
               
            };

           
            new PostTeste1().CriarPost(postagem);

            var post = new EnviarPost("24/01/2021", "São Paulo");

            new PostTeste2(post).CriarPost(postagem);

            Console.WriteLine("Hello World");
        }
    }
}
