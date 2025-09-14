



namespace Inlämningsuppgift1
{
    
    
        public abstract class PaymentMethodpaypa 
        {
            public abstract void ProcessPayment(decimal amount);

        public int amount;
        public string name; 
        public void visaInfo()
        {
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Name: " + name);
        }


    }
}

