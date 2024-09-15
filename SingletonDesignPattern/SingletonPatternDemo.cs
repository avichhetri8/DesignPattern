
namespace SingletonDesignPattern
{
    public class SingletonPatternDemo
    {
        public static void Main(string[] args)
        {
/*
            SingleObject singleObject = new SingleObject();
            ErrorEventArgs will occurs because contructor is private
*/
            SingleObject singleObject = SingleObject.getInstance();
            singleObject.ShowMessage();
        }
    }
}