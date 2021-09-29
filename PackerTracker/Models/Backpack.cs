using System.Collections.Generic;

    // Thing to buy/add - item in todolist, car in the dealership, bakery item in the bakery
    //item to put in the backpack
    // Thing to add it to - list of items, dealership itself, order _instances/_order/_cars List <type> ...  .Add
    //backpack

    //item is the item (whether to pack it or buy it)
    //backpack = vendor (thing to hold items)

namespace PackerTracker.Models
{
  public class Backpack
  {
    public string Thing { get; set; }
    public int Price { get; set; }
    public int Weight { get; set; }
    public bool Purchased { get; set; }
    public int Id { get; set; }

    private static List<Backpack> _instances = new List<Backpack> {};

    // private static List<Item> _instances = new List<Item> {};

    public Backpack (string thing)
    {
      Thing = thing;
      //Price = price;
      _instances.Add(this);
      // Id = _instances.Count;
    }

    public static List<Backpack> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    // public static Item Find(int searchId)
    // {
                  //good fail because the function doesn't do what it's supposed to do
                  // Item wrongItem = new Item("stuff");
                  // return wrongItem;
    //   return _instances[searchId-1];
    // }

    // public static void RemoveById(int id)
    // {
            /*
            index: 0 id: 
            */

      //count: 3
     // _instances.RemoveAt(id - 1);
              //count: 2

              //remove id 2
              //Count: 3
              //index: 
              //index: 
              //start at the next item, subtract one from each id in the list 

              // for (int index = id - 1; index < _instances.Count - 1; index++)
              // {
              //   _instances[index].Id = _instances[index].Id - 1;
              // }

              //Count: was 4, now 3
              //index: 0 set to id:1
              //index: 1 set to id:2
              //index: 2 set to id:3

      // for (int index = 0; index < _instances.Count; index++)
      // {
      //   _instances[index].Id = index + 1;
      // }
    // }

  }
}