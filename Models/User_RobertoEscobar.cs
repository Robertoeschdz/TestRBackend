using Microsoft.EntityFrameworkCore;

namespace TestRBackend.Models
{
    public class User_RobertoEscobar
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Email { get; set; }
        public int? Numero { get; set; }
        public DateTime? FechadeNacimiento { get; set; }
    }
}

