var path = "strings.txt";
var readText = File.ReadAllLines(path).ToList();

var sum = Aggregate(readText).Sum();

Console.WriteLine(sum);
Console.ReadLine();

static List<int> Aggregate(List<string> strings) => strings.Aggregate(new List<int>(), (sum, val) => 
{
    var numbers = GetNumbers(val);
    sum.Add(int.Parse($"{numbers[0]}{numbers[^1]}"));
    return sum;
});

static char[] GetNumbers(string val) => val.Where(Char.IsDigit).ToArray();