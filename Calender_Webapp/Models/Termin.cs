using System.ComponentModel.DataAnnotations;

namespace Calender_Webapp.Models
{
    public class Termin
    {
        public int Id { get; set; }

        [Required]
        public string Kunde { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Datum { get; set; }

        public string Notiz { get; set; }
    }
}
