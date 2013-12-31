using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShadowDemo
{
	public partial class DemoForm : Form
	{
		private Dropshadow shadow;
		private int step = 10;
		public DemoForm()
		{
			InitializeComponent();
			FormBorderStyle = FormBorderStyle.None;
			
		}

		// Let Windows drag this form for us
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x0084 /*WM_NCHITTEST*/)
			{
				m.Result = (IntPtr)2;   // HTCLIENT
				return;
			}
			base.WndProc(ref m);
		}

		private void DemoForm_Load(object sender, EventArgs e)
		{
			Width = 300;
			Height = 300;
			if (! DesignMode)
			{
				shadow = new Dropshadow(this)
				{
					ShadowBlur = 40,
					ShadowSpread = 10,
					ShadowColor = Color.DimGray
				
				};
				shadow.RefreshShadow();
				UpdateValue();
			}
		}

		private void UpdateValue()
		{
			vSpread.Text = shadow.ShadowSpread.ToString();
			vBlur.Text = shadow.ShadowBlur.ToString();
			vShadowH.Text = shadow.ShadowH.ToString();
			vShadowV.Text = shadow.ShadowV.ToString();

		}

		private void comboBox1_TextChanged(object sender, EventArgs e)
		{
			if (! int.TryParse(comboBoxStep.Text, out step))
				comboBoxStep.Text = step.ToString();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			shadow.ShadowV += step;
			UpdateValue();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			shadow.ShadowV -= step;
			UpdateValue();
		}

		private void btnShadowHDe_Click(object sender, EventArgs e)
		{
			shadow.ShadowH -= step;
			UpdateValue();
		}

		private void btnShadowHIn_Click(object sender, EventArgs e)
		{
			shadow.ShadowH += step;
			UpdateValue();
		}

		private void btnBlurDe_Click(object sender, EventArgs e)
		{
			shadow.ShadowBlur -= step;
			shadow.RefreshShadow();
			UpdateValue();

		}

		private void btnBlurIn_Click(object sender, EventArgs e)
		{
			shadow.ShadowBlur += step;
			shadow.RefreshShadow();
			UpdateValue();

		}

		private void btnSpreadDe_Click(object sender, EventArgs e)
		{
			shadow.ShadowSpread -= step;
			shadow.RefreshShadow();
			UpdateValue();
		}

		private void btnSpreadIn_Click(object sender, EventArgs e)
		{
			shadow.ShadowSpread += step;
			shadow.RefreshShadow();
			UpdateValue();
		}

		Random randomGen = new Random();
		private void btnRandomColor_Click(object sender, EventArgs e)
		{
			KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
			KnownColor randomColorName = names[randomGen.Next(names.Length)];
			Color randomColor = Color.FromKnownColor(randomColorName);

			shadow.ShadowColor = randomColor;
			shadow.RefreshShadow();
		}

		private void btnToggleRegion_Click(object sender, EventArgs e)
		{
			if (Region == null)
			{
				Region = Region.FromHrgn(Win32.CreateRoundRectRgn(0, 0, Width, Height, step, step));
			} else
			{
				Region = null;
			}
			shadow.RefreshShadow();
		}

	}
}
