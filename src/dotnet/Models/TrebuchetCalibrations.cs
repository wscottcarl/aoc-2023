public class TrebuchetCalibrations {
    private IEnumerable<int> _digits {get; set;}

    public TrebuchetCalibrations(string inputFilePath) {
        var lines = File.ReadLines(inputFilePath);

        _digits = lines.Select(l => {
            var firstDigit = l.First(c => Char.IsDigit(c));
            var lastDigit = l.Last(c => Char.IsDigit(c));
            var concatDigit = $"{firstDigit}{lastDigit}";
            return Int32.Parse(concatDigit);
        });
    }

    public void ReportDigits() {
        foreach(var line in _digits) {
            Console.WriteLine($"Line: {line}");
        }
    }

    public void ReportSum() {
        var sum = _digits.Sum();
        Console.WriteLine($"Sum: {sum}");
    }
}