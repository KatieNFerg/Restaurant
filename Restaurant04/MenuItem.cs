namespace Restaurant04
{
    public class MenuItem
    {
        public string Name {get; set;}
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }
        public DateTime DateAdded{ get; set; }


public MenuItem(string name, string description, double price, string category, bool isNew)
{
    Name = name;
    Description = description;
    Price = price;
    Category = category;
    IsNew = isNew;
}
    }
}