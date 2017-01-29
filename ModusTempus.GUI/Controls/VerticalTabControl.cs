using System.Drawing;
using System.Windows.Forms;

namespace ModusTempus.GUI.Controls
{
	public class VerticalTabControl : TabControl
	{
		public VerticalTabControl()
		{
			Alignment = TabAlignment.Right;
			DrawMode = TabDrawMode.OwnerDrawFixed;
			SizeMode = TabSizeMode.Fixed;
			ItemSize = new Size(Font.Height * 3 / 2, 75);
		}
		public override Font Font
		{
			get { return base.Font; }
			set
			{
				base.Font = value;
				ItemSize = new Size(value.Height * 3 / 2, ItemSize.Height);
			}
		}
		protected override void OnDrawItem(DrawItemEventArgs e)
		{
			using (var textBrush = new SolidBrush(ForeColor))
			{
				TabPage tabPage = TabPages[e.Index];
				Rectangle tabBounds = GetTabRect(e.Index);

				if (e.State != DrawItemState.Selected) e.DrawBackground();
				else
				{
					using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Gray, Color.White, 90f))
					{
						e.Graphics.FillRectangle(brush, e.Bounds);
					}
				}

				StringFormat stringFlags = new StringFormat();
				stringFlags.Alignment = StringAlignment.Center;
				stringFlags.LineAlignment = StringAlignment.Center;
				e.Graphics.DrawString(tabPage.Text, Font, textBrush, tabBounds, new StringFormat(stringFlags));
			}
		}
	}
}
