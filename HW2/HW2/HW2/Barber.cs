namespace HW2;

public class Barber
{
    private Queue<Customer> _waitingCustomers;
    public Barber(Queue<Customer> waitingCustomers )
    {
        _waitingCustomers = waitingCustomers;
    }
    
    private void CutHair()
    {
        Thread.Sleep(2000);
    }
    
    public void Work()
    {
        while (true)
        {
            Console.WriteLine("Barber is sleeping");
            while (_waitingCustomers.Count == 0)
            {
                Thread.Sleep(1000);
            }

            Customer customer = GetCustomerFromQueue();
            if (customer != null)
            {
                Console.WriteLine($"Barber is working on {customer.Name}'s hair");
                CutHair();
                Console.WriteLine($"Haircut finished for {customer.Name}");
            }
        }
    }

    private Customer GetCustomerFromQueue()
    {
        lock (_waitingCustomers)
        {
            if (_waitingCustomers.Count > 0)
            {
                return _waitingCustomers.Dequeue();
            }
            return null;
        }
    }
}