﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityInfo.API.Entity
{
	public class City
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id{ get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public ICollection<PointOfInterest> PointOfInterest { get; set; } = new List<PointOfInterest>();

        public City(string name)
        {
            Name = name;
        }
    }
}

