using System.Security.Cryptography.X509Certificates;

namespace DiceRoller;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    

    protected class Dado //Classe
    {

        private int NumerodeLados; //Atributo

        public Dado() //Construtor
        { }

        public Dado(int numerodeLados) //Metodo
        {
            NumerodeLados = numerodeLados;
        }

        public int RollDice()
        {
            int random =  new Random().Next(1, NumerodeLados + 1); ;
            return random;
        }
        
     
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {

        int NumerodeLados = (Int32)SeletorDosLados.SelectedItem; //Ler o numero que o usuario selecionou no Picker.
        Dado dado = new Dado(NumerodeLados);//Instancia um novo dado com N .Onde N é o número selecionado. // Chamar o método para sortear o número.
        numberOutput.Text = dado.RollDice().ToString();//Mostrar o número no label.


    }


        /*int min = 1;
        var numeroSelecionado = picker.SelectedItem;
        
        int max = int.Parse(numeroSelecionado.ToString()) + 1;

        Random random = new Random();

        int numeroGerado = random.Next(min, max);
        numberOutput.Text = numeroGerado.ToString();*/


        /*código referencia para adicionar tema*/

       public void OnChangeOption(object sender, EventArgs e)
        {
            int NumerodeLados = (int)SeletorDosLados.SelectedItem;
            Image image = new Image { Source = $"dice_d (NumerodeLados).png" };
            diceImage.Source = image.Source;
        }

      /*  AppTheme currentTheme = Application.Current.RequestedTheme;
        if(currentTheme.ToString() != "Unspecified")
        { 
            diceImage.Source = ImageSource.FromFile($"{currentTheme}_dice_d{NumerodeLados}.png"); 
        }
        else
        {
            diceImage.Source = ImageSource.FromFile($"dice_d{NumerodeLados}.png");
        }*/


    }

