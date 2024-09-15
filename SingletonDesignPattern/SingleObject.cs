namespace SingletonDesignPattern;

public class SingleObject
{
    private static SingleObject? instance = null;
	private SingleObject()
	{
	}
	public static SingleObject getInstance()
	{
        instance ??= new SingleObject();
		return instance;
	}

	/// <summary>
	/// return the message 
	/// </summary>
    public void ShowMessage() => Console.WriteLine("Single Instance");
}