using CoreDemo.Models.CityModel;

namespace CoreDemo.Helper
{
	public static class Cities
	{
		public static List<City> GetAll()
		{
			return new List<City> {
				new City { Id = 1,Name="Adana"},
				new City { Id = 6,Name="Ankara"},
				new City { Id = 7,Name="Antalya"},
				new City { Id = 8,Name="Artvin"},
				new City { Id = 9,Name="Aydın"},
				new City { Id = 10,Name="Balıkesir"},
				new City { Id = 16,Name="Bursa"},
				new City { Id = 17,Name="Çanakkale"},
				new City { Id = 19,Name="Çorum"},
				new City { Id = 20,Name="Denizli"},
				new City { Id = 21,Name="Diyarbakır"},
				new City { Id = 22,Name="Edirne"},
				new City { Id = 23,Name="Elazığ"},
				new City { Id = 25,Name="Erzurum"},
				new City { Id = 26,Name="Eskişehir"},
				new City { Id = 27,Name="Gaziantep"},
				new City { Id = 30,Name="Hakkari"},
				new City { Id = 31,Name="Hatay"},
				new City { Id = 32,Name="Isparta"},
				new City { Id = 33,Name="Mersin"},
				new City { Id = 34,Name="İstanbul"},
				new City { Id = 42,Name="Konya"}

			};
		}
	}
}
