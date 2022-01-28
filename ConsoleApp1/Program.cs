// See https://aka.ms/new-console-template for more information

using System.Globalization;
using CsvHelper;

var reader = new StreamReader("C:/Users/User/Desktop/music.csv");
var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
var records = csv.GetRecords<dynamic>();

foreach (var record in records)
{
    Console.WriteLine(record.Name+" || "+record.Artist);
}
