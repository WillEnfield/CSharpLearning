using System.Collections.Generic;


class Program
{
    public static int Coins = 0;

    static item pickaxe = new item("Pickaxe", 10, 0.85f, new List<string>(new string[] { "Stone", "Stone", "Stick", "Rope" }));

    static void CheckInventory (List<String> Inventory){
        Console.WriteLine("This is your inventory:");
            Inventory.Sort();
            if (Inventory.Count != 0){
                if (Inventory.Count == 1) {
                    Console.WriteLine(Inventory[0] + ".");
                } else{
                    
            
        for (int i = 0; i < Inventory.Count - 1; i++){
            Console.Write(Inventory[i]); 
            Console.Write(",");
            Console.Write(" ");
        }
        Console.Write("And ");
        Console.Write(Inventory[Inventory.Count-1]);
        Console.WriteLine(".");
        }
        } else {
            Console.WriteLine("You don't have any items in your inventory.");
        }
    }

    static void craft (List<string> inventory) {
        Console.WriteLine("What would you like to craft?");
        string CraftingItem = Console.ReadLine();
        switch (CraftingItem)
        {
            case "Pickaxe":
                pickaxe.CraftMe(inventory);
            break;
            default:
            Console.WriteLine("You dont know that item.");
            break;
        }
    }

    static void AddToInventory(List<string> inventory, params string[] items) {
        inventory.AddRange(items);
    }

    static int Sell (List<string> inventory, int coins){
        Console.WriteLine("What would you like to sell?");
        string SellingItem = Console.ReadLine();

        switch (SellingItem)
        {
            case "pickaxe":
            pickaxe.SellMe(inventory, coins);
            break;
            default:
            Console.WriteLine("You dont have that item"); 
            break;
        }
        return coins;
    }

    static void Main(string[] args)
    {

        pickaxe.CanCraft = true;

        int TutuorialProgress = 0;
        string input0;
        List<string> Inventory = new List<string>();
        AddToInventory(Inventory,"Stone", "Stone", "Stick", "Rope");
        pickaxe.CraftMe(Inventory);
        CheckInventory(Inventory);
        pickaxe.SellMe(Inventory, Coins);

        Console.WriteLine("Would you like to see the tutuorial? Y or N");
        input0 = Console.ReadLine();
        if (input0 == "Y" || input0 == "y") {
            Console.WriteLine("You are a wandering trader, lets start by checking your inventory, type Inventory to check your inventory.");
            while (TutuorialProgress == 0){
                input0 = Console.ReadLine();
            if (input0 == "Inventory" || input0 =="inventory") {
                CheckInventory(Inventory);
                TutuorialProgress++;
            } else {
                Console.WriteLine("Please type \"Inventory\"");
            }
            }
            Console.WriteLine("It looks like you have a few recources, how about you craft a pickaxe?");
            Console.WriteLine("To craft a pickaxe type Craft, and then Pickaxe.");
            while (TutuorialProgress == 1){
                input0 = Console.ReadLine();
               if (input0 == "Craft" || input0 == "craft"){
                    Console.WriteLine("What would you like to craft?");
                    input0 = Console.ReadLine();
                    if (input0 == "Pickaxe" || input0 == "pickaxe"){
                        pickaxe.CraftMe(Inventory);
                        TutuorialProgress++;
                    } else {
                        Console.WriteLine("Please type \"Craft\" again and then \"Pickaxe\".");
                    }
                } else{
                    Console.WriteLine("Please type \"Craft\"");
                }
            }
            Console.WriteLine("I wonder if you have any coins.");
            Console.WriteLine("Type \"Coins\".");
            while (TutuorialProgress == 2){
                if (true) {
                    
                }
            }
        }
    }

}
 