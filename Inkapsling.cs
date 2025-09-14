

namespace Inlämningsuppgift1
{
    public class Inkapslinguser
    {
        // Jag vill skapa en klass med inkapsling User med privat lösenord och SetPassword
        private string password;
        // Privat fält för lösenord


        public void SetPassword(string pwd)
        {
            // Jag kan lägga till validering för lösenordet här om det behövs
            if (pwd.Length >= 6) // Exempel på enkel validering
            {
                password = pwd;
            }
            else
            {
                Console.WriteLine("Lösenordet måste vara minst 6 tecken långt.");
            }

          
        }

    }
}
