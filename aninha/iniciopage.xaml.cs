using System.Security.Cryptography;

namespace aninha;

public partial class iniciopage : ContentPage
{

	public iniciopage()
	{
		InitializeComponent();	
	}
	
    void Button_Clicked(object sender, EventArgs e)
	{
       Application.Current.iniciopage.page = new meiopage();
    }
	void ButtonSobre_Clicked(object sender, EventArgs e)
    { 
       COMEÇARFrame.IsVisible = true;
    }
	void ButtonContinuar_Clicked(object sender, EventArgs e)
    { 
       ContinuarFrame.IsVisible = true;
	}
	
}
   