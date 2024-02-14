
class MVCInterfaces
{
    static void Main()
    {
        IModel model = new ModelDateTime();
        IView view = new ViewDateTime();
        IController controller = new Controller(model, view); 

        Console.WriteLine(controller.Start());
    }
}
