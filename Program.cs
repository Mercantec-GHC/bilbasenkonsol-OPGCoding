using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using DomainModels;

namespace BilbasenKonsol
{
	internal class Program
	{

		public static List<Car> cars = new List<Car>
		{
			new Car("Ford", "Mustang", 1963, "Red", 430, 6, "Gasoline"),
			new Car("Toyota", "Camry", 2020, "Blue", 200, 6, "Gasoline"),
			new Car("Chevrolet", "Corvette", 2022, "Silver", 650, 6, "Gasoline"),
			new Car("Honda", "Civic", 2008, "White", 140, 4, "Gasoline"),
			new Car("BMW", "X5", 2015, "Black", 300, 6, "Diesel"),
			new Car("Audi", "A3", 2019, "Gray", 190, 4, "Diesel"),
			new Car("Mercedes-Benz", "E-Class", 2018, "Silver", 350, 6, "Diesel"),
			new Car("Volkswagen", "Golf", 2017, "Blue", 170, 4, "Gasoline"),
			new Car("Tesla", "Model S", 2021, "White", 670, 0, "Electric"),
			new Car("Hyundai", "Elantra", 2016, "Red", 150, 4, "Gasoline"),
			new Car("Ford", "F-150", 2019, "Black", 450, 8, "Gasoline"),
			new Car("Toyota", "Corolla", 2014, "Silver", 132, 4, "Gasoline"),
			new Car("Chevrolet", "Silverado", 2018, "Blue", 355, 8, "Gasoline"),
			new Car("Honda", "Accord", 2017, "Gray", 192, 4, "Gasoline"),
			new Car("BMW", "3 Series", 2020, "White", 255, 4, "Gasoline"),
			new Car("Audi", "A4", 2016, "Black", 252, 4, "Diesel"),
			new Car("Mercedes-Benz", "C-Class", 2015, "Silver", 241, 4, "Diesel"),
			new Car("Volkswagen", "Jetta", 2018, "Red", 147, 4, "Gasoline"),
			new Car("Tesla", "Model 3", 2019, "Blue", 283, 0, "Electric"),
			new Car("Hyundai", "Sonata", 2013, "Gray", 198, 4, "Gasoline"),
			new Car("Ford", "Focus", 2017, "White", 160, 4, "Gasoline"),
			new Car("Toyota", "Rav4", 2020, "Red", 203, 4, "Gasoline"),
			new Car("Chevrolet", "Equinox", 2019, "Silver", 170, 4, "Gasoline"),
			new Car("Honda", "Pilot", 2016, "Blue", 280, 6, "Gasoline"),
			new Car("BMW", "5 Series", 2014, "Black", 315, 6, "Diesel"),
			new Car("Audi", "Q5", 2018, "Gray", 248, 4, "Diesel"),
			new Car("Mercedes-Benz", "GLC", 2017, "White", 241, 4, "Diesel"),
			new Car("Volkswagen", "Tiguan", 2019, "Red", 184, 4, "Gasoline"),
			new Car("Tesla", "Model X", 2018, "Blue", 503, 0, "Electric"),
			new Car("Hyundai", "Tucson", 2015, "Silver", 164, 4, "Gasoline"),
			new Car("Ford", "Escape", 2021, "White", 181, 4, "Gasoline"),
			new Car("Toyota", "Highlander", 2019, "Red", 295, 6, "Gasoline"),
			new Car("Chevrolet", "Traverse", 2017, "Blue", 310, 6, "Gasoline"),
			new Car("Honda", "Odyssey", 2020, "Gray", 280, 6, "Gasoline"),
			new Car("BMW", "7 Series", 2016, "Black", 444, 8, "Diesel"),
			new Car("Audi", "A6", 2018, "Silver", 335, 6, "Diesel"),
			new Car("Mercedes-Benz", "GLE", 2019, "White", 362, 6, "Diesel"),
			new Car("Volkswagen", "Atlas", 2021, "Red", 276, 6, "Gasoline"),
			new Car("Tesla", "Model Y", 2022, "Blue", 394, 0, "Electric"),
			new Car("Hyundai", "Santa Fe", 2018, "Silver", 235, 4, "Gasoline"),
			new Car("Ford", "Explorer", 2017, "White", 290, 6, "Gasoline"),
			new Car("Toyota", "Tacoma", 2020, "Red", 278, 6, "Gasoline"),
			new Car("Chevrolet", "Colorado", 2019, "Blue", 200, 4, "Gasoline"),
			new Car("Honda", "CR-V", 2015, "Gray", 185, 4, "Gasoline"),
			new Car("BMW", "X3", 2018, "Black", 248, 4, "Diesel"),
			new Car("Audi", "Q7", 2017, "Silver", 329, 6, "Diesel"),
			new Car("Mercedes-Benz", "GLA", 2016, "White", 208, 4, "Diesel"),
			new Car("Volkswagen", "Passat", 2020, "Red", 174, 4, "Gasoline"),
			new Car("Tesla", "Cybertruck", 2023, "Gray", 800, 0, "Electric"),
			new Car("Hyundai", "Kona", 2019, "Silver", 147, 4, "Gasoline"),
			new Car("Ford", "Ranger", 2016, "White", 270, 4, "Diesel"),
			new Car("Toyota", "Sienna", 2021, "Red", 296, 6, "Hybrid"),
			new Car("Chevrolet", "Blazer", 2020, "Blue", 308, 6, "Gasoline"),
			new Car("Honda", "Fit", 2018, "Gray", 130, 4, "Gasoline"),
			new Car("BMW", "4 Series", 2017, "Black", 248, 4, "Diesel"),
			new Car("Audi", "A5", 2015, "Silver", 220, 4, "Diesel"),
			new Car("Mercedes-Benz", "GLB", 2019, "White", 221, 4, "Diesel"),
			new Car("Volkswagen", "Arteon", 2022, "Red", 268, 4, "Gasoline"),
			new Car("Tesla", "Roadster", 2024, "Blue", 1000, 0, "Electric"),
			new Car("Hyundai", "Venue", 2020, "Silver", 121, 4, "Gasoline"),
			new Car("Ford", "Expedition", 2019, "White", 375, 6, "Gasoline"),
			new Car("Toyota", "Tundra", 2017, "Red", 381, 8, "Gasoline"),
			new Car("Chevrolet", "Tahoe", 2018, "Blue", 355, 8, "Gasoline"),
			new Car("Honda", "Ridgeline", 2016, "Gray", 280, 6, "Gasoline"),
			new Car("BMW", "X7", 2021, "Black", 523, 8, "Diesel"),
			new Car("Audi", "Q8", 2020, "Silver", 335, 6, "Hybrid"),
			new Car("Mercedes-Benz", "GLS", 2023, "White", 429, 6, "Hybrid"),
			new Car("Volkswagen", "ID.4", 2022, "Red", 201, 0, "Electric"),
			new Car("Tesla", "Model S Plaid", 2022, "Blue", 1100, 0, "Electric"),
			new Car("Hyundai", "Palisade", 2021, "Silver", 291, 6, "Gasoline"),
			new Car("Ford", "Bronco", 2021, "White", 310, 6, "Gasoline"),
			new Car("Toyota", "4Runner", 2020, "Red", 270, 6, "Gasoline"),
			new Car("Chevrolet", "Suburban", 2019, "Blue", 355, 8, "Gasoline"),
			new Car("Honda", "HR-V", 2017, "Gray", 141, 4, "Gasoline"),
			new Car("BMW", "X6", 2016, "Black", 445, 6, "Diesel"),
			new Car("Audi", "SQ5", 2018, "Silver", 349, 6, "Diesel"),
			new Car("Mercedes-Benz", "GLE Coupe", 2015, "White", 362, 6, "Diesel"),
			new Car("Volkswagen", "Touareg", 2018, "Red", 335, 6, "Diesel"),
			new Car("Tesla", "Model Y Performance", 2023, "Blue", 450, 0, "Electric"),
			new Car("Hyundai", "Ioniq", 2020, "Silver", 134, 4, "Hybrid"),
			new Car("Ford", "Mustang Mach-E", 2021, "White", 480, 0, "Electric"),
			new Car("Toyota", "Prius", 2019, "Red", 121, 4, "Hybrid"),
			new Car("Chevrolet", "Spark", 2017, "Blue", 98, 4, "Gasoline"),
			new Car("Honda", "Insight", 2018, "Gray", 151, 4, "Hybrid"),
			new Car("BMW", "i3", 2016, "Black", 170, 0, "Electric"),
			new Car("Audi", "e-tron", 2020, "Silver", 355, 0, "Electric"),
			new Car("Mercedes-Benz", "EQC", 2021, "White", 402, 0, "Electric"),
			new Car("Volkswagen", "e-Golf", 2019, "Red", 134, 0, "Electric"),
			new Car("Tesla", "Model 3 Long Range", 2022, "Blue", 353, 0, "Electric"),
			new Car("Hyundai", "Nexo", 2021, "Silver", 161, 0, "Hydrogen"),
			new Car("Ford", "Transit", 2020, "White", 275, 6, "Gasoline"),
			new Car("Toyota", "Sienna Hybrid", 2021, "Red", 245, 4, "Hybrid"),
			new Car("Chevrolet", "Express", 2018, "Blue", 276, 8, "Gasoline"),
			new Car("Honda", "Odyssey Hybrid", 2020, "Gray", 280, 6, "Hybrid"),
			new Car("BMW", "X7 M50i", 2021, "Black", 523, 8, "Gasoline"),
			new Car("Audi", "Q7 TFSI e", 2020, "Silver", 335, 6, "Hybrid"),
			new Car("Mercedes-Benz", "GLS 600", 2023, "White", 429, 6, "Hybrid"),
			new Car("Volkswagen", "ID. Buzz", 2024, "Red", 201, 0, "Electric"),
			new Car("Tesla", "Model S Plaid+", 2022, "Blue", 1100, 0, "Electric"),
			new Car("Hyundai", "IONIQ 5", 2022, "Silver", 320, 0, "Electric")
		};


		public static List<Car> filteredCars = new List<Car>();



		public static void Main(string[] args)
		{
			 


			//Det er vigtigt at I finder en god datatype til at opbevare jeres biler / Objekter!
			Search();

            Console.WriteLine($"\nWould you filter? 1) Yes, 2) no");
			string varFilterConformation = Console.ReadLine().ToLower();


			


			if (varFilterConformation == "yes" || varFilterConformation == "1")
			{
				Filter();
			}
			else if (varFilterConformation == "no" || varFilterConformation =="2")
			{
				
			}

            
			
		}

		public static void Search()
		{
			Console.WriteLine("Enter Brand: ");
			string varSearch = Console.ReadLine();
			DisplayVechicle(varSearch);						
		}

		public static void Filter()
		{
			Console.WriteLine($"\n-------------------------------------------------------------");
			Console.WriteLine($"\nWhat to filter? 1) Year, 2) Color, 3) HorsePower, 4) FuelType ");
			string filterOptions = Console.ReadLine().ToLower();



			if (filterOptions == "1" || filterOptions == "year")
			{
				Console.WriteLine("Enter start year: ");
				if (int.TryParse(Console.ReadLine(), out int minYear))
				{
					Console.WriteLine("Enter end year: ");
					if (int.TryParse(Console.ReadLine(), out int maxYear))
					{
						DisplayVechicleYear(minYear, maxYear);

					}
				}


			}
			else if (filterOptions == "2" || filterOptions == "color")
			{
				Console.WriteLine("Enter color: ");
				string filterColor = Console.ReadLine();


				DisplayVechicleColor(filterColor);



			}
			else if (filterOptions == "3" || filterOptions == "horsepower")
			{
				Console.WriteLine("Enter min. HP: ");
				if (int.TryParse(Console.ReadLine(), out int minHP))
				{
					Console.WriteLine("Enter max. HP: ");
					if (int.TryParse(Console.ReadLine(), out int maxHP))
					{
						DisplayVechicleHP(minHP, maxHP);

					}
				}
			}
			else if (filterOptions == "4" || filterOptions == "fueltype")
			{
				Console.WriteLine("Enter fuel type: ");
				string filterFuelType = Console.ReadLine();


				DisplayVechicleFuelType(filterFuelType);



			}



		}

		public static void DisplayVechicle(string searchTerm)
		{
			int count = 0;
			string countBrand = "";

			filteredCars.Clear();
			if(searchTerm.ToLower() == "all")
			{
				foreach (Car car in cars) 
				{
					filteredCars.Add(car);
					Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, HorsePower: {car.HorsePower}, Cylinders: {car.NumberOfCylinders}, Fuel Type: {car.FuelType}");
					count++;
					countBrand = "all";
				}
				Console.WriteLine($"Total search {countBrand}: {count}");

			}
			else
			{
				foreach (Car car in cars)
				{

					if (car.Brand.Equals(searchTerm, StringComparison.OrdinalIgnoreCase) || car.Model.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
					{
						filteredCars.Add(car);
						Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, HorsePower: {car.HorsePower}, Cylinders: {car.NumberOfCylinders}, Fuel Type: {car.FuelType}");
						count++;
						countBrand += searchTerm;

					}
				}
				Console.WriteLine($"Total search {countBrand}: {count}");

			}

		}

		public static void DisplayVechicleColor(string searchTerm)
		{
			int countColor = 0;

			Console.Clear();
			Console.WriteLine();

			foreach (Car car in filteredCars)
			{
				if (car.Color.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
				{
					Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, HorsePower: {car.HorsePower}, Cylinders: {car.NumberOfCylinders}, Fuel Type: {car.FuelType}");
					countColor++;
				}
			}
			Console.WriteLine($"Total search result: {countColor}");

		}

		public static void DisplayVechicleHP(int minHP, int maxHP)
		{
			int countHP = 0;

			Console.Clear();
			Console.WriteLine();

			foreach (Car car in filteredCars)
			{
				if(car.HorsePower >= minHP && car.HorsePower <= maxHP)
				{
					Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, HorsePower: {car.HorsePower}, Cylinders: {car.NumberOfCylinders}, Fuel Type: {car.FuelType}");
					countHP++;

				}
			}
			Console.WriteLine($"Total search result: {countHP}");

		}

		public static void DisplayVechicleYear(int minYear, int maxYear)
		{
			int countYear = 0;
			Console.Clear();
			Console.WriteLine();
			foreach (Car car in filteredCars)
			{
				if (car.Year >= minYear && car.Year <= maxYear)
				{
					Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, HorsePower: {car.HorsePower}, Cylinders: {car.NumberOfCylinders}, Fuel Type: {car.FuelType}");
					countYear++;
				}
			}
			Console.WriteLine($"Total search result: {countYear}");

		}


		public static void DisplayVechicleFuelType(string searchTerm)
		{
			int countFuelType = 0;

			Console.Clear();
			Console.WriteLine();

			foreach (Car car in filteredCars)
			{
				if (car.FuelType.Equals(searchTerm, StringComparison.OrdinalIgnoreCase))
				{
					Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Year: {car.Year}, Color: {car.Color}, HorsePower: {car.HorsePower}, Cylinders: {car.NumberOfCylinders}, Fuel Type: {car.FuelType}");
					countFuelType++;
				}
			}
			Console.WriteLine($"Total search result: {countFuelType}");

		}


	}
}

