public class Program
{
    public static void Main()
    {
        var digits = new Digits();
        Console.WriteLine(digits.Code);
        Console.WriteLine(digits.Balance);
    }

    public class Digits
    {
        public byte Code { get; } = 0b1100;
        public long Length { get; } = 1_000_000_000;
    }    

}
 