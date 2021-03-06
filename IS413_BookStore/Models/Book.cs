﻿using System;
using System.ComponentModel.DataAnnotations;

namespace IS413_BookStore.Models
{
    public class Book
    {
        public Book()
        {
        }

        //Declare Book attributes
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFirstName { get; set; }

        [Required]
        public string AuthorLastName { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        [RegularExpression("\\d{3}-\\d{10}", ErrorMessage = "Input ISBN like 000-0000000000")]
        public string ISBN { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public int NumPages { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
