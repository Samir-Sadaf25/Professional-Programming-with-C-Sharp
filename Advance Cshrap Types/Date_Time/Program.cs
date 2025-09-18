DateTime d1 = new DateTime(2004,6,25); // take multiple parameter 

DateTime d2 = DateTime.Now; // show time according to the user device or computer time zone
DateTime d3 = DateTime.UtcNow; // show time according to user's time zone
                               // ex: in bd i show 10pm and in india i show 9:30pm


DateTime d4 = d1.AddDays(2); // show 2 days after
DateTime d5 = d1.AddDays(-2); // show 2 days before
//Console.WriteLine(d5.ToString("dd-MM-yyyy"));
Console.WriteLine(d1.ToShortTimeString());
Console.WriteLine(d1.ToShortDateString());

double dayGap = d1.Subtract(d5).TotalDays;
Console.WriteLine(dayGap);