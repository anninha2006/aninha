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
       Application.Current.MainPage=new iniciopage();
    }
	void ButtonCOMEÇAR_Clicked(object sender, EventArgs e)
    { 
       COMEÇARFrame.IsVisible = true;
    }
 
	void ButtonContinuar_Clicked(object sender, EventArgs e)
    { 
       ContinuarFrame.IsVisible = true;
    }
}
   