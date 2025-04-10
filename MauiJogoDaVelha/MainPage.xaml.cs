using Microsoft.Maui.Controls.Shapes;

namespace MauiJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";


        public MainPage()
        {
            InitializeComponent();
        }

        // ------ BOTÕES ------ \\
        // Checando se foi colocado X ou O e quem ganhou
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            //Quando iniciado a variavel vez inicia com X
            //Então se a variavel for = a X ele tranforma vez para O
            //Depois ela troca para 0 e troca novamente para X

            if (vez == "X") //Checa se vez é X
            {
                btn.Text = "X"; // tranforma vez em X
                vez = "O"; // tranforma vez em O

            }
            else if (vez == "O")//Checa se vez é O
            {
                btn.Text = "O"; // tranforma vez em O
                vez = "X";  // tranforma vez em X
            }

            Ganhando();

        }

        // -- Limpar Campos
        private void Limpar_Clicked(object sender, EventArgs e)
        {
            Zerar();
        }


        //Metodo para Limpar botões e deixar clivavel
        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            vez = "X";
        }

        void Ganhando()
        {
            // Verificando se o X ganhou em Linhas
            //  se X ganhou na Primeira linha //
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabens", "O X GANHOU!", "ok");
                Zerar(); // Limpando botões
            }
            // se X ganhou na Segunda linha //
            else if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Parabens", "O X GANHOU!", "ok");
                Zerar(); // Limpando botões
            }
            // se X ganhou na Terceira linha //
            else if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabens", "O X GANHOU!", "ok");
                Zerar(); // Limpando botões  
            }

            // ----------------------------------------------------------------------------- \\
            // Verificando se X ganhou em Colunas
            // se X ganhou na Coluna 1
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabens", "O X GANHOU!", "ok");
                Zerar(); // Limpando botões 
            }
            // se X ganhou na Coluna 2
            else if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Parabens", "O X GANHOU!", "ok");
                Zerar(); // Limpando botões
            }
            // se X ganhou na Coluna 3
            else if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabens", "O X GANHOU!", "ok");
                Zerar(); // Limpando botões
            }

            // ----------------------------------------------------------------------------- \\
            // Verificando se X ganhou nas diagonais
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabens", "O X GANHOU!", "ok");
                Zerar(); // Limpando botões 
            }
            else if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabens", "O X GANHOU!", "ok");
                Zerar(); // Limpando botões 
            }



            // Verificando se o O ganhou em Linhas
            //  se O ganhou na Primeira linha //
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabens", "O O GANHOU!", "ok");
                Zerar(); // Limpando botões
            }
            // se X ganhou na Segunda linha //
            else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Parabens", "O O GANHOU!", "ok");
                Zerar(); // Limpando botões
            }
            // se X ganhou na Terceira linha //
            else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabens", "O O GANHOU!", "ok");
                Zerar(); // Limpando botões  
            }

            // ----------------------------------------------------------------------------- \\
            // Verificando se O ganhou em Colunas
            // se O ganhou na Coluna 1
            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabens", "O O GANHOU!", "ok");
                Zerar(); // Limpando botões 
            }
            // se O ganhou na Coluna 2
            else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Parabens", "O O GANHOU!", "ok");
                Zerar(); // Limpando botões
            }
            // se O ganhou na Coluna 3
            else if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabens", "O O GANHOU!", "ok");
                Zerar(); // Limpando botões
            }

            // Verificando se O ganhou nas diagonais
            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabens", "O O GANHOU!", "ok");
                Zerar(); // Limpando botões 
            }
            else if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabens", "O X GANHOU!", "ok");
                Zerar(); // Limpando botões 
            }
        }
    }
}