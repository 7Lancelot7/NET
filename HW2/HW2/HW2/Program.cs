using HW2;

class Program
{
    static void Main(string[] args)
    {
        BarberShop barberShop = new BarberShop(2);
        barberShop.StartBarberWork();
        
        Task addCustomersTask = Task.Run(async () =>
        {
            double i = 0;
            while (true)
            {
                
                await barberShop.AddCustomerAsync(new Customer($"Customer{i}"));
                i+=1;
            }
            
        });
    }
}