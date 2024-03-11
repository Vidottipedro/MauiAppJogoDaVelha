namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";
        public MainPage()
        {
            InitializeComponent();
        }

private void btn_Clicked(object sender, EventArgs e)
        {

            Button disparador = (Button)sender;
             
            disparador.IsEnabled = false;

            if(vez == "O")
            {
                disparador.Text = "O";
                vez = "X";
            }
            else
            {
                disparador.Text = "X";
                vez = "O";
            }

            if (btn10.Text == "X"
                && btn11.Text == "X"
                && btn12.Text == "X")
            {
                DisplayAlert("Parabens!", "O X ganhou!", "OK");
                limpar();
            }

            { 
            }

            if (btn20.Text == "X"
                && btn21.Text == "X"
                && btn22.Text == "X")

            {
                DisplayAlert("Parabens!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn30.Text == "X"
                && btn31.Text == "X"
                && btn32.Text == "X")

            {
                DisplayAlert("Parabens!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn30.Text == "X"
                && btn20.Text == "X"
                && btn10.Text == "X")
            {
                DisplayAlert("Parabens!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn31.Text == "X"
                && btn21.Text == "X"
                && btn11.Text == "X")

            {
                DisplayAlert("Parabens!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn32.Text == "X"
                && btn22.Text == "X"
                && btn12.Text == "X")

            {
                DisplayAlert("Parabens!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn30.Text == "X"
                && btn21.Text == "X"
                && btn12.Text == "X")

            {
                DisplayAlert("Parabens!", "O X ganhou!", "OK");
                limpar();
            }

            if (btn32.Text == "X"
                && btn21.Text == "X"
                && btn10.Text == "X")

            {
                DisplayAlert("Parabens!", "O X ganhou!", "OK");
                limpar();
            }

            // O ganhou

            if (btn10.Text == "O"
                && btn11.Text == "O"
                && btn12.Text == "O")
            {
                DisplayAlert("Parabens!", "O O ganhou!", "OK");
                limpar();
            }

            if (btn20.Text == "O"
                && btn21.Text == "O"
                && btn22.Text == "O")

            {
                DisplayAlert("Parabens!", "O O ganhou!", "OK");
                limpar();
            }

            if (btn30.Text == "O"
                && btn31.Text == "O"
                && btn32.Text == "O")

            {
                DisplayAlert("Parabens!", "O O ganhou!", "OK");
                limpar();
            }

            if (btn30.Text == "O"
                && btn20.Text == "O"
                && btn10.Text == "O")
            {
                DisplayAlert("Parabens!", "O O ganhou!", "OK");
                limpar();
            }

            if (btn31.Text == "O"
                && btn21.Text == "O"
                && btn11.Text == "O")

            {
                DisplayAlert("Parabens!", "O O ganhou!", "OK");
                limpar();
            }

            if (btn32.Text == "O"
                && btn22.Text == "O"
                && btn12.Text == "O")

            {
                DisplayAlert("Parabens!", "O O ganhou!", "OK");
                limpar();
            }

            if (btn30.Text == "O"
                && btn21.Text == "O"
                && btn12.Text == "O")

            {
                DisplayAlert("Parabens!", "O O ganhou!", "OK");
                limpar();
            }

            if (btn32.Text == "O"
                && btn21.Text == "O"
                && btn10.Text == "O")

            {
                DisplayAlert("Parabens!", "O O ganhou!", "OK");
                limpar();
            }

        }

        private void limpar()
        {
            btn10.Text = "";
            btn10.IsEnabled = true;
            btn11.Text = "";
            btn11.IsEnabled = true;
            btn12.Text = "";
            btn12.IsEnabled = true;

            btn20.Text = "";
            btn20.IsEnabled = true;
            btn21.Text = "";
            btn21.IsEnabled = true;
            btn22.Text = "";
            btn22.IsEnabled = true;

            btn30.Text = "";
            btn30.IsEnabled = true;
            btn31.Text = "";
            btn31.IsEnabled = true;
            btn32.Text = "";
            btn32.IsEnabled = true;

        }
    }

}
