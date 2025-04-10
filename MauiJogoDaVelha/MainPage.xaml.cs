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

            /* Verifdicando se X ganhou na primeira linha*/

            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabens", "O X GANHOU!", "ok");
                Zerar(); // Limpando botões
            }


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
        }

        private void Limpar_Clicked(object sender, EventArgs e)
        {

        }
    }
}