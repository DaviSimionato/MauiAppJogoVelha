using System; // Importa o namespace básico do .NET.

namespace MauiAppJogoVelha // Define um novo namespace chamado MauiAppJogoVelha.
{
    public partial class MainPage : ContentPage // Declara a classe MainPage que herda de ContentPage, representando uma página de conteúdo.
    {
        string vez = "X"; // Variável que indica de quem é a vez (X ou O).
        int jogadas = 0; // Contador de jogadas realizadas.
        
        public MainPage() // Construtor da classe MainPage.
        {
            InitializeComponent(); // Inicializa os componentes da interface definidos em XAML.
        }

        private void Btn10_Clicked(object sender, EventArgs e) // Método chamado quando um botão é clicado.
        {
            Button btn = (Button)sender; // Converte o objeto sender para um botão.

            btn.IsEnabled = false; // Desabilita o botão clicado para evitar múltiplos cliques.
            jogadas++; // Incrementa o contador de jogadas.

            // Alterna a vez entre "X" e "O".
            if(vez == "X")
            {
                btn.Text = "X"; // Define o texto do botão como "X".
                vez = "O"; // Altera a vez para "O".
            }
            else
            {
                btn.Text = "O"; // Define o texto do botão como "O".
                vez = "X"; // Altera a vez para "X".
            } // Fechamento do else

            // Verificações de vitória para "X" nas linhas
            if(btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns 🏆", "O X ganhou", "Zerar"); // Exibe um alerta de vitória.
                Limpar(); // Chama o método Limpar para reiniciar o jogo.
            }
            // Verificações de vitória para "X" nas linhas
            if(btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Parabéns 🏆", "O X ganhou", "Zerar");
                Limpar();
            }
            // Verificações de vitória para "X" na terceira linha
            if(btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns 🏆", "O X ganhou", "Zerar");
                Limpar();
            }
            // Verificações de vitória para "O" nas linhas
            if(btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns 🏆", "O O ganhou", "Zerar");
                Limpar();
            }
            // Verificações de vitória para "O" nas linhas
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Parabéns 🏆", "O O ganhou", "Zerar");
                Limpar();
            }
            // Verificações de vitória para "O" na terceira linha
            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns 🏆", "O O ganhou", "Zerar");
                Limpar();
            }

            // Verificações de vitória para "X" nas colunas
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns 🏆", "O X ganhou", "Zerar");
                Limpar();
            }
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Parabéns 🏆", "O X ganhou", "Zerar");
                Limpar();
            }
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns 🏆", "O X ganhou", "Zerar");
                Limpar();
            }
            // Verificações de vitória para "O" nas colunas
            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns 🏆", "O O ganhou", "Zerar");
                Limpar();
            }
            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Parabéns 🏆", "O O ganhou", "Zerar");
                Limpar();
            }
            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns 🏆", "O O ganhou", "Zerar");
                Limpar();
            }

            // Verificações de vitória nas diagonais
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns 🏆", "O X ganhou", "Zerar");
                Limpar();
            }
            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns 🏆", "O O ganhou", "Zerar");
                Limpar();
            }
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns 🏆", "O X ganhou", "Zerar");
                Limpar();
            }
            if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns 🏆", "O O ganhou", "Zerar");
                Limpar();
            }

            // Verifica se houve empate após 9 jogadas
            if (jogadas == 9)
            {
                DisplayAlert("Empate", "Não teve vencedor", "Zerar");
                Limpar();
            }
        } // Fechamento do método Btn10_Clicked

        void Limpar() // Método para reiniciar o jogo.
        {
            // Limpa o texto dos botões
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            // Reabilita todos os botões
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            jogadas = 0; // Reseta o contador de jogadas.
            vez = "X"; // Reseta a vez para o jogador "X".
        }
    }
}