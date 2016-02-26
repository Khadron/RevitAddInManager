namespace Autumn.RevitAddInManager.Model
{
	public class AddInCmdInfo : AddInInfo
	{
		/// <summary>
		/// 验证程序的类名称
		/// </summary>
		public string AvailabilityClassName { get; set; }
		/// <summary>
		/// 命令描述
		/// </summary>
		public string Description { get; set; }
		public Discipline Discipline { get; set; }
		/// <summary>
		/// Revit语言类型
		/// </summary>
		public LanguageType LanguageType { get; set; }
		/// <summary>
		/// 命令按钮图片
		/// </summary>
		public string LargeImage { get; set; }
		/// <summary>
		/// 详细描述（鼠标划过时）
		/// </summary>
		public string LongDescription { get; set; }
		/// <summary>
		/// 按钮文本
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// 图片提示（鼠标停留较长时间时显示）
		/// </summary>
		public string TooltipImage { get; set; }
		/// <summary>
		/// 指定在什么文档模式下显示，比如族文档模式下不显示
		/// </summary>
		public VisibilityMode VisibilityMode { get; set; }
	}
}
