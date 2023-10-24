using System.ComponentModel.DataAnnotations;

namespace Axede.Models
{
    public class Reservas
    {
        public int Id { get; set; }
        [Required]
        public DateTime FechaInicioReserva { get; set; }
        [Required]
        public DateTime FechaFinReserva { get; set; }
        [Required]
        public int IdHotel { get; set; }
    }
}
