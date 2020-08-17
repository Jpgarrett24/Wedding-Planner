using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Future : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime FormDate = Convert.ToDateTime(value);
            if (FormDate > DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Wedding date must be in the future");
            }
        }
    }

    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }

        [Required(ErrorMessage = "Wedder One is required")]
        [Display(Name = "Wedder One: ")]
        public string WedderOne { get; set; }

        [Required(ErrorMessage = "Wedder Two is required")]
        [Display(Name = "Wedder Two: ")]
        public string WedderTwo { get; set; }

        [Required(ErrorMessage = "Wedding Date is required")]
        [Display(Name = "Wedding Date: ")]
        [DataType(DataType.Date)]
        [Future]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Wedding Address is required")]
        [Display(Name = "Wedding Address: ")]
        public string Address { get; set; }

        public int UserId { get; set; }
        public User Creator { get; set; }

        public List<GuestList> Guests { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}