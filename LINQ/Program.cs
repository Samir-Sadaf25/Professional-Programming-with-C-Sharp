using System.Linq;
using System.Text.RegularExpressions;


// data source
int[] scores = [97, 92, 81, 60];
//Query Expression
IEnumerable<int> scoreQuery = // Query variable
                              from score in scores // required
                              where score > 82 //optional
                              orderby score descending // optional
                              select score; // must end with select or group
//foreach (var item in scoreQuery)
//{
//    Console.WriteLine(item + " ");
//}

IEnumerable<int> highScoresQuery = from score in scores where
                                    score > 80
                                   orderby score descending
                                   select score;

IEnumerable<string> highScoreQuery2 =
    from score in scores
    where score > 80
    orderby score descending
    select $"the score is {score}";

var highScoreCount = (from score in scores where score > 80 select score).Count();

IEnumerable<int> highsScoreQuery3 = from score in scores where score > 80 select score;
var scoreCount = highsScoreQuery3.Count();
//Console.WriteLine(scoreCount);


 City[] cities = [
    new City("Tokyo", 37_833_000),
    new City("Delhi", 30_290_000),
    new City("Shanghai", 27_110_000),
    new City("São Paulo", 22_043_000),
    new City("Mumbai", 20_412_000),
    new City("Beijing", 20_384_000),
    new City("Cairo", 18_772_000),
    new City("Dhaka", 17_598_000),
    new City("Osaka", 19_281_000),
    new City("New York-Newark", 18_604_000),
    new City("Karachi", 16_094_000),
    new City("Chongqing", 15_872_000),
    new City("Istanbul", 15_029_000),
    new City("Buenos Aires", 15_024_000),
    new City("Kolkata", 14_850_000),
    new City("Lagos", 14_368_000),
    new City("Kinshasa", 14_342_000),
    new City("Manila", 13_923_000),
    new City("Rio de Janeiro", 13_374_000),
    new City("Tianjin", 13_215_000)
];

Country[] countries = [
    new Country ("Vatican City", 0.44, 526, [new City("Vatican City", 826)]),
    new Country ("Monaco", 2.02, 38_000, [new City("Monte Carlo", 38_000)]),
    new Country ("Nauru", 21, 10_900, [new City("Yaren", 1_100)]),
    new Country ("Tuvalu", 26, 11_600, [new City("Funafuti", 6_200)]),
    new Country ("San Marino", 61, 33_900, [new City("San Marino", 4_500)]),
    new Country ("Liechtenstein", 160, 38_000, [new City("Vaduz", 5_200)]),
    new Country ("Marshall Islands", 181, 58_000, [new City("Majuro", 28_000)]),
    new Country ("Saint Kitts & Nevis", 261, 53_000, [new City("Basseterre", 13_000)])
];

// Query syntex
IEnumerable<City> queryMajorCities =
    from city in cities
    where city.Population > 30_000_000
    select city;
//mathod based syntex
IEnumerable<City> queryMajorCities2 = cities.Where(c => c.Population > 30_000_000);
//foreach (City city in queryMajorCities2)
//{
//    Console.WriteLine(city);
//}

// they are not Query variable because they store only result
var highestScore = (from score in scores
                    select score).Max();
//Console.WriteLine(highestScore);
var largeCitiesList = (from country in countries
                       from city in country.Cities
                       where city.Population > 10000
                       select city).ToList();

var cityQuery = from country in countries
                from city in country.Cities
                where city.Population > 10000
                select city;

//group clause
var queryCountryGroups = from country in countries
                         group country by country.Name[0];

//var queryCities = from city in cities
//             group city by city.Population;
var queryCities = from city in cities
                  group city by city.Name[0];
foreach (var item in queryCities)
{
    Console.WriteLine($"key: {item.Key}");
    foreach (var city in item)
    {
        Console.WriteLine($" {city.Name}");
    }
}

record City(string Name, long Population);
record Country(string Name, double Area, long Population, List<City> Cities);
record Product(string Name, string Category);

