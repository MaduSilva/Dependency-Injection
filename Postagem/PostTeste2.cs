using System;
using System.Collections.Generic;
using System.Text;

namespace Postagem
{
    //Utilizando a Injeção
    class PostTeste2
    {
        private EnviarPost _post;

        //construtor recebe o objeto de EnviarPost
        public PostTeste2(EnviarPost post)
        {
            _post = post;
        }

        public void CriarPost(DadosPostagem dadosPostagem)
        {
            //Agora não necessita mais do new, ou seja, não existe mais depêndencia entre EnviarPost e Post
            _post.Enviar(dadosPostagem.Titulo, $"Fulano disse: {dadosPostagem.Descricao}");
        }

    }
}
