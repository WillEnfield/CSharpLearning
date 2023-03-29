using System.Collections.Generic;
class item {
    public string name;
    public bool CanCraft;
    public int BuyPrice;
    public int SellPrice;
    public float SellMargin;
    public List<string> Cost = new List<string>();


    public item(string _name, int _valubility, float _SellMargin, List<string> _Cost){

        CanCraft = false;
        name = _name;
        SellMargin = 0.85f;
        BuyPrice = _valubility;
        SellPrice = (int)Math.Round(_valubility * SellMargin, 0);
        Cost = _Cost;
    }


    public void CraftMe (List<string> inventory){
        bool craftable = true;
        for (int i = 0; i < Cost.Count; i++)
        {
            if (inventory.Contains(Cost[i]) != true){
                craftable = false;
            }    
            
        } 
        if (craftable == true){
                    for (int i = 0; i < Cost.Count; i++){
                        Console.WriteLine("you used a " + Cost[i] + ".");
                        inventory.Remove(Cost[i]);
                    }
                    Console.WriteLine("You crafted a " + name + "!");
                    inventory.Add(name);
        } else {
            Console.WriteLine("You do not heve enough items to craft a " + name + ".");
        }

    }

    
}