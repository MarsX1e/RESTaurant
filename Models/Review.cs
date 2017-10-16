using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
namespace RESTaurant.Models
{
    public class Review :BaseEntity
    {
        public int id{get;set;}

        [Required]
        [MinLength(2)]
        public string Reviewer_name {get;set;}

        [Required]
        [MinLength(3)]
        public string Restaurant_name {get;set;}

        [Required]
        [MinLength(1)]
        public string Comment{get;set;}

        [Required]
        public DateTime Dateofvisit {get;set;}

        [Required]
        [Range(1,5)]
        public int Stars{get;set;}

        public DateTime create_at{get;set;}

        public Review()
        {
            create_at=DateTime.Now;
        }
    }
}