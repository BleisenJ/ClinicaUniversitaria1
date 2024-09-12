using ClinicaUniversitaria.Views;

namespace ClinicaUniversitaria
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();

			Routing.RegisterRoute(nameof(AddUpdatePacientDetail), typeof(AddUpdatePacientDetail));
		}
	}
}
