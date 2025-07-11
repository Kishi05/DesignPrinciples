using Composite;

//Employee 1
Employee employee1 = new Employee(1, "Sam", "Mr", 30, "Self");
Dependent dependent1 = new Dependent(3, "June", "Mrs", 30, "Spouse");
employee1.Add(dependent1);

//Employee 2
Employee employee2 = new Employee(4, "Jack", "Mr", 30, "Self");
employee2.Add(new Dependent(6, "Rose", "Mrs", 30, "Spouse"));
employee2.Add(new Dependent(7, "Mary", "Mrs", 30, "Mother"));
employee2.Add(new Dependent(9, "John", "Master", 1, "Child"));

//Adding to Dependency Chart
DependencyChart chart = new DependencyChart();
chart.AddRoot(employee1);
chart.AddRoot(employee2);

//Print
chart.PrintChart();