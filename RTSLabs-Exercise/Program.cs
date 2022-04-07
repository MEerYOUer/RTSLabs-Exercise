using RTSLabs_Exercise;

try
{
    // int comparison
    var comparison = 6;
    var unsorted = new int[] { 1, 5, 2, 1, 10, 6, 39024324, -3422 };
    var abResult = Exercise.AboveBelow(unsorted, comparison);
    var resultString = string.Join(", ", abResult.Select(x => x.Key + ": " + x.Value).ToArray());

    Console.WriteLine($"Unsorted: [{string.Join(", ", unsorted)}]\nComparison: {comparison}");
    Console.WriteLine($"AB Result: {resultString}");
    Console.WriteLine();

    // string rotation
    uint rotation = 2;
    var original = "MyString";
    var shiftedResult = Exercise.StringRotation(original, rotation);

    Console.WriteLine($"Original string: {original}");
    Console.WriteLine($"Shifted result: {shiftedResult}");
}
catch (Exception ex)
{
    Console.WriteLine($"Exception: Message: [{ex.Message}]\nStack trace: {ex.StackTrace}");
}