// 3. Yoshni hisoblash

System.Console.Write("Tug'ilgan yilingizni kiriting : ");
string yearStr = Console.ReadLine();
int year = Convert.ToInt32(yearStr);
int currentYear = 2024;
int age = currentYear - year;
int days = age * 366;
System.Console.WriteLine($"Output : {days}"); 


