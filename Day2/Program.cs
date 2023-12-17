var path = "games.txt";
var readText = File.ReadAllLines(path).ToList();
var exCubes = new Cubes(13, 14, 12);

var potentialGames = readText.Select(row => SelectPotentialGameNumbers(row,exCubes));

static int SelectPotentialGameNumbers(string game, Cubes exCubes)
{
    var (number, values) = Functions.GetNumberValues(game.Split(':'));
    var possibleGame = values.Split(';').All(value => Functions.PossibleGame(value, exCubes));

    return possibleGame ? int.Parse(Functions.GetNumbers(number)) : 0;
}

Console.WriteLine(potentialGames.Sum());
Console.ReadLine();