﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key] // primary key
        public int Id { get; set; }
        [Required] // can not be null
        public String Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage ="Display Order must be between 1 to 100!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
