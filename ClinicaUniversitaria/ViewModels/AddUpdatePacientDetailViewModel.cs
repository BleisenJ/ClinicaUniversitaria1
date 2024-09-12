using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaUniversitaria.Models;
using ClinicaUniversitaria.Services;
using ClinicaUniversitaria.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace ClinicaUniversitaria.ViewModels
{
	[QueryProperty(nameof(PacientDetail), "PacientDetail")]
	public partial class AddUpdatePacientDetailViewModel : ObservableObject
	{

		[ObservableProperty]
		private PacientModel _pacientDetail = new PacientModel();


		private readonly IPacientService _pacientService;

        public AddUpdatePacientDetailViewModel(IPacientService pacientService)
        {
			_pacientService = pacientService;

		}


		[ICommand]
		public async void AddUpdateStudent()
		{
			int response = -1;
			if(PacientDetail.PacientID >0)
			{
				response = await _pacientService.UpdatePacient(PacientDetail);
			}
            else
            {
				response = await _pacientService.AddPacient(new Models.PacientModel
				{
					Name = PacientDetail.Name,
					Mail = PacientDetail.Mail,
					Number = PacientDetail.Number,
					Birth = PacientDetail.Birth,
					Rol = PacientDetail.Rol
				});
			}
            

			if (response > 0)
			{
				await Shell.Current.DisplayAlert("Informacion del Paciente añadido", "Informacion añadida a la tabla de paciente", "Ok");
			}
			else
			{
				await Shell.Current.DisplayAlert("Aviso!", "Algo paso que no guardo :c", "Ok");
			}
		}
	}
}
