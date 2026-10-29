
namespace AdventureGame;//Nombre del Proyecto
public class Room;
{
public string Name{get; }
public string Description{get; set;}
public Room(string name, string description)// Constructor de la clase Room que recibe el Name & Description
{
    Name=name;
    Description=description;
}
}