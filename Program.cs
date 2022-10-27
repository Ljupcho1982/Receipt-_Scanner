
using Receipt__Scanner;

List<Report> reports = new List<Report>()
{

    new Report {Product="Apple", Origin="Domestic", Price=10.5M, Weight=2},

    new Report{Product="Peer",Origin="Domestic", Price=15.3M, Weight=3},

    new Report{Product="Avocado", Origin="Imported",Price=20M, Weight=4},

    new Report{Product="Mango", Origin="Imported",Price=23,Weight=5},
    new Report{Product="Banana", Origin="Imported",Price=23,Weight=5}

};

var sum = 0;
var sum1 = 0;



var groupByOrigin =
    from report in reports
    orderby report.Product
    group report by report.Origin;

foreach (var origin in groupByOrigin)
{
    Console.WriteLine($"Origin: {origin.Key}");


    foreach (var r in origin)
    {
        Console.WriteLine($"\t Product:{r.Product}, Price: {r.Price}, Weight: {r.Weight} Total sum={r.Price * r.Weight}");







        sum += Convert.ToInt32(r.Price * r.Weight);

        sum1 += Convert.ToInt32(r.Price * r.Weight);

    }




    Console.WriteLine($"\t Sales: {origin.Key}  {origin.Count()}");

    Console.WriteLine($"\t Total Price: {origin.Key}  {sum}");

    sum = 0;


}

Console.WriteLine($"The total bill is:{sum1} ");




