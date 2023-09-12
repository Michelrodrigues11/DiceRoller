namespace DiceRoller;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    

    protected class Dado
    {

        public Dado()
        { }

        public Dado(int numerodeLados)
        {
            NumerodeLados = numerodeLados;
        }

        private int NumerodeLados;

        public int RollDice()
        {
            int ramdom =  new Random().Next(1, NumerodeLados + 1); ;
            return ramdom;
        }
        
     
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {

        int NumerodeLados = (Int32)SeletorDosLados.SelectedItem;
        Dado dado= new Dado(NumerodeLados);
        numberOutput.Text = dado.RollDice().ToString();






        /*int min = 1;
        var numeroSelecionado = picker.SelectedItem;
        
        int max = int.Parse(numeroSelecionado.ToString()) + 1;

        Random random = new Random();

        int numeroGerado = random.Next(min, max);
        numberOutput.Text = numeroGerado.ToString();*/

        /*código referencia para adicionar tema
          
        AppTheme currentTheme = Application.Current.RequestedTheme;
        if(currentTheme.ToString() != "Unspecified")
        { 
            diceImage.Source = ImageSource.FromFile($"{currentTheme}_dice_d{NumerodeLados}.png"); 
        }
        else
        {
            diceImage.Source = ImageSource.FromFile($"dice_d{NumerodeLados}.png");
        }*/


    }
}
