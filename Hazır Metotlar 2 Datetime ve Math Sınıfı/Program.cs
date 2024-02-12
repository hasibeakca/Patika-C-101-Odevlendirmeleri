Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);




Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);


Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());



Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMonths(5));
Console.WriteLine(DateTime.Now.AddYears(2));
Console.WriteLine(DateTime.Now.AddMilliseconds(30));

//Datetime format
Console.WriteLine(DateTime.Now.ToString("dd")); // 24
Console.WriteLine(DateTime.Now.ToString("ddd")); // Sat
Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday


Console.WriteLine(DateTime.Now.ToString("MM")); // 04
Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
Console.WriteLine(DateTime.Now.ToString("MMMM")); // April


Console.WriteLine(DateTime.Now.ToString("yy")); // 24
Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2024

//Math kütüphanesi


// Abs mutlak alma

Console.WriteLine(Math.Abs(-25)); // 25
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));
Console.WriteLine(Math.Tan(30));


Console.WriteLine(Math.Ceiling(22.3)); // verilen sayıdan büyük en küçük tam sayı
Console.WriteLine(Math.Round(22.3)); // normal yuvarlama işlemi
Console.WriteLine(Math.Floor(22.7)); // Aşağı yuvarlar


// Min Max

Console.WriteLine(Math.Max(2,6));
Console.WriteLine(Math.Min(4,8));

Console.WriteLine(Math.Pow(3,4)); // Üssünü alır 3 üzeri 4
Console.WriteLine(Math.Sqrt(16)); // karekök 16
Console.WriteLine(Math.Log(9)); // 9un e tabanındaki logaritmik karşılığı
Console.WriteLine(Math.Exp(3)); // e üzeri 3ü verir.
Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı




