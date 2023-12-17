public static class Functions
{
    public static (string number, string values) GetNumberValues(string[] split) => (split[0], split[1]);
    public static bool PossibleGame(string grab, Cubes exCube) => AllFewerOrSame(GetCubes(grab.Split(',')), exCube);
    public static bool AllFewerOrSame(Cubes cubes, Cubes exCubes) =>
        FewerOrSame(cubes.blue, exCubes.blue) &&
        FewerOrSame(cubes.green, exCubes.green) &&
        FewerOrSame(cubes.red, exCubes.red);
    public static bool FewerOrSame(int valueOne, int valueTwo) => valueOne <= valueTwo;
    public static Cubes GetCubes(string[] cubes) => new(TryGetCubeNumbers(cubes, "green"), TryGetCubeNumbers(cubes, "blue"), TryGetCubeNumbers(cubes, "red"));
    public static int TryGetCubeNumbers(string[] cubes, string color) => int.Parse(GetNumbers(GuardZero(cubes.FirstOrDefault(grab => grab.Contains(color)))));
    public static char[] GetNumbers(string val) => val.Where(Char.IsDigit).ToArray();
    private static string GuardZero(string? input) => input ?? "0";
}