using ClinicaUniversitaria.Models;
using ClinicaUniversitaria.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaUniversitaria.Services
{
	public class PacientService : IPacientService
	{
		private SQLiteAsyncConnection _dbconnection;
		public PacientService() 
		{
			SetUpDb();
		}


		private async void SetUpDb()
		{
				if (_dbconnection == null)
				{
					string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Pacient.db");
					_dbconnection = new SQLiteAsyncConnection(dbPath);
					await _dbconnection.CreateTableAsync<PacientModel>();
				}
		}



		public Task<int> AddPacient(PacientModel pacientModel)
		{
			return _dbconnection.InsertAsync(pacientModel);
		}

		public Task<int> DeletePacient(PacientModel pacientModel)
		{
			return _dbconnection.DeleteAsync(pacientModel);
		}

		public Task<int> UpdatePacient(PacientModel pacientModel)
		{
			return _dbconnection.UpdateAsync(pacientModel);
		}


		public async Task<List<PacientModel>> GetPacientList()
		{
			var PacientList = await _dbconnection.Table<PacientModel>().ToListAsync();
			return PacientList;
		}

		public Task<bool> AddPacient()
		{
			throw new NotImplementedException();
		}
	}
}

