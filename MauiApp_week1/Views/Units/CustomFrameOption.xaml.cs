namespace MauiApp_week1.Views.Units;

public partial class CustomFrameOption : ContentView
{
	public string Name
	{
		get { return (string)GetValue(NameProperty); }
		set { SetValue(NameProperty, value); }
	}

	// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
	public static readonly BindableProperty NameProperty =
            BindableProperty.Create("Name", typeof(string), typeof(CustomFrameOption));


	public CustomFrameOption()
	{
		InitializeComponent();
	}
}