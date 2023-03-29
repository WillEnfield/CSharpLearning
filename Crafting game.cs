using System.Collections.Generic;

// theres an error with the craft me idk what it is.
class Program
{

    static item pickaxe = new item("Pickaxe", 10, 0.85f, new List<string>(new string[] { "Stone", "Stone", "Stick", "Rope" }));

    static void CheckInventory (List<String> Inventory){
        Console.WriteLine("This is your inventory:");
            Inventory.Sort();
        for (int i = 0; i < Inventory.Count - 1; i++){
            Console.Write(Inventory[i]); 
            Console.Write(",");
            Console.Write(" ");
        }
         Console.Write("And ");
        Console.WriteLine(Inventory[Inventory.Count-1]);
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
            break;
        }
    }

    static void Main(string[] args)
    {

        pickaxe.CanCraft = true;

        int TutuorialProgress = 0;
        string input0;
        List<string> Inventory = new List<string>();
        Inventory.Add("Stone");
        Inventory.Add("Stone");
        Inventory.Add("Stick");
        Inventory.Add("Rope");
        Inventory.Add("Rope");
        pickaxe.CraftMe(Inventory);
        CheckInventory(Inventory);


        Console.WriteLine("Would you like to see the tutuorial? Y or N");
        if (Console.ReadLine() == "Y") {
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
                    } else {
                        Console.WriteLine("Please type \"Craft\" again and then \"Pickaxe\".");
                    }
                } else{
                    Console.WriteLine("Please type \"Craft\"");
                }
            }
        }
    }
}
 