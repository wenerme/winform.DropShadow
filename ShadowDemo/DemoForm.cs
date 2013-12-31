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
					ShadowSpread = 10
				
				};
				shadow.RefreshShadow();
			}
		}

	}
}
