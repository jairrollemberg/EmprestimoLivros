using System.ComponentModel.DataAnnotations;

namespace EmprestimoLivros.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome de quem vai receber o livro!")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do quem vai fornecer o livro!")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do livro!")]
        public string LivroEmprestado { get; set; }
        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
