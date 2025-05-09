// DateTime object

//var someDateTime = new DateTime(1976,02,24);
//Console.WriteLine($"SomeDate: {someDateTime}");

//var thisDateTime = new DateTime(1976, 03, 15, 07, 07, 07,DateTimeKind.Local);
//Console.WriteLine($"DOB: {thisDateTime}");

//Console.WriteLine($"Day of the week: {someDateTime.DayOfWeek}");
//Console.WriteLine($"Year: {someDateTime.DayOfYear}");
//Console.WriteLine($"Time of day: {thisDateTime.TimeOfDay}");
//Console.WriteLine($"Tick: {thisDateTime.Ticks}");
//Console.WriteLine($"Kind: {thisDateTime.Kind}");

////Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("What time is it now: " + now);
////Create a DateTime from a string
//Console.WriteLine("What is your DOB (yyyy/MM/dd): ");
//string dob = Console.ReadLine();
//var userDOB = DateTime.Parse(dob);
//Console.WriteLine($"Day of the week: {userDOB.DayOfWeek}");
//Console.WriteLine($"Year: {userDOB.DayOfYear}");
//Console.WriteLine($"Time of day: {userDOB.TimeOfDay}");
//Console.WriteLine($"Tick: {userDOB.Ticks}");
//Console.WriteLine($"Kind: {userDOB.Kind}");

////Change DateTime format
//Console.WriteLine($"Formatted Date; {userDOB.ToString("dd/MM/yyyy")}");
//Console.WriteLine($"Formatted Date; {userDOB.ToString("MMM dd, yyyy")}");
//Console.WriteLine($"Formatted Date; {userDOB:dd-MMMM-yyyy}");

////Add additional time
//Console.WriteLine("One hour from now is: " + now.AddHours(1));
//Console.WriteLine("One day from now is: " + now.AddDays(10));
//Console.WriteLine("One year from now is: " + now.AddYears(5));
//Console.WriteLine("15 year ago from now was: " + now.AddYears(-15));

//// UTC Coordinated Universal Time
//var utcNow = DateTime.UtcNow;
//Console.WriteLine($"Now Date Time: {now}");
//Console.WriteLine($"UTC Now Date Time: {utcNow}");


//DateTimeOffSet and TimeZone Info
//var tz = TimeZoneInfo.Local.GetUtcOffset( utcNow );
//Console.WriteLine($"User Time Zone: {tz}");

//var dto = new DateTimeOffset(now, tz);
//Console.WriteLine($"User time zone with utc offset: {dto}");
//Console.WriteLine($"UTC Time of Action: {dto.UtcDateTime}");

//var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
//var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
//Console.WriteLine($"Action was completed in India at: {indiaDateTime}");

//DateOnly
var dateOnly = new DateOnly(1995, 02, 24);
var nextDay = dateOnly.AddDays(1);
var previousDay = dateOnly.AddDays(-1);
var decadeLater = dateOnly.AddDays(10);
var lastMonth = dateOnly.AddMonths(-1);

Console.WriteLine($"The date: {dateOnly}");
Console.WriteLine($"The next day: {nextDay}");
Console.WriteLine($"The previous day {previousDay}");
Console.WriteLine($"The decade later {decadeLater}");
Console.WriteLine($"The last month {lastMonth}");

//Date only right now
var dateOnlyFromDateTime = DateOnly.FromDateTime(now);
Console.WriteLine($"Date only from DateTime: {dateOnlyFromDateTime}");

//TimeOnly
var timeNow = TimeOnly.FromDateTime( now );
Console.WriteLine($"It is now {timeNow}");
Console.WriteLine($"It is now {timeNow: hh:mm tt}");

//Date Comparisons
var date1 = new DateTime(1995, 02, 24);
var date2 = new DateTime(1976, 02, 24);

Console.WriteLine($" Is '{nameof(date1)}' equal? {date1 == date2}");
Console.WriteLine($" Is '{date2} after? {date2 > date1}");
Console.WriteLine($" Is '{date2} before? {date2 < date1}");


