using Composite;

//Employee 1
Employee employee1 = new Employee(1, "Sam", "Mr", 30, "Self");
Dependent dependent1 = new Dependent(3, "June", "Mrs", 30, "Spouse");
employee1.Add(dependent1);

//Employee 2
Employee employee2 = new Employee(4, "Jack", "Mr", 30, "Self");
Dependent dependent2 = new Dependent(6, "Rose", "Mrs", 30, "Spouse");
Dependent dependent2_1 = new Dependent(7, "Mary", "Mrs", 55, "Mother");
Dependent dependent2_2 = new Dependent(9, "John", "Master", 1, "Child");
employee2.Add(dependent2);
employee2.Add(dependent2_1);
employee2.Add(dependent2_2);

//Adding to Dependency Chart
DependencyChart dependencyChart = new DependencyChart();
dependencyChart.AddRoot(employee1);
dependencyChart.AddRoot(employee2);

//Print
dependencyChart.PrintChart();