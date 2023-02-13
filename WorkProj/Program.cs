string foydalanuvchi = "Assalomu alaykum,Yangi foydalanuvchi!";

Console.WriteLine(foydalanuvchi);
Console.Write("Istimos,Ismingizni kiriting: ");
string ism = Console.ReadLine();
Console.Write("Familiyangizni kiriting: ");
string familiya = Console.ReadLine();
Console.WriteLine("Sizning familiyangiz va ismingiz: "+familiya + " "+ism);
Console.ReadKey();