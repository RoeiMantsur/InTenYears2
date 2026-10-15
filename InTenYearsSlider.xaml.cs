namespace InTenYears2;

public partial class InTenYearsSlider : ContentPage
{
	public InTenYearsSlider()
	{
		InitializeComponent();
	}


    private void DragCompleted(object sender, EventArgs e)
    {
        int age = 10 + (int)SliderChanged.Value;
        lblResult.Text = "Hi " + lblName.Text + "! in ten years you will be " + (age).ToString() + " years old";
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lblAge.Text = ((int)SliderChanged.Value).ToString();
    }
}