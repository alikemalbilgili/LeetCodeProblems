using System.Diagnostics;

namespace SolutionBase.Utils;

public class SolutionExecutionTimeCalculator
{
    public void MeasureExecutionTime(Action functionToMeasure)
    {
        var stopwatch = Stopwatch.StartNew();
        functionToMeasure();
        stopwatch.Stop();
        Console.WriteLine("Execution time: {0} ms", stopwatch.ElapsedMilliseconds);
    }
}