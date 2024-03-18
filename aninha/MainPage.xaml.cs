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
       Application.Current.MainPage = new iniciopage();
    }
	void ButtonSobre_Clicked(object sender, EventArgs e)
    { 
       SobreFrame.IsVisible = true;
    }
 
	void ButtonVoltar_Clicked(object sender, EventArgs e)
    { 
       SobreFrame.IsVisible = true;
    }
    void ButtonVoltarMenu(object sender, EventArgs e)
    { 
       SobreFrame.IsVisible = false;
    }
}
   

