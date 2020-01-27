using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    { 

        CultureInfo enUS = new CultureInfo("en-US");
        var startDate = DateTime.ParseExact(Console.ReadLine(),
           "dd.mm.yyyy", CultureInfo.InvariantCulture.DateTimeFormat);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "dd.mm.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date.AddDays(1))
            if (date.DayOfWeek == DayOfWeek.Saturday &&
                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        Console.WriteLine(holidaysCount);
    }
}
