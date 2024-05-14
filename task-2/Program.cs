System.Console.Write("Qiymatni kiriting: ");
double qiymat = System.Convert.ToDouble(System.Console.ReadLine());

System.Console.Write("Valyuta kursini kiriting (so'm): ");
double kurs = System.Convert.ToDouble(System.Console.ReadLine());

double summa = qiymat * kurs;

System.Console.WriteLine($"Konvertatsiya qilingan summa: {summa} so'm");