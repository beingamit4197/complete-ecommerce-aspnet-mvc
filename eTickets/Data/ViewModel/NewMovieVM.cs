﻿using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        
        [Display(Name = "Description Name")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in ₹")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie Start Date")]
        [Required(ErrorMessage = "Strat date is required")]
        public DateTime StartDate { get; set; }


        [Display(Name = "Movie   End Date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select Category")]
        [Required(ErrorMessage = "Category is required")]
        public MovieCategory MovieCategory { get; set; }

        [Display(Name = "Select Actor(s)")]
        [Required(ErrorMessage = "Movie Actor(s) is required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select Cinema")]
        [Required(ErrorMessage = "Cinema is required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select Producer")]
        [Required(ErrorMessage = "Producer is required")]
        public int ProducerId { get; set; }


    }
}
