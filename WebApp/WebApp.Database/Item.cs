namespace WebApp.Database;

public class Item
{
    public int Id { get; set; }

    public Guid Guid { get; set; }

    public required string Name { get; set; }

    public int Quantity { get; set; }
 }

