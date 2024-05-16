namespace Restaurant04
{
    public class Menu
    {
       public DateTime LastUpdated {get; set;} = DateTime.Now;
        public List<MenuItem> MenuItems {get; set;} = new List<MenuItem>();
        public Menu()
        {

        }
        public void NewItems(MenuItem newItem)
        {
            
            MenuItems.Add(newItem);
        }
        public void RemoveItems(MenuItem removeItem)
        {
            MenuItems.Remove(removeItem);
        }
       
}
    }
    