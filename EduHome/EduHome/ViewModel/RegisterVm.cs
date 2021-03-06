using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.ViewModel
{
    public class RegisterVm
    {
        [Required]
        public string FullName { get; set; }
        [Required,MaxLength(30)]
        public string UserName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required,Range(10,100)]
        public int Age { get; set; }
        [Required]
        public string Position { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
