using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage ="Please enter a First Name")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage ="Please enter a Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter a Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter an Organization")]
        public string Organization { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Please enter a category.")]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }

        public string Name => this.FirstName + " " + this.LastName;

        public string Slug =>
           Name?.Replace(' ', '-').ToLower();
    }
}
