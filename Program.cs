string[] initStr;
Console.WriteLine("Введите массив строк через запятую");
string str = Console.ReadLine();
initStr = str.Split(',');
var result = new string[initStr.Length];
var realSize = 0;
foreach (var value in initStr )
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);