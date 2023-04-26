using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelularPOO
{
    public class Cell
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

        public void Ligar()
        {
            ligado = true;
        }
        public void Desligar()
        {
            ligado = false;
        }
        public void LigacaoTelefonica(string numero)
        {
            if (ligado == true)
            {
                Console.WriteLine("O celular precisa estar ligado para fazer uma ligação.");
                return;
            }

            Console.WriteLine($"Ligando para {numero}...");
        }
        public void EnviarMensagem(string numero, string mensagem)
        {
            if (ligado == true)
            {
                Console.WriteLine("O celular precisa estar ligado para enviar uma mensagem.");
                return;
            }

            Console.WriteLine($"Enviando mensagem para {numero}: {mensagem}");
        }
    }
}