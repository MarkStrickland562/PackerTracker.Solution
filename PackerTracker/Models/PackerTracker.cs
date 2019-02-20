using System.Collections.Generic;
namespace PackerTracker.Models
{
  public class Tracker
  {
    private string _myItemName;
    private int _myPrice;
    private int _myWeight;
    private bool _myPurchased;
    private string _myManufacturer;
    private bool _myPacked;
    private int _id;
    private static List<Tracker> _instances = new List<Tracker> {};

    // Constructor for creating an instance of the PackerTracker class.

    public Tracker (string myItemName, int myPrice, int myWeigth, bool myPurchased, string myManufacturer, bool myPacked)
    {
      _myItemName = myItemName;
      _myPrice = myPrice;
      _myWeight = myWeigth;
      _myPurchased = myPurchased;
      _myManufacturer = myManufacturer;
      _myPacked = myPacked;
      _instances.Add(this);
      _id = _instances.Count;
    }

    // Getter method for the PackerTracker class.

    public string GetItemName(){ return _myItemName;}
    public int GetPrice(){ return _myPrice;}
    public int GetWeight(){ return _myWeight;}
    public bool GetPurchased(){ return _myPurchased;}
    public string GetManufacturer(){ return _myManufacturer;}
    public bool GetPacked(){ return _myPacked;}

    // Setter method for the PackerTracker class.

    public void SetItemName(string newItemName){ _myItemName = newItemName;}
    public void SetPrice(int newPrice){ _myPrice = newPrice;}
    public void SetWeight(int newWeight){ _myWeight = newWeight;}
    public void SetPurchased(bool newPurchased){ _myPurchased = newPurchased;}
    public void SetManufacturer(string newManufacturer){ _myManufacturer = newManufacturer;}
    public void SetPacked(bool newPacked){ _myPacked = newPacked;}

    public static List<Tracker> GetAll()
    {
      return _instances;
    }

    public int GetId()
    {
      return _id;
    }

    public static Tracker Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
