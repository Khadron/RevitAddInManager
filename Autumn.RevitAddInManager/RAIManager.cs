using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.RevitAddIns;
using Autumn.RevitAddInManager.Model;

namespace Autumn.RevitAddInManager
{
	public class RAIManager
	{

		public static string CreateManifest(string addinName, string version, AddInCmdInfo cmdInfo, AddInAppInfo appInfo)
		{
			string manifestFilePath = string.Format("{0}\\{1}\\{2}.addin", SystemVariables.RevitProgramDataPath, version, addinName);

			try {

				RevitAddInManifest revitAddInManifest = AddInManifestUtility.GetRevitAddInManifest(manifestFilePath);

				var cmds = revitAddInManifest.AddInCommands;
				var apps = revitAddInManifest.AddInApplications;

				for(int i = 0; i < cmds.Count; i++) {

					var cmd = cmds[i];
					if(cmd.AddInId.ToString() != cmdInfo.AddInId) {
						revitAddInManifest.AddInCommands.Add(CreateRevitAddInCmd(cmdInfo));
					} else {
						cmd.VendorId = cmdInfo.VendorId;
						cmd.VendorDescription = cmdInfo.VendorDescription;
						cmd.Description = cmdInfo.Description;
						cmd.Text = cmdInfo.Text;
						cmd.FullClassName = cmdInfo.FullClassName;
						cmd.Discipline = cmdInfo.Discipline;
						cmd.VisibilityMode = cmdInfo.VisibilityMode;
						cmd.AvailabilityClassName = cmdInfo.AvailabilityClassName;
						cmd.AllowLoadIntoExistingSession = cmdInfo.AllowLoadIntoExistingSession;
					}
				}

				for(int i = 0; i < apps.Count; i++) {

					var app = apps[i];
					if(app.AddInId.ToString() != appInfo.AddInId) {
						revitAddInManifest.AddInApplications.Add(CreateRevitAddInApp(appInfo));
					} else {
						app.Name = appInfo.Name;
						app.VendorId = appInfo.VendorId;
						app.VendorDescription = appInfo.VendorDescription;
						app.FullClassName = appInfo.FullClassName;
						app.AllowLoadIntoExistingSession = appInfo.AllowLoadIntoExistingSession;
					}
				}
				revitAddInManifest.Save();

			}
			catch {

				try {

					RevitAddInManifest manifest = new RevitAddInManifest();

					if(cmdInfo != null) {

						RevitAddInCommand myCmd = CreateRevitAddInCmd(cmdInfo);
						manifest.AddInCommands.Add(myCmd);
					}

					if(appInfo != null) {

						RevitAddInApplication myApp = CreateRevitAddInApp(appInfo);
						manifest.AddInApplications.Add(myApp);
					}

					//RevitProduct newRevitProduct = RevitProductUtility.GetAllInstalledRevitProducts()[0];
					//string manifestFilePath = string.Format("{0}\\{1}", newRevitProduct.AllUsersAddInFolder, addinName);
					manifest.SaveAs(manifestFilePath);
				}
				catch(Exception ex) {

					return ex.Message;
				}

			}

			return "创建成功";
		}

		private static RevitAddInApplication CreateRevitAddInApp(AddInAppInfo appInfo)
		{
			RevitAddInApplication myApp = new RevitAddInApplication(appInfo.Name, appInfo.Assembly, new Guid(appInfo.AddInId), appInfo.FullClassName, appInfo.VendorId);
			myApp.VendorDescription = appInfo.VendorDescription;
			return myApp;
		}

		private static RevitAddInCommand CreateRevitAddInCmd(AddInCmdInfo cmdInfo)
		{
			RevitAddInCommand myCmd = new RevitAddInCommand(cmdInfo.Assembly, new Guid(cmdInfo.AddInId), cmdInfo.FullClassName, cmdInfo.VendorId);
			myCmd.Description = cmdInfo.Description;
			myCmd.Text = cmdInfo.Text;
			myCmd.FullClassName = cmdInfo.FullClassName;
			myCmd.Discipline = cmdInfo.Discipline;//在什么样的程序模式下的命令按钮显示，程序命令模式如结构、设备……
			myCmd.VisibilityMode = cmdInfo.VisibilityMode;//在文档模式改变时命令按钮显示的方式
			myCmd.AvailabilityClassName = cmdInfo.AvailabilityClassName;//验证程序名称
			myCmd.AllowLoadIntoExistingSession = cmdInfo.AllowLoadIntoExistingSession;
			myCmd.VendorDescription = cmdInfo.VendorDescription;
			return myCmd;
		}

	}
}
