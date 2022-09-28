//Голубихин Данила 22-ИСП-2/2
Console.WriteLine("Введите расстрояние в километрах:");
double kms = double.Parse(Console.ReadLine());
Console.WriteLine("Введите расстрояние в футах:");
double fs = double.Parse(Console.ReadLine());
double kms1 = kms * 1000;
double fs1 = fs / 0.305;
if (kms1 < fs1) Console.WriteLine("Расстояние в километрах меньше");
else Console.WriteLine("Расстояние в футах меньше");
