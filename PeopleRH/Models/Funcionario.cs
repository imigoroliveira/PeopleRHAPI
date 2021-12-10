using System;

namespace PeopleRH.Models
{
    public class Funcionario
    {
        public Funcionario() { CriadoEm = DateTime.Now; Ativo = true; }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime CriadoEm { get; set; }
        public bool Ativo { get; set; }

        public override string ToString() =>
            $"Criado em: {CriadoEm}";

    }
}