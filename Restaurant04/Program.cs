using Restaurant04;

MenuItem item1 = new("Pad Thai", "The best rice noodles around!", 12.99, "Entree", false);
MenuItem item2 = new("Shumai", "Enjoy these pork dumplings with black sweet sauce", 6.99, "Appetizer", false);
MenuItem item3 = new("Pho", "A special beef broth soup with rice noodles", 13.99, "Entree", true);
MenuItem item4 = new("Sweet Rice", "This sweet treat pairs perfectly with mango or egg custard", 7.99, "Dessert", true);

Menu newMenu = new Menu();
//Menu removeM = new Menu();
newMenu.NewItems(item1);
newMenu.NewItems(item2);
newMenu.NewItems(item3);
newMenu.NewItems(item4);

MenuItem newItem = new MenuItem();
newItem.CheckNew(item1);

newMenu.RemoveItems(item1);
newMenu.RemoveItems(item2);




System.Console.WriteLine(newMenu.MenuItems[0].Name);
