using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BigMemo
{
	public class MainWindowViewModel
	{
		public double Width { get; set; }
		public double Height { get; set; }
		public double Top { get; set; }
		public double Left { get; set; }

		public MainWindowViewModel()
		{
			Width = 1600;
			Height = SystemParameters.WorkArea.Height + 10;
			Top = 0;
			Left = SystemParameters.WorkArea.Width - Width + 5;
		}
	}
}
