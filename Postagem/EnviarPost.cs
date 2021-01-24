using System;
using System.Collections.Generic;
using System.Text;

namespace Postagem
{
    public class EnviarPost
    {
        private string subtitulo;

        public EnviarPost(string data, string local)
        {
            subtitulo = data;
        }

        public bool Enviar(string titulo, string descricao)
        {
            return true;
        }
    }
}
