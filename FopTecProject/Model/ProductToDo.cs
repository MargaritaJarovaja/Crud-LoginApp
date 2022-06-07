using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;



namespace FopTecProject.Model
{
    public class ProductToDo
    {

        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name required")]
        public string? Name { get; set; }
        public int ResponsibleID { get; set; }
        public DateTime StatusFinishDate { get; set; }
        public DateTime ProductFinishDate { get; set; }
        public int PercentCompleted { get; set; }
        public string? Note { get; set; }
        public int Properties { get; set; }
        public string? Done { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastChangeDate { get; set; }
        public string? LastChangeBy { get; set; }
        public int? ProductID_ref { get; set; }
    }
}
