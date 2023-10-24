using System.ComponentModel.DataAnnotations;

namespace Axede.Models
{
    public class Valor
    {
        public int Id { get; set; }
        [Required]
        public int Valor_Vip { get; set; }
        [Required]
        public int Valor_Estan { get; set; }
        [Required]
        public int Valor_Pre { get; set; }
        [Required]
        public int IdHotel { get; set; }
        [Required]
        public int Capa_Vip { get; set; }
        [Required]
        public int Capa_Estan { get; set; }
        [Required]
        public int Capa_Pre { get; set; }
    }
}
