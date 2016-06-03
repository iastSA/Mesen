﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesen.GUI.Controls
{
	public partial class ctrlHorizontalTrackbar : UserControl
	{
		public event EventHandler ValueChanged
		{
			add { trackBar.ValueChanged += value; }
			remove { trackBar.ValueChanged -= value; }
		}

		public ctrlHorizontalTrackbar()
		{
			InitializeComponent();
		}

		public int Maximum
		{
			get { return trackBar.Maximum; }
			set { trackBar.Maximum = value; }
		}

		public int Minimum
		{
			get { return trackBar.Minimum; }
			set { trackBar.Minimum = value; }
		}

		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public override string Text
		{
			get { return lblText.Text; }
			set { lblText.Text = value; }
		}

		public int Value
		{
			get { return trackBar.Value; }
			set
			{
				trackBar.Value = value;
				txtValue.Text = trackBar.Value.ToString();
			}
		}

		private void trackBar_ValueChanged(object sender, EventArgs e)
		{
			txtValue.Text = trackBar.Value.ToString();
		}
	}
}