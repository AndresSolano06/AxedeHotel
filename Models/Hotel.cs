using System.ComponentModel.DataAnnotations;

namespace Axede.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required]
        public int Estandar { get; set; }
        [Required]
        public int Premium { get; set; }
        [Required]
        public int Vip { get; set; }
        [Required]
        public int CapacidadHotel { get; set; }
        public List<Reservas> Reservas { get; set; }
        public List<Valor> Valor { get; set; }
    }
}
