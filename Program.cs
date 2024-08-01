// 2. Valyuta konvertori
System.Console.Write("Valyuta kiriting : ");
string valyutaStr = Console.ReadLine();
int valyuta = Convert.ToInt32(valyutaStr);
int kurs = 12400;
int qiymat = valyuta * kurs;
System.Console.WriteLine($"Qiymat -> {qiymat} so'm"); 
