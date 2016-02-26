using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.RevitAddIns;
using Autumn.RevitAddInManager.Model;

namespace Autumn.RevitAddInManager
{
	public partial class FrmMain : Form
	{

		private int _frmWidth;
		private int _frmHeight;
		private int _flpWidth;
		private int _flpHeight;

		public FrmMain()
		{
			InitializeComponent();
			_frmHeight = this.Height;
			_frmWidth = this.Width;
			_flpWidth = this.flpContainer.Width;
			_flpHeight = this.flpContainer.Height;
			InitForm();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AddInCmdInfo cmdInfo = null;
			AddInAppInfo appInfo = null;
			var selectedItem = cbxSchema.SelectedItem.ToString();
			if(ExternalSchema.外部命令.ToString() == selectedItem) {
				cmdInfo = PackCmdInfo();
			} else if(ExternalSchema.外部程序.ToString() == selectedItem) {
				appInfo = PackAppInfo();
			} else {

				cmdInfo = PackCmdInfo();
				appInfo = PackAppInfo();
			}

			string result = RAIManager.CreateManifest(txtAddInName.Text, cbxVersion.SelectedItem.ToString().Replace("Revit", ""), cmdInfo, appInfo);
			MessageBox.Show(result, "系统提示");
		}


		private void btnSelect_Click(object sender, EventArgs e)
		{
			SelectDllPath();
		}

		private void btnCmdSelect_Click(object sender, EventArgs e)
		{
			SelectDllPath(true);
		}

		private void InitForm()
		{
			string[] schemaName = Enum.GetNames(typeof(ExternalSchema));
			cbxSchema.Items.AddRange(schemaName);

			string[] version = Enum.GetNames(typeof(RevitVersion));
			cbxVersion.Items.AddRange(version);
			cbxVersion.SelectedIndex = version.Length - 2;

			string[] scope = Enum.GetNames(typeof(Discipline));
			chkLBScope.Items.AddRange(scope);
			chkLBScope.SelectedIndex = 0;

			string[] visibleMode = Enum.GetNames(typeof(VisibilityMode));
			cbxVisibleMode.Items.AddRange(visibleMode);
			cbxVisibleMode.SelectedIndex = 0;

			SetTextBoxEvent(this);
		}

		private void SetTextBoxEvent(Control ctrl)
		{
			if(ctrl.GetType() == typeof(TextBox)) {
				ctrl.Click += ctl_Click;
			} else {

				if(ctrl.HasChildren) {
					foreach(Control ctl in ctrl.Controls) {

						SetTextBoxEvent(ctl);
					}
				}
			}
		}

		void ctl_Click(object sender, EventArgs e)
		{
			var textBox = sender as TextBox;
			if(textBox != null && string.IsNullOrEmpty(textBox.Text) == false) {
				textBox.SelectAll();
			}
		}

		private void SelectDllPath(bool isCmd = false)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Title = isCmd ? "选择扩展命令dll" : "选择扩展程序dll";
			ofd.ValidateNames = true;
			ofd.AddExtension = true;
			ofd.InitialDirectory = "";
			ofd.Filter = "程序集文件(*.dll)|*.dll|所有文件(*.*)|*.*";

			if(ofd.ShowDialog() == DialogResult.OK) {

				if(isCmd)
					txtCmdDllPath.Text = ofd.FileName;
				else
					txtAppDllPath.Text = ofd.FileName;
			}

		}

		//private AddInInfo CreateModel(bool? state)
		//{

		//	if(state.HasValue) {

		//	} else {


		//	}
		//	AddInCmdInfo cmdInfo = null;
		//	AddInAppInfo appInfo = null;
		//	var selectedItem = cbxSchema.SelectedItem.ToString();
		//	if(ExternalSchema.外部命令.ToString() == selectedItem) {
		//		cmdInfo = PackCmdInfo();
		//	} else if(ExternalSchema.外部程序.ToString() == selectedItem) {
		//		appInfo = PackAppInfo();
		//	} else {

		//		cmdInfo = PackCmdInfo();
		//		appInfo = PackAppInfo();
		//	}
		//}

		private AddInCmdInfo PackCmdInfo()
		{
			AddInCmdInfo cmd = new AddInCmdInfo();
			cmd.AddInId = txtCmdGuid.Text;
			cmd.AllowLoadIntoExistingSession = chkBxAtuoLoad.Checked;
			cmd.Assembly = txtCmdDllPath.Text;
			cmd.AvailabilityClassName = txtCmdAvailability.Text;
			cmd.FullClassName = txtCmdAssemblyFullName.Text;
			cmd.LanguageType = LanguageType.Chinese_Simplified;
			cmd.Text = txtCmdName.Text;
			cmd.Description = txtCmdDescription.Text;
			cmd.Discipline = GetDisciplineVal();
			cmd.VisibilityMode = (VisibilityMode)Enum.Parse(typeof(VisibilityMode), cbxVisibleMode.SelectedItem.ToString());
			cmd.VendorId = txtVendorId.Text;
			cmd.VendorDescription = txtVendorDescription.Text;
			return cmd;
		}

		private AddInAppInfo PackAppInfo()
		{
		    AddInAppInfo app = new AddInAppInfo
		    {
		        AddInId = txtAppGuid.Text,
		        AllowLoadIntoExistingSession = chkBxAtuoLoad.Checked,
		        Assembly = txtAppDllPath.Text,
		        Name = txtAppName.Text,
		        FullClassName = txtAppAssemblyFullName.Text,
		        VendorId = txtVendorId.Text,
		        VendorDescription = txtVendorDescription.Text
		    };
		    return app;
		}

		private Discipline GetDisciplineVal()
		{
			int result = 0;

			if(chkLBScope.SelectedItem.ToString() == Discipline.Any.ToString()) {
				result = 0;
			} else {
				foreach(string item in chkLBScope.CheckedItems) {
					result |= (int)Enum.Parse(typeof(Discipline), item);
				}
			}

			return (Discipline)result;
		}

		private void chkLBScope_SelectedValueChanged(object sender, EventArgs e)
		{
			var chkList = sender as CheckedListBox;

			string selectedItem = chkList.SelectedItem.ToString();
			if(selectedItem == Discipline.Any.ToString()) {

				int index = chkList.SelectedIndex;
				bool state = chkList.GetItemChecked(index);

				for(int i = 0; i < chkList.Items.Count; i++) {
					chkList.SetItemChecked(i, state);
				}

			} else {
				int anyIndex = 0;

				if(chkList.Items.Count - 1 == chkList.CheckedItems.Count
					&& !chkList.GetItemChecked(anyIndex)) {
					chkList.SetItemChecked(anyIndex, true);
				} else {
					chkList.SetItemChecked(anyIndex, false);
				}

			}
		}

		private void cbxSchema_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = cbxSchema.SelectedIndex;
			switch(index) {
				case 0:
					grgApp.Hide();
					grgCmd.Show();
					//this.flpContainer.Size = new Size(this.flpContainer.Width, flpHeight - grgApp.Height);
					//this.Size = new Size(this.Width, frmHeight - grgApp.Height);
					break;
				case 1:
					grgCmd.Hide();
					grgApp.Show();
					//this.flpContainer.Size = new Size(this.flpContainer.Width, flpHeight - grgCmd.Height);
					//this.Size = new Size(this.Width, frmHeight - grgCmd.Height);
					break;
				default:
					grgCmd.Show();
					grgApp.Show();
					//this.flpContainer.Size = new Size(this.Width, flpHeight);
					//this.Size = new Size(this.Width, frmHeight);

					break;
			}
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			cbxSchema.SelectedIndex = 2;
		}

		private void btnCmdNewGuid_Click(object sender, EventArgs e)
		{
			txtCmdGuid.Text = Guid.NewGuid().ToString();
		}

		private void btnAppNewGuid_Click(object sender, EventArgs e)
		{
			txtAppGuid.Text = Guid.NewGuid().ToString();
		}
	}
}
