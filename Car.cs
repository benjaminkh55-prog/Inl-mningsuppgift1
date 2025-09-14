

namespace Inlämningsuppgift1
{
    public class Car
    {
        public int model;
        public string pris;
        public string name;

        public void visaInfo()
        {
            
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Pris: " + pris);
            Console.WriteLine("Name: " + name);
        }

    }
}
