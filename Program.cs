//1. Doira yuzi va aylana uzunligini hisoblash
Console.Write("Radiusni kiriting : ");
string radiusStr = Console.ReadLine();
int radius = Convert.ToInt32(radiusStr);
double S = Math.PI * radius * radius;
double L = 2 * Math.PI * radius;
Console.WriteLine($" Doiraning yuzi : {S}");
Console.WriteLine($" Aylana uzunligi : {L}");
