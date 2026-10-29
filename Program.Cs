using AdventureGame;

public class Program
{
	public static void Main()
	{
		Room entrance = new Room("Entrance", "A dry stone chamber with daylight spilling through the doorway.");

		Console.WriteLine($"{entrance.Name}: {entrance.Description}");
	}
}