﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FopTecProject.ViewModel
{
    [Table("AspNetUsers")]
    public class Register
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        //[Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="Password and conformation didnt match!")]
        public string? ConfirmPassword { get; set; }
    }
}
