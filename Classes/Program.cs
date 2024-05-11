
public class Window
{
    private string name = "Test!";
    private int width = 1280;
    private int height = 720;

    public Window(string name, int width, int height)
    {   
        this.name = name;
        this.width = width;
        this.height = height;
    }

    public void printParams()
    {
        Console.WriteLine(name);
        Console.WriteLine(width);
        Console.WriteLine(height);
    }
}

class Program 
{
    static void Main(string[] args)
    {
        Window windowTest = new Window("Cool Test!", 500, 200);
        windowTest.printParams();
    }
}