using System;
using System.Collections.Generic;
using System.Text;

namespace Postagem
{
    //Essa é a postagem feita sem a injeção de dependência
    public class PostTeste1
    {
        //Cria o post passando a classe DadosPostagem
        public void CriarPost(DadosPostagem dadosPostagem)
        {
            //cria um post, e pelo fato de existir dependencia, é necessário passar as informações que pertencem a classe EnviarPost, ou seja, qualquer alteração nela vai resultar em erros
            var post = new EnviarPost("24/01/2021", "São Paulo");
            //envia o post com os dados da postagem declarados
            post.Enviar(dadosPostagem.Titulo, $"Fulano disse: {dadosPostagem.Descricao}");
        }
    }
}
