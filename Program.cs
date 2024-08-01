// hamma 3 ta vazifa shu repositoriyda alohida branchlar korinishida ham joylangan
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

﻿//1. Doira yuzi va aylana uzunligini hisoblash
Console.Write("Radiusni kiriting : ");
string radiusStr = Console.ReadLine();
int radius = Convert.ToInt32(radiusStr);
double S = Math.PI * radius * radius;
double L = 2 * Math.PI * radius;
Console.WriteLine($" Doiraning yuzi : {S}");
Console.WriteLine($" Aylana uzunligi : {L}");

﻿// 2. Valyuta konvertori
System.Console.Write("Valyuta kiriting : ");
string valyutaStr = Console.ReadLine();
int valyuta = Convert.ToInt32(valyutaStr);
int kurs = 12400;
int qiymat = valyuta * kurs;
System.Console.WriteLine($"Qiymat -> {qiymat} so'm"); 
