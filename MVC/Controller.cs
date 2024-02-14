public class Controller : IController
{
	IModel model;
	IView view;

	public Controller(IModel model, IView view)
	{
		this.model = model;
		this.view = view;
	}

	public string Start()
	{
		DateTime dateTime;

		dateTime = model.ReadData();
		string output = view.Format(dateTime);

		return output;
	}
}
