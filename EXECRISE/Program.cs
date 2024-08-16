namespace Execrise00;
internal class Program
{
    public static void main(string[] args)
    {
        Console.WriteLine("Bai tap 01");
        Console.Write("Enter a number ");
        // Convert to int 32
        int nu1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number ");
        // Convert to int 32
        int nu2 = Convert.ToInt32(Console.ReadLine());

        // do the calculation
        Console.WriteLine("The total is {0}", (nu1 + nu2));
        Console.WriteLine();

        // BT02
        Console.WriteLine("Bai tap 02");
        Console.Write("Enter a number ");
        // Convert to int 32
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number ");
        // Convert to int 32
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Before swapping: x is {0} and y is {1}", x, y);
        // swapping process
        x = x + y;
        y = x - y;
        x = x - y;

        Console.WriteLine("After swapping: x is {0} and y is {1}", x, y);
        Console.WriteLine();

        // BT 03
        Console.WriteLine("Bai tap 3");
        Console.Write("Enter a float number ");
        float value1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Enter a float number ");
        float value2 = Convert.ToSingle(Console.ReadLine());

        // process and result
        float mutiply = (float) (value1 *value2);
        Console.WriteLine($"{value1} x {value2} = {mutiply}");
        Console.WriteLine();

        // BT 04
        Console.WriteLine("Bai tap 4");

        const float feetToMeter = 0.3048f;
        Console.Write("Enter feet ");
        float feet = Convert.ToSingle(Console.ReadLine());

        // Do the math
        float result = feetToMeter * feet;
        Console.WriteLine($"{feet} is equal to {result} meters");
        Console.WriteLine();
        

        // BT05
        Console.WriteLine("Bai tap 5");
        

        // get the input from the user and covert from C to F
        Console.Write("Enter a Celsius degree ");
        float celsius = Convert.ToSingle(Console.ReadLine());
        float key0 = (float)((celsius * 1.8) + 32);
        Console.WriteLine($"{celsius} C is equal to " + "{0} F", (float)(key0));

        //  get the input from the user and convert from F to C
        Console.Write("Enter a farenheint degree ");
        float faren = Convert.ToSingle(Console.ReadLine());
        float key1 = (float)((faren - 32) / 1.8);
        Console.WriteLine($"{faren} F is equal to " + "{0} C", (float)(key1));  


        Console.ReadKey();

    }
        

}