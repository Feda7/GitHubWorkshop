public static double AverageList(List<double> numbers)
{
    if (numbers.Count == 0)
        return 0; // تجنب القسمة على صفر
    double sum = 0;
    foreach (double num in numbers)
    {
        sum += num;
    }
    return sum / numbers.Count;
}
