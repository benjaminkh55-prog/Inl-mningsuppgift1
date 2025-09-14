

namespace Inlämningsuppgift1
{
    public class bike : Car

    {
        public int hjul;
        public void visaInfo()
        {
            base.visaInfo(); // Anropa basklassens metod för att visa bilinformation
            Console.WriteLine("Hjul: " + hjul); // Visa den extra egenskapen för bike
        }
    }
}
