using FlyWeight.Entities;

namespace FlyWeight
{
    public class LoadData
    {
        private IReadOnlyList<ShipRoute>? _shipRoutes;
        private IReadOnlyList<Country>? _countries;
        private IReadOnlyList<Employee>? _employees;
        private IReadOnlyList<Ship>? _ships;
        
        public IReadOnlyList<Country>? Countries
        {
            get
            {
                if (_countries == null)
                {
                    _countries = LoadCountries();
                }
                return _countries;
            }
        }

        public IReadOnlyList<Employee>? Employees
        {
            get
            {
                if (Countries != null && _employees == null)
                {
                    _employees = LoadEmployees();
                }
                return _employees;
            }
        }

        public IReadOnlyList<Ship>? Ships
        {
            get
            {
                if (Countries != null && _ships == null)
                {
                    _ships = LoadShip();
                }
                return _ships;
            }
        }

        public IReadOnlyList<ShipRoute>? ShipRoutes
        {
            get
            {
                if (Countries != null && Employees != null && Ships != null && _shipRoutes == null)
                {
                    _shipRoutes = LoadShipRoute();
                }
                return _shipRoutes;
            }
        }

        public bool isDataLoaded()
        {
            if(Countries == null || Employees == null || Ships == null || ShipRoutes == null)
            {
                Console.WriteLine("Data Load Failed");
                return false;
            }
            return true;
        }

        public IReadOnlyList<Country>? LoadCountries()
        {
            _countries = new List<Country>
            {
                new Country { Id = Guid.NewGuid(), Name = "India" },
                new Country { Id = Guid.NewGuid(), Name = "United States" },
                new Country { Id = Guid.NewGuid(), Name = "Germany" },
                new Country { Id = Guid.NewGuid(), Name = "Japan" },
                new Country { Id = Guid.NewGuid(), Name = "Brazil" }
            };
            return _countries;
        }

        public IReadOnlyList<Employee>? LoadEmployees()
        {
            try
            {
                _employees = new List<Employee>
            {
                new Employee { Id = Guid.NewGuid(), Name = "Alice", Email = "alice@example.com", Country = GetCountryByName("India") },
                new Employee { Id = Guid.NewGuid(), Name = "Bob", Email = "bob@example.com", Country = GetCountryByName("United States") },
                new Employee { Id = Guid.NewGuid(), Name = "Charlie", Email = "charlie@example.com", Country = GetCountryByName("Germany") },
                new Employee { Id = Guid.NewGuid(), Name = "Diana", Email = "diana@example.com", Country = GetCountryByName("Japan") },
                new Employee { Id = Guid.NewGuid(), Name = "Ethan", Email = "ethan@example.com", Country = GetCountryByName("Brazil") },
                new Employee { Id = Guid.NewGuid(), Name = "Fiona", Email = "fiona@example.com", Country = GetCountryByName("India") },
                new Employee { Id = Guid.NewGuid(), Name = "George", Email = "george@example.com", Country = GetCountryByName("Germany") },
                new Employee { Id = Guid.NewGuid(), Name = "Hannah", Email = "hannah@example.com", Country = GetCountryByName("Brazil") },
                new Employee { Id = Guid.NewGuid(), Name = "Ivan", Email = "ivan@example.com", Country = GetCountryByName("United States") },
                new Employee { Id = Guid.NewGuid(), Name = "Julia", Email = "julia@example.com", Country = GetCountryByName("Japan") }
            };
            }
            catch (Exception)
            {
                return null;
            }
            return _employees;
        }

        public IReadOnlyList<Ship>? LoadShip()
        {
            _ships = new List<Ship>
            {
                new Ship { Id = Guid.NewGuid(), Name = "SS Enterprise", YearOfMake = new DateTime(2015, 1, 1) },
                new Ship { Id = Guid.NewGuid(), Name = "Oceanic Voyager", YearOfMake = new DateTime(2012, 6, 15) },
                new Ship { Id = Guid.NewGuid(), Name = "Neptune Explorer", YearOfMake = new DateTime(2018, 3, 10) },
                new Ship { Id = Guid.NewGuid(), Name = "Arctic Breeze", YearOfMake = new DateTime(2020, 9, 25) },
                new Ship { Id = Guid.NewGuid(), Name = "Titan Monarch", YearOfMake = new DateTime(2016, 11, 5) }
            };
            return _ships;
        }

        public IReadOnlyList<ShipRoute>? LoadShipRoute()
        {
            try
            {
                _shipRoutes = new List<ShipRoute>
            {
                new ShipRoute
                {
                    Id       = Guid.NewGuid(),
                    Employee = GetEmployeeByName("Alice"),
                    FromCountry  = GetCountryByName("India"),
                    ToCountry  = GetCountryByName("Japan"),
                    Ship     = GetShipByName("SS Enterprise")
                },
                new ShipRoute
                {
                    Id       = Guid.NewGuid(),
                    Employee = GetEmployeeByName("Bob"),
                    FromCountry  = GetCountryByName("United States"),
                    ToCountry  = GetCountryByName("Germany"),
                    Ship     = GetShipByName("Neptune Explorer")
                },
                new ShipRoute
                {
                    Id       = Guid.NewGuid(),
                    Employee = GetEmployeeByName("Charlie"),
                    FromCountry  = GetCountryByName("Japan"),
                    ToCountry  = GetCountryByName("India"),
                    Ship     = GetShipByName("Oceanic Voyager")
                },
                new ShipRoute
                {
                    Id       = Guid.NewGuid(),
                    Employee = GetEmployeeByName("Diana"),
                    FromCountry  = GetCountryByName("Germany"),
                    ToCountry  = GetCountryByName("Brazil"),
                    Ship     = GetShipByName("Titan Monarch")
                },
                new ShipRoute
                {
                    Id       = Guid.NewGuid(),
                    Employee = GetEmployeeByName("Ethan"),
                    FromCountry  = GetCountryByName("Brazil"),
                    ToCountry  = GetCountryByName("India"),
                    Ship     = GetShipByName("Arctic Breeze")
                }
            };
            }
            catch (Exception)
            {
                return null;
            }
            
            return _shipRoutes;
        }

        public Country GetCountryByName(string countryName)
        {
            return Countries.First(c => c.Name == countryName);
        }

        public Employee GetEmployeeByName(string employeeName)
        {
            return Employees.First(c => c.Name == employeeName);
        }

        public Ship GetShipByName(string shipName)
        {
            return Ships.First(c => c.Name == shipName);
        }

    }
}
