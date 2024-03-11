using System.Security.Cryptography;

namespace aninha;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();	
	}

	void Button_Clicked(object sender, EventArgs e)
    { 
       Application.Current.MainPage=new iniciopage();
    }
    void roupa(object sender, EventArgs e)
	{
		Application.Current.MainPage=new iniciopage();
	}
}

