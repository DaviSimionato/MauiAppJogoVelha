namespace MauiAppJogoVelha // Define um novo namespace chamado MauiAppJogoVelha.
{
    public partial class App : Application // Declara a classe App que herda da classe Application, representando a aplicação MAUI.
    {
        public App() // Construtor da classe App.
        {
            InitializeComponent(); // Inicializa os componentes da aplicação definidos em XAML.

            MainPage = new AppShell(); // Define a página principal da aplicação como uma nova instância de AppShell.
        }
    }
}