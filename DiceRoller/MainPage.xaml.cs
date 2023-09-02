namespace DiceRoller;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	using System;
using Xamarin.Forms;

namespace SeuNamespace
{
    public partial class SuaPagina : ContentPage
    {
        public SuaPagina()
        {
            InitializeComponent();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            // Obtém o valor selecionado no Picker (quantidade de lados do dado)
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

