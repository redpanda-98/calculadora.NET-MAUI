namespace sumaNum;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        try
        {
            float a = float.Parse(valor1.Text);
            float b = float.Parse(valor2.Text);
            float c = a + b;
            resultado.Text = a + "+" + b + "=" + c;
        }
        catch
        {
            resultado.Text = "Error al capturar los datos. Prueba ingresando números...";
        }
    }
}

