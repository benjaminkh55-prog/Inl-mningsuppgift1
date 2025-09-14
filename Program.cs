namespace Inlämningsuppgift1
{
    public class Program
    {
        static void Main(string[] args, string paypal)
        {
            Console.WriteLine("Hello, World!");

        // Jag skapar en objekt av klass car 
                        Car car1 = new Car();
            // Tilldela värden till objektets egenskaper
                car1.model = 2023;
                car1.pris = "500000";
                car1.name = "Volvo";
            // Vista info metoden anropas för att visa bil information
            car1.visaInfo();



            // Här visar jag Arv exempel med bike klass som ärver från Car klass
            bike bike1 = new bike();
            bike1.model = 2022;
            bike1.pris = "15000";
            bike1.name = "Yamaha";
            // anropa visaInfo metoden för att visa bil information
               bike1.hjul = 2;
                bike1.visaInfo();


            // inkapsling exempel med Inkapslinguser klass 
            Inkapslinguser user1 = new Inkapslinguser();
            user1.SetPassword("000000");
            //nu kan jag inte komma åt password direkt eftersom det är privat


            // abstract exempel med PaymentMethodpaypa klass 
            PaymentMethodpaypa payment = new Paypal();
            
            payment.ProcessPayment(100.00m);
            payment.amount = 100;
            payment.name = paypal;

            // Anropa den implementerade metoden för att bearbeta betalning
            payment.visaInfo();


            // polymorfism exempel ag vill skapa en Shape med Draw() metod 
            Polymorfism shape = new Circle();
            shape.Draw(); 
            // Anropa den överlagrade metoden i Circle-klassen






















        }
    }
}
