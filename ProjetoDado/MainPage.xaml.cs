namespace ProjetoDado
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void RolarDadoButton_Clicked(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
         //   int numeroSorteado = aleatorio.Next(1, 101);
        //    ResultadoLabel.Text = numeroSorteado.ToString();
            // DadoImage.Source = $"dado{numeroSorteado}.png";
            List<int> numerosEspecificos = new List<int> { 4, 6, 8, 10, 12, 20, 100 };
            int indiceAleatorio = aleatorio.Next(0, numerosEspecificos.Count);
            int numeroSorteado = numerosEspecificos[indiceAleatorio];
           ResultadoLabel.Text = $"{numeroSorteado}";
           







        }
    }
}
