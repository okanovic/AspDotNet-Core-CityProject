﻿using System;
using CityInfo.API.Entity;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
	public class CityInfoContext : DbContext
	{
		public DbSet<City> Cities { get; set; } = null!;

		public DbSet<PointOfInterest> PointOfInterest { get; set; } = null!;

		public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
		{

		}

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseSqlite("connectionstring");
		//	base.OnConfiguring(optionsBuilder);
		//}		
    }
}

