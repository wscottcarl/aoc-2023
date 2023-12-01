// See https://aka.ms/new-console-template for more information

namespace AdventOfCode;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var calibrationInputFilePath = "../../inputs/day1-input.txt";

        var trebuchetCalibrations = new TrebuchetCalibrations(calibrationInputFilePath);

        trebuchetCalibrations.ReportDigits();

        trebuchetCalibrations.ReportSum();

        Console.WriteLine("Goodbye, world.");
    }
}