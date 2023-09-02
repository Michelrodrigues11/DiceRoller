using System;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClicked(object sender, EventArgs e)
        {
           
            if (int.TryParse(picker.SelectedItem.ToString(), out int numeroDeLados))
            {
                
                Random random = new Random();
                int resultado = random.Next(1, numeroDeLados + 1);

               
                contador.Text = resultado.ToString();
            }
            else
            {
               
                contador.Text = "Erro";
            }
        }
    }
}

}

