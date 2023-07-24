using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int ID { get; set; }
        [DisplayName("Título")]
        [Required(ErrorMessage = "Este campo é obrigatório"), MaxLength(100)]
        public string Titulo { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [DisplayName("Data de Lançamento")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime DataLancamento { get; set; }
        [DisplayName("Gênero")]
        [Required(ErrorMessage = "Este campo é obrigatório"), StringLength(10), RegularExpression(@"^[A-Z]+[a-zA-z\s]*$", ErrorMessage = "Dados Invalidos")]
        public string Genero { get; set; } = string.Empty;
        [DisplayName("Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
   //     [DisplayFormat(DataFormatString = "{0:0,0.00}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public decimal Preco { get; set; }
        [Range(0,5, ErrorMessage ="Somente Numeros de 0 a 5")]
        public int? Pontos { get; set; }
    }
}
