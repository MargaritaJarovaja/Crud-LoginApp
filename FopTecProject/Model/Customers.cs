using System.ComponentModel.DataAnnotations;
namespace FopTecProject.Model

{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Name required")]
        public string? Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? ContactPerson { get; set; }
        public int Phone { get; set; }
        public int OrgNumber { get; set; }
        public string? Discription { get; set; }
        public int Properties { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastChangeDate { get; set; }
        public string? LastChangeBy { get; set; }
    }
}
