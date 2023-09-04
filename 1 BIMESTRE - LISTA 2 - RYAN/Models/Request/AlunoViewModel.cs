using _1_BIMESTRE___LISTA_2___RYAN.Models.Validations;

namespace _1_BIMESTRE___LISTA_2___RYAN.Models.Request
{
     public class AlunoViewModel
    {

        public string Nome { get; set; }

        [RaValidation]
        public string RA { get; set; }

        public string Email { get; set; }

        public string Cpf { get; set; }

        public bool Ativo { get; set; }

    }
}
