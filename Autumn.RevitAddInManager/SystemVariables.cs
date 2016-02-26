using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autumn.RevitAddInManager
{
	public class SystemVariables
	{
		public static string ManifestFileName = "MyFirst.addin";

		public static string RevitProgramDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Autodesk\\Revit\\Addins";
	}
}
