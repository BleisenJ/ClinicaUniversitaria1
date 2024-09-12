using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaUniversitaria.Models
{
	public class PacientModel
	{
		[PrimaryKey, AutoIncrement]
		public int PacientID { get; set; }
		public string Name { get; set; }
		public string Mail { get; set; }
		public int Number {  get; set; }
		public DateTime Birth { get; set; }
		public string Rol {  get; set; }
	}
}
