// Skapar ett Guestbook-objekt och läser in tidigare sparade inlägg.
Guestbook guestbook = new Guestbook();

// Huvudloop som fortsätter tills användaren väljer att avsluta.
while (true)
{
    // Rensar konsolen och visar gästboken samt menysystemet.
    Console.Clear();

    Console.WriteLine("Gästbok");
    Console.WriteLine("-----------------");

    guestbook.ShowPosts();

    Console.WriteLine("-----------------");
    Console.WriteLine("1. Lägg till inlägg");
    Console.WriteLine("2. Ta bort inlägg");
    Console.WriteLine("X. Avsluta");
    Console.WriteLine();

    Console.Write("Välj: ");

    string? choice = Console.ReadLine();

    // Hanterar användarens menyval.
    switch (choice)
    {
        case "1": // Lägg till inlägg

            Console.Write("Ange ägare: ");
            string? owner = Console.ReadLine();

            Console.Write("Ange inlägg: ");
            string? message = Console.ReadLine();

            // Kontrollerar att inget av inmatningsfälten är tomt.
            if (string.IsNullOrWhiteSpace(message) ||
                string.IsNullOrWhiteSpace(owner))
            {
                Console.WriteLine("Både ägare och inlägg måste anges.");
                Console.WriteLine("Tryck på en knapp för att fortsätta...");
                Console.ReadKey();
            }
            else
            {
                // Skickar inmatningen till Guestbook för att skapa ett inlägg.
                guestbook.AddPost(owner, message);
            }

            break;

        case "2": // Ta bort inlägg

            Console.Write("Ange index på inlägget som ska tas bort: ");
            string? input = Console.ReadLine();

            // Försöker omvandla inmatningen till ett heltal.
            if (int.TryParse(input, out int index))
            {
                // Försöker ta bort inlägget och kontrollerar resultatet.
                if (guestbook.RemovePost(index))
                {
                    Console.WriteLine("Inlägget togs bort.");
                }
                else
                {
                    Console.WriteLine("Det finns inget inlägg med det indexet.");
                }
            }
            else
            {
                Console.WriteLine("Fel! Du måste ange ett nummer.");
            }

            // Väntar på användaren innan konsolen rensas.
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();

            break;

        case "X": // Avsluta programmet
        case "x":
            return;

        default:
            // Visar ett felmeddelande vid ogiltigt menyval.
            Console.WriteLine("Ogiltigt menyval. Försök igen.");
            Console.WriteLine("Tryck på en knapp för att fortsätta...");
            Console.ReadKey();
            break;
    }
}