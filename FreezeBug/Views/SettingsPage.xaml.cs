using FreezeBug.ViewModels;

namespace FreezeBug.Views;

public partial class SettingsPage : ContentPage
{
    private readonly SettingsViewModel viewModel;

    public SettingsPage()
	{
        InitializeComponent();

        this.viewModel = new SettingsViewModel();

        InitializeViewModel();

        BindingContext = viewModel;
    }

     private void InitializeViewModel()
    {
        viewModel.MinValue = new Models.Setting();
        viewModel.MinValue.Name = "Min Value";
        viewModel.MinValue.Value = 0;

        viewModel.MaxValue = new Models.Setting();
        viewModel.MaxValue.Name = "Max Value";
        viewModel.MaxValue.Value = 100;

        viewModel.PrimaryValue = new Models.Setting();
        viewModel.PrimaryValue.Name = "Primary Value";
        viewModel.PrimaryValue.Value = 75;

        viewModel.SecondaryValue = new Models.Setting();
        viewModel.SecondaryValue.Name = "Secondary Value";
        viewModel.SecondaryValue.Value = 42;

        viewModel.CrashValue = new Models.Setting();
        viewModel.CrashValue.Name = "Crash Value";
        viewModel.CrashValue.Value = 99;

        viewModel.WarningValue = new Models.Setting();
        viewModel.WarningValue.Name = "Warning Value";
        viewModel.WarningValue.Value = 97;
    }
}