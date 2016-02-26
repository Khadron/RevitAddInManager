namespace Autumn.RevitAddInManager.Model
{
	public class AddInInfo
	{
		/// <summary>
		/// 程序集路径
		/// </summary>
		public string Assembly { get; set; }
		/// <summary>
		/// 程序集的全名称
		/// </summary>
		public string FullClassName { get; set; }
		/// <summary>
		/// 扩展的Guid
		/// </summary>
		public string AddInId { get; set; }
		/// <summary>
		/// 供应商Id
		/// </summary>
		public string VendorId { get; set; }
		/// <summary>
		/// 供应商描述
		/// </summary>
		public string VendorDescription { get; set; }
		/// <summary>
		/// 是否自动加载
		/// </summary>
		public bool AllowLoadIntoExistingSession { get; set; }
	}
}
