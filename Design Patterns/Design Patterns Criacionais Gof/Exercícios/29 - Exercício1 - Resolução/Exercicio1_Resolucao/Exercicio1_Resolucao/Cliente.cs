using System;

namespace Exercicio1_Resolucao
{
    public class Cliente
    {
        private readonly Logger _logger;
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            _logger = Logger.GetLogger();
            Nome = nome;
        }
        public void AtualizaEndereco(string endereco, string cidade)
        {
            // Salva os dados no banco de dados

            // Registra no log a alteração do endereço
            _logger.Registrar($"Endereço atualizado para o cliente {Nome} em {DateTime.Now}");
        }
    }
}
