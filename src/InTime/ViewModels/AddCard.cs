using System.ComponentModel.DataAnnotations;

namespace InTime.ViewModels
{
    public class AddCard
    {
        public int Id { get; set; }

        [Required]
        public string Contents { get; set; }
    }
}
