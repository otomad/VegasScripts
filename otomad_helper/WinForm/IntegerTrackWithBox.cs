using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Otomad.VegasScript.OtomadHelper.V4 {

	//[ToolboxBitmap(typeof(TrackBar))]
	public partial class IntegerTrackWithBox : UserControl {
		public IntegerTrackWithBox() {
			InitializeComponent();
			Track.MouseClick += new MouseEventHandler(Track_MouseClick);
			Track.MouseDown += new MouseEventHandler(Track_MouseDown);
			Numeric.MouseWheel += AutoLayoutTracksGridForm.NumericUpDown_MouseWheel;
			doubleClickTimer.Tick += new EventHandler((sender, e) => {
				isWaitingDoubleClick = false;
				doubleClickTimer.Stop();
			});
		}

		private void Track_Scroll(object sender, EventArgs e) {
			Numeric.Value = Track.Value;
		}

		private void Numeric_ValueChanged(object sender, EventArgs e) {
			Track.Value = (int)Numeric.Value;
		}

		[Description("指示数值控件的当前值。"), Category("Behavior"), DefaultValue(0)]
		public int Value {
			get { return Track.Value; }
			set {
				Track.Value = value;
				Numeric.Value = value;
			}
		}

		[Description("指示数值控件的最小值。"), Category("Behavior"), DefaultValue(0)]
		public int Minimum {
			get { return Track.Minimum; }
			set {
				Track.Minimum = value;
				Numeric.Minimum = value;
				UpdateTickFrequency();
			}
		}

		[Description("指示数值控件的最大值。"), Category("Behavior"), DefaultValue(100)]
		public int Maximum {
			get { return Track.Maximum; }
			set {
				Track.Maximum = value;
				Numeric.Maximum = value;
				UpdateTickFrequency();
			}
		}

		private const int tickFrequency = 10;

		private void UpdateTickFrequency() {
			Track.TickFrequency = (Track.Maximum - Track.Minimum) / tickFrequency;
		}

		[Description("指示在跟踪条上的哪些位置显示刻度。"), Category("Appearance"), DefaultValue(typeof(TickStyle), "BottomRight")]
		public TickStyle TickStyle {
			get { return Track.TickStyle; }
			set { Track.TickStyle = value; }
		}

		[Description("数值选择控件的宽度。"), Category("Layout"), DefaultValue(75)]
		public int NumericUpDownWidth {
			get { return Numeric.Width; }
			set { Numeric.Width = value; }
		}

		private int defaultValue = 0;

		[Description("指示数值控件的默认值，当用户鼠标右键跟踪条时可以重置为默认值。"), Category("Behavior"), DefaultValue(0)]
		public int DefaultValue {
			get { return defaultValue; }
			set {
				if (value < Minimum || value > Maximum)
					throw new ArgumentOutOfRangeException("Value", "输入的默认值比最小值小或比最大值大。");
				defaultValue = value;
			}
		}

		/// <summary>
		/// 右键滑动条，可以重置其值。
		/// </summary>
		private void Track_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right && e.Clicks == 1) ResetDefaultValue();
		}

		/// <summary>
		/// 双击滑动条，也可以重置其值。
		/// </summary>
		private void Track_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left && e.Clicks == 1) {
				if (!isWaitingDoubleClick) {
					isWaitingDoubleClick = true;
					doubleClickTimer.Start();
				} else {
					doubleClickTimer.Stop();
					isWaitingDoubleClick = false;
					ResetDefaultValue();
				}
			}
		}

		private const int DOUBLE_CLICK_DURATION = 500;
		private readonly System.Windows.Forms.Timer doubleClickTimer = new System.Windows.Forms.Timer { Interval = DOUBLE_CLICK_DURATION };
		private bool isWaitingDoubleClick = false;

		private void ResetDefaultValue() {
			Value = DefaultValue;
		}

		/// <summary>
		/// 设定数值控件的当前值，并确保不受最大值或最小值限制的干扰。
		/// </summary>
		/// <param name="value">设定值</param>
		/// <param name="def">如果设定失败后的默认值，如果为 null 表示不改变。</param>
		public void SetValue(int value, int? def = null) {
			if (value < Minimum || value > Maximum) {
				if (def == null || def < Minimum || def > Maximum) return;
				Value = (int)def;
			} else Value = value;
		}
	}
}
