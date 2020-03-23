using Newtonsoft.Json;
using System;
using System.Dynamic;

namespace certificacao_csharp_roteiro
{
    class UsandoExpandObject : IAulaItem
    {
        public void Executar()
        {
            string json = "{\"De\": \"Paulo Silveira\"," +
                          "\"Para\": \"Guilherme Silveira\"}";

            dynamic mensagem = JsonConvert.DeserializeObject<ExpandoObject>(json);

            mensagem.Texto = "Olá, " + mensagem.Para;
            EnviarMensagem(mensagem);

            mensagem.Inverter = new Action(() =>
            {
                var aux = mensagem.De;
                mensagem.Texto = "Olá, " + aux;
                mensagem.De = mensagem.Para;
                mensagem.Para = aux;
            });

            mensagem.Inverter();
            EnviarMensagem(mensagem);
        }

        private void EnviarMensagem(dynamic msg)
        {
            Console.WriteLine($"De: {msg.De}");
            Console.WriteLine($"Para: {msg.Para}");
            Console.WriteLine($"Texto: {msg.Texto}");
            Console.WriteLine();
        }
    }
}
