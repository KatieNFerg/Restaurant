namespace Restaurant04
{
    public class Menu
    {
        public List<MenuItem> MenuItems {get; set;} = new List<MenuItem>();
        public DateTime LastUpdated {get; set;} = DateTime.Now;
    }
}