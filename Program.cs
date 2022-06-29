//Ваша задача — написать метод, который возвращает сумму следующих рядов до n-го члена (параметра).
Console.WriteLine(NthSeries.seriesSum(2));

public class NthSeries
{
	public static string seriesSum(int n)
	{
        if (n == 0) return "0.00";
        else if (n == 1) return "1.00";
        decimal result = 0;
        for (int i = 1, j = 1; i <= n; i++, j+=3)
        {
            decimal firstElement = 1;
            result += firstElement / j;
        }
        result = Math.Round(result, 2);
        return result.ToString();
            
	}
}