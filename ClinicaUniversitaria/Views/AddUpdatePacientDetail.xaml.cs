using ClinicaUniversitaria.ViewModels;

namespace ClinicaUniversitaria.Views;

public partial class AddUpdatePacientDetail : ContentPage
{
	public AddUpdatePacientDetail(AddUpdatePacientDetailViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}