namespace DiceRoller;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnClicked(object sender, EventArgs e)
	{
        Random contador = new Random();

        Console.WriteLine("Generating 10 random numbers:");

        for (uint ctr = 1; ctr <= 10; ctr++)
            Console.WriteLine($"{contador.Next(),15:N0}");

    }
}

