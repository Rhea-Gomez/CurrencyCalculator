class CurrencyDenominationApp 
{
    static void Denomination(int amount)
    {
        if (amount % 100 == 0 && amount <= 50000)
        {
            int[] currency = { 2000, 500, 200, 100 };
            
            for (int i = 0; i < currency.Length; i++) {
                int noteCount;

                noteCount = amount / currency[i];
                Console.WriteLine("No. of Denominations of " + currency[i] + ":" + noteCount.ToString());
                amount = amount % currency[i] ;

            }
        } else 
        {
            Console.WriteLine("The amount should be a multiple of 100 and it cannot exceed Rs. 50000");
        }
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter withdrawal amount: ");
        int amount = int.Parse(Console.ReadLine());

        Denomination(amount);
    }

}
