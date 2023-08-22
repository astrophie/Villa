using System;
using Villa_API.Models.Dto;

namespace Villa_API.Data
{
	public static class VillaStore
	{
		public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO {Id=1, Name="Pool View", Occupancy=1, Sqft=500},
                new VillaDTO {Id=2, Name="Beach View", Occupancy=3, Sqft=800}
            };
	}
}

