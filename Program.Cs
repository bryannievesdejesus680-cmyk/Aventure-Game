using AdventureGame;

public class Program
{
	public static void Main()
	{
		Room entrance = new Room("Entrance", "A dry stone chamber with daylight spilling through the doorway.");
		Room gallery = new Room("Gallery", "A long gallery lined with faded banners.");
		Room alias = gallery;

		alias.Description = "A long gallery with a freshly opened skylight.";

		Console.WriteLine($"{entrance.Name}: {entrance.Description}");
		Console.WriteLine($"{gallery.Name}: {gallery.Description}");
		Console.WriteLine($"{alias.Name}: {alias.Description}");
		Console.WriteLine();
		Console.WriteLine($"Entrance and Gallery are the same: {entrance == gallery}");
		Console.WriteLine($"Alias and Gallery are the same: {alias == gallery}");
	}
}