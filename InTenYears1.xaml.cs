namespace InTenYears2;

public partial class InTenYears1 : ContentPage
{
	public InTenYears1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		int age;
		if (!int.TryParse(lblAge.Text, out age))
		{
			lblResult.Text = "Enter a valid age";
			return;
		}	
		lblResult.Text ="Hi " + lblName.Text + "! in ten years you will be " + (age+10).ToString() + " years old";
    }
}