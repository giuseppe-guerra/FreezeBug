namespace FreezeBug.Components;

public partial class ParameterComponent : ContentView
{
    public string Name 
    { 
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }

    public int Value 
    { 
        get => (int)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }


    public ParameterComponent()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty NameProperty = 
        BindableProperty.Create("Name", typeof(string), typeof(ParameterComponent), string.Empty);

    public static readonly BindableProperty ValueProperty =
        BindableProperty.Create("Value", typeof(int), typeof(ParameterComponent), 0);
}