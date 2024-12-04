internal class Program
{
    public struct carS
    {
        public string type;
        public int carKM;
        public bool isRented;
    }

    public class carC
    {
        public string type;
        public int carKM;
        public bool isRented;
    }

    public static void changeCarS (carS c)
    {
        c.type = "Toyota";
        c.carKM = 12500;
        c.isRented = true;
    }

    public static void changeCarSByRef(ref carS c)
    {
        c.type = "Toyota";
        c.carKM = 12500;
        c.isRented = true;
    }

    public static void changeCarC(carC c)
    {
        c.type = "Honda";
        c.carKM = 17900;
        c.isRented = false;
    }
/*
    private static void Main(string[] args)
    {
        carS carStruct = new carS();
        carStruct.type = "Mazda";
        carStruct.carKM = 50000;
        carStruct.isRented = false;

        Console.WriteLine("car struct before:");
        Console.WriteLine("Type:  {0}. Km: {1}. Rented: {2}. ", carStruct.type, carStruct.carKM, carStruct.isRented);
        changeCarS(carStruct);
        Console.WriteLine("car struct after:");
        Console.WriteLine("Type:  {0}. Km: {1}. Rented: {2}. ", carStruct.type, carStruct.carKM, carStruct.isRented);

        carC carClass = new carC();
        carClass.type = "Nisan";
        carClass.carKM = 49300;
        carClass.isRented = true;
        Console.WriteLine();

        Console.WriteLine("car class before:");
        Console.WriteLine("Type:  {0}. Km: {1}. Rented: {2}. ", carClass.type, carClass.carKM, carClass.isRented);
        changeCarC(carClass);
        Console.WriteLine("car class after:");
        Console.WriteLine("Type:  {0}. Km: {1}. Rented: {2}. ", carClass.type, carClass.carKM, carClass.isRented);
        Console.WriteLine()
            ;
        Console.WriteLine("car struct by ref before:");
        Console.WriteLine("Type:  {0}. Km: {1}. Rented: {2}. ", carStruct.type, carStruct.carKM, carStruct.isRented);
        changeCarSByRef(ref carStruct);
        Console.WriteLine("car struct by ref after:");
        Console.WriteLine("Type:  {0}. Km: {1}. Rented: {2}. ", carStruct.type, carStruct.carKM, carStruct.isRented);




    }
*/
}