using Prototype.Entities;

User user = new User()
{
    Name = "Sam",
    Email = "sam@dp.com",
    Phone = "9876543210",
    Address = new Address()
    {
        Street = "Castle Ave",
        City = "Hogwards",
        PostalCode="OWLXII"
    }
};

Console.WriteLine("      Shallow Clone\n");

User shallowCloneUser  = (User)user.Clone();

Console.WriteLine($"{nameof(shallowCloneUser.Name)}          : {shallowCloneUser.Name}");
Console.WriteLine($"{nameof(shallowCloneUser.Email)}         : {shallowCloneUser.Email}");
Console.WriteLine($"{nameof(shallowCloneUser.Phone)}         : {shallowCloneUser.Phone}");
Console.WriteLine($"{nameof(shallowCloneUser.Address.Street)}        : {shallowCloneUser.Address.Street}");
Console.WriteLine($"{nameof(shallowCloneUser.Address.City)}          : {shallowCloneUser.Address.City}");
Console.WriteLine($"{nameof(shallowCloneUser.Address.PostalCode)}    : {shallowCloneUser.Address.PostalCode}");

Console.WriteLine("\nUpdating Address -> Postal Code Value");
Console.WriteLine($"Old Value : {shallowCloneUser.Address.PostalCode} -> HOGPS01\n");

shallowCloneUser.Address.PostalCode = "HOGPS01";

Console.WriteLine($"{nameof(shallowCloneUser.Name)}          : {shallowCloneUser.Name}");
Console.WriteLine($"{nameof(shallowCloneUser.Email)}         : {shallowCloneUser.Email}");
Console.WriteLine($"{nameof(shallowCloneUser.Phone)}         : {shallowCloneUser.Phone}");
Console.WriteLine($"{nameof(shallowCloneUser.Address.Street)}        : {shallowCloneUser.Address.Street}");
Console.WriteLine($"{nameof(shallowCloneUser.Address.City)}          : {shallowCloneUser.Address.City}");
Console.WriteLine($"{nameof(shallowCloneUser.Address.PostalCode)}    : {shallowCloneUser.Address.PostalCode}");

/* -------------------------------------------------------------------------------------------------------*/

Console.WriteLine("\n       Deep Clone\n");

User deepCloneUser = user.DeepClone();

Console.WriteLine($"{nameof(deepCloneUser.Name)}          : {deepCloneUser.Name}");
Console.WriteLine($"{nameof(deepCloneUser.Email)}         : {deepCloneUser.Email}");
Console.WriteLine($"{nameof(deepCloneUser.Phone)}         : {deepCloneUser.Phone}");
Console.WriteLine($"{nameof(deepCloneUser.Address.Street)}        : {deepCloneUser.Address.Street}");
Console.WriteLine($"{nameof(deepCloneUser.Address.City)}          : {deepCloneUser.Address.City}");
Console.WriteLine($"{nameof(deepCloneUser.Address.PostalCode)}    : {deepCloneUser.Address.PostalCode}");

Console.WriteLine("\nUpdating Address -> Postal Code Value");
Console.WriteLine($"Old Value : {deepCloneUser.Address.PostalCode} -> HOGPS01\n");

deepCloneUser.Address.PostalCode = "HOGPS01";

Console.WriteLine($"{nameof(deepCloneUser.Name)}          : {deepCloneUser.Name}");
Console.WriteLine($"{nameof(deepCloneUser.Email)}         : {deepCloneUser.Email}");
Console.WriteLine($"{nameof(deepCloneUser.Phone)}         : {deepCloneUser.Phone}");
Console.WriteLine($"{nameof(deepCloneUser.Address.Street)}        : {deepCloneUser.Address.Street}");
Console.WriteLine($"{nameof(deepCloneUser.Address.City)}          : {deepCloneUser.Address.City}");
Console.WriteLine($"{nameof(deepCloneUser.Address.PostalCode)}    : {deepCloneUser.Address.PostalCode}");