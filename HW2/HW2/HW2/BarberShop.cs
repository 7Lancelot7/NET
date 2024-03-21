namespace HW2;

public class BarberShop
{
    private readonly object _lock = new object();
    
    private Queue<Customer> _waitingCustomers;
    
    private Barber _barber;
    
    private  readonly int _queueCapacity;
    
    public BarberShop(int queueCapacity )
    {
        _queueCapacity = queueCapacity;
        _waitingCustomers=new Queue<Customer>(_queueCapacity);
        _barber = new Barber(_waitingCustomers);
       
        
    }

    private void AddCustomerToQueue(Customer customer)
    {
        if (_waitingCustomers.Count < _queueCapacity)
        {
            _waitingCustomers.Enqueue(customer);
        }
    }
    public async Task AddCustomerAsync(Customer customer)
    {
        await Task.Run(() => AddCustomerToQueue(customer));
    }

    public Customer GetCustomerFromQueue()=>_waitingCustomers.Dequeue();
    
    public void StartBarberWork()
    {
        Thread barberThread = new Thread(() => _barber.Work());
        barberThread.Start();
    }
}