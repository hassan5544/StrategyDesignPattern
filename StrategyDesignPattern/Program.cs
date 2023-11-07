using StrategyDesignPattern;

class Program
{
    public static void Main()
    {
        PayingToCompany payment = new PayingToCompany(new MasterCardMethod());

        payment.Pay(1000);


        PayingToCompany payment2 = new PayingToCompany(new PayPalMethod());

        payment2.Pay(1000);
    }
}