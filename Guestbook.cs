using System.Text.Json;

// Hanterar gästbokens inlägg och lagring i JSON-format.
public class Guestbook
{
    // Lista som innehåller alla inlägg samt filnamnet för lagring.
    private List<Post> posts = new List<Post>();
    private string fileName = "guestbook.json";

    // Konstruktorn läser in tidigare sparade inlägg när objektet skapas.
    public Guestbook()
    {
        LoadPosts();
    }

    // Skapar ett nytt Post-objekt och lägger till det i listan.
    public void AddPost(string owner, string message)
    {
        Post newPost = new Post();

        newPost.Owner = owner;
        newPost.Message = message;

        posts.Add(newPost);

        // Sparar listan efter att ett nytt inlägg lagts till.
        SavePosts();
    }

    // Visar alla inlägg med respektive index, ägare och meddelande.
    public void ShowPosts()
    {
        for (int i = 0; i < posts.Count; i++)
        {
            Console.WriteLine($"[{i}] {posts[i].Owner}");
            Console.WriteLine(posts[i].Message);
            Console.WriteLine();
        }
    }

    // Tar bort inlägget med angivet index om indexet är giltigt.
    // Returnerar true om borttagningen lyckades, annars false.
    public bool RemovePost(int index)
    {
        if (index >= 0 && index < posts.Count)
        {
            posts.RemoveAt(index);

            // Uppdaterar JSON-filen efter borttagningen.
            SavePosts();

            return true;
        }

        return false;
    }

    // Serialiserar listan till JSON och sparar den i en fil.
    private void SavePosts()
    {
        string json = JsonSerializer.Serialize(posts);

        File.WriteAllText(fileName, json);
    }

    // Läser in tidigare sparade inlägg från JSON-filen.
    private void LoadPosts()
    {
        // Kontrollerar att filen finns innan den läses.
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);

            // Deserialiserar JSON till en lista med Post-objekt.
            List<Post>? loadedPosts =
                JsonSerializer.Deserialize<List<Post>>(json);

            // Ersätter den tomma listan om inläsningen gav en lista.
            if (loadedPosts != null)
            {
                posts = loadedPosts;
            }
        }
    }
}