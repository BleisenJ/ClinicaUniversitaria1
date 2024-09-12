using ClinicaUniversitaria.Services;
using ClinicaUniversitaria.ViewModels;
using ClinicaUniversitaria.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ClinicaUniversitaria
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

#if DEBUG
			builder.Logging.AddDebug();
#endif
			//Aqui van los Servicios
			builder.Services.AddSingleton<IPacientService, PacientService>();

			//Aqui va la Vista de los Registros
			builder.Services.AddSingleton<PacientListPage>();
			builder.Services.AddTransient<AddUpdatePacientDetail>();

			//Aqui va la Vista del Models
			builder.Services.AddSingleton<PacientListPageViewModel>();
			builder.Services.AddTransient<AddUpdatePacientDetailViewModel>();


			return builder.Build();
		}
	}
}
