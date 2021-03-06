﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CarTime.Models
{
    public class GetDataViewModel
    {

        [Required]
        [Display(Name = "City Pick-Up")]
        public string CityPickUp { get; set; }

        [Required]
        [Display(Name = "City Drop-off")]
        public string CityDropOff { get; set; }

        [Required]
        [Display(Name = "Date Pick-Up")]
        [DataType(DataType.DateTime)]
        public DateTime DatePickUp { get; set; }

        [Required]
        [Display(Name = "Time Pick-Up")]
        [DataType(DataType.DateTime)]
        public DateTime TimePickUp { get; set; }

        [Required]
        [Display(Name = "Date Drop-off")]
        [DataType(DataType.DateTime)]
        public DateTime DateDropOff { get; set; }

        [Required]
        [Display(Name = "Time Drop-off")]
        [DataType(DataType.DateTime)]
        public DateTime TimeDropOff { get; set; }
    }
}
