using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1.Models
{
    public class Review
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please input author name")]
        public string Name { get; set; }
        [Display(Name = "Text")]
        [Required(ErrorMessage = "Please leave your comment")]
        public string Text { get; set; }
        [HiddenInput(DisplayValue = false)]
        public DateTime Time { get; set; }
    }
}