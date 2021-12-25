using System;
using System.Collections.Generic;

namespace MvcAuto.Models
{
	public class Auto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Body { get; set; }
		public string Color { get; set; }
		public string ManufacturerName { get; set; }      
		public Manufacturer Manufacturer { get; set; }

	}
	public class Manufacturer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public List<Auto> Auto { get; set; }
	}
}
