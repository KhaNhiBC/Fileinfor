internal class Program
{
    private static void Main(string[] args)
    {
        string sourceFilePath = @"D:\baitap\Source.txt"; //File nguồn
        string desFilePath = @"D:\baitap\Des.txt"; //File đích
        File.Copy(sourceFilePath,desFilePath, true);
    }

}