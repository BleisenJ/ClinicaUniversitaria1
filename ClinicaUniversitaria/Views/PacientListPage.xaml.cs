using ClinicaUniversitaria.ViewModels;

namespace ClinicaUniversitaria.Views;

public partial class PacientListPage : ContentPage
{
	private PacientListPageViewModel _viewModel;
	public PacientListPage(PacientListPageViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		this.BindingContext = viewModel;
	}


	protected override void OnAppearing()
	{
		base.OnAppearing();
		_viewModel.GetPacientListCommand.Execute(null);
	}
}