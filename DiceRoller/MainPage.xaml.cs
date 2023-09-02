namespace DiceRoller;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnClicked(object sender, EventArgs e)
	{
        Random rnd = new Random();

        Console.WriteLine("Generating 10 random numbers:");

        for (uint contador = 1; contador <= 10; contador++)
            Console.WriteLine($"{rnd.Next(),15:N0}");

    }
}

