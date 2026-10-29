using AdventureGame;

public class Program
{
	public static void Main()
	{
		Room entrance = new Room("Entrance", "A dry stone chamber with daylight spilling through the doorway.");
		Room gallery = new Room("Gallery", "A long gallery lined with faded banners.");
		Room archive = new Room("Archive", "An archive whose shelves hold dust-covered chronicles.");

		Console.WriteLine($"{entrance.Name}: {entrance.Description}");
		Console.WriteLine($"{gallery.Name}: {gallery.Description}");
		Console.WriteLine($"{archive.Name}: {archive.Description}");
	}
}