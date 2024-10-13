// Creating Stock NVDA with 500 shares owned
Stock nvda = new Stock { Name = "NVDA", SharesOwned = 500 };

Console.WriteLine("Stock: " + nvda.Name);         
Console.WriteLine("Shares: " + nvda.SharesOwned);  

//Inheritance Concept 
public class Asset
{
    public string Name;
}
public class Stock : Asset   // inherits from Asset
{
    public long SharesOwned;
};


