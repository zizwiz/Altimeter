/*
 * Created by SharpDevelop.
 * User: sc5
 * Date: 23/09/2022
 * Time: 10:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Altimeter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpbx_present = new System.Windows.Forms.GroupBox();
            this.lbl_present_mb = new System.Windows.Forms.Label();
            this.lbl_present_ft = new System.Windows.Forms.Label();
            this.txtbx_present_pressure = new System.Windows.Forms.TextBox();
            this.txtbx_present_altitude = new System.Windows.Forms.TextBox();
            this.grpbx_to = new System.Windows.Forms.GroupBox();
            this.lbl_to_pressure = new System.Windows.Forms.Label();
            this.lbl_to_mb = new System.Windows.Forms.Label();
            this.lbl_to_ft = new System.Windows.Forms.Label();
            this.txtbx_to_altitude = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.grpbx_QNH = new System.Windows.Forms.GroupBox();
            this.lbl_sea_level_ft = new System.Windows.Forms.Label();
            this.lbl_qnh_pressure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbx_present.SuspendLayout();
            this.grpbx_to.SuspendLayout();
            this.grpbx_QNH.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx_present
            // 
            this.grpbx_present.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_present.Controls.Add(this.lbl_present_mb);
            this.grpbx_present.Controls.Add(this.lbl_present_ft);
            this.grpbx_present.Controls.Add(this.txtbx_present_pressure);
            this.grpbx_present.Controls.Add(this.txtbx_present_altitude);
            this.grpbx_present.Location = new System.Drawing.Point(318, 18);
            this.grpbx_present.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_present.Name = "grpbx_present";
            this.grpbx_present.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_present.Size = new System.Drawing.Size(204, 126);
            this.grpbx_present.TabIndex = 4;
            this.grpbx_present.TabStop = false;
            this.grpbx_present.Text = "Present QFE";
            // 
            // lbl_present_mb
            // 
            this.lbl_present_mb.Location = new System.Drawing.Point(156, 74);
            this.lbl_present_mb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_present_mb.Name = "lbl_present_mb";
            this.lbl_present_mb.Size = new System.Drawing.Size(44, 31);
            this.lbl_present_mb.TabIndex = 18;
            this.lbl_present_mb.Text = "mb";
            // 
            // lbl_present_ft
            // 
            this.lbl_present_ft.Location = new System.Drawing.Point(156, 34);
            this.lbl_present_ft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_present_ft.Name = "lbl_present_ft";
            this.lbl_present_ft.Size = new System.Drawing.Size(26, 31);
            this.lbl_present_ft.TabIndex = 17;
            this.lbl_present_ft.Text = "ft";
            // 
            // txtbx_present_pressure
            // 
            this.txtbx_present_pressure.Location = new System.Drawing.Point(9, 69);
            this.txtbx_present_pressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_present_pressure.Name = "txtbx_present_pressure";
            this.txtbx_present_pressure.Size = new System.Drawing.Size(136, 26);
            this.txtbx_present_pressure.TabIndex = 16;
            // 
            // txtbx_present_altitude
            // 
            this.txtbx_present_altitude.Location = new System.Drawing.Point(9, 29);
            this.txtbx_present_altitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_present_altitude.Name = "txtbx_present_altitude";
            this.txtbx_present_altitude.Size = new System.Drawing.Size(136, 26);
            this.txtbx_present_altitude.TabIndex = 15;
            // 
            // grpbx_to
            // 
            this.grpbx_to.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_to.Controls.Add(this.lbl_to_pressure);
            this.grpbx_to.Controls.Add(this.lbl_to_mb);
            this.grpbx_to.Controls.Add(this.lbl_to_ft);
            this.grpbx_to.Controls.Add(this.txtbx_to_altitude);
            this.grpbx_to.Location = new System.Drawing.Point(622, 18);
            this.grpbx_to.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_to.Name = "grpbx_to";
            this.grpbx_to.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_to.Size = new System.Drawing.Size(200, 126);
            this.grpbx_to.TabIndex = 7;
            this.grpbx_to.TabStop = false;
            this.grpbx_to.Text = "Destination QFE";
            // 
            // lbl_to_pressure
            // 
            this.lbl_to_pressure.Location = new System.Drawing.Point(9, 78);
            this.lbl_to_pressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_to_pressure.Name = "lbl_to_pressure";
            this.lbl_to_pressure.Size = new System.Drawing.Size(132, 18);
            this.lbl_to_pressure.TabIndex = 23;
            this.lbl_to_pressure.Text = "....";
            // 
            // lbl_to_mb
            // 
            this.lbl_to_mb.Location = new System.Drawing.Point(156, 78);
            this.lbl_to_mb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_to_mb.Name = "lbl_to_mb";
            this.lbl_to_mb.Size = new System.Drawing.Size(50, 31);
            this.lbl_to_mb.TabIndex = 22;
            this.lbl_to_mb.Text = "mb";
            // 
            // lbl_to_ft
            // 
            this.lbl_to_ft.Location = new System.Drawing.Point(156, 38);
            this.lbl_to_ft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_to_ft.Name = "lbl_to_ft";
            this.lbl_to_ft.Size = new System.Drawing.Size(26, 31);
            this.lbl_to_ft.TabIndex = 21;
            this.lbl_to_ft.Text = "ft";
            // 
            // txtbx_to_altitude
            // 
            this.txtbx_to_altitude.Location = new System.Drawing.Point(9, 34);
            this.txtbx_to_altitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbx_to_altitude.Name = "txtbx_to_altitude";
            this.txtbx_to_altitude.Size = new System.Drawing.Size(136, 26);
            this.txtbx_to_altitude.TabIndex = 19;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(176, 154);
            this.btn_calculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(174, 52);
            this.btn_calculate.TabIndex = 8;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.Btn_calculateClick);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(492, 154);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(174, 52);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_closeClick);
            // 
            // grpbx_QNH
            // 
            this.grpbx_QNH.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_QNH.Controls.Add(this.lbl_sea_level_ft);
            this.grpbx_QNH.Controls.Add(this.lbl_qnh_pressure);
            this.grpbx_QNH.Controls.Add(this.label1);
            this.grpbx_QNH.Controls.Add(this.label2);
            this.grpbx_QNH.Location = new System.Drawing.Point(18, 18);
            this.grpbx_QNH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_QNH.Name = "grpbx_QNH";
            this.grpbx_QNH.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpbx_QNH.Size = new System.Drawing.Size(204, 126);
            this.grpbx_QNH.TabIndex = 19;
            this.grpbx_QNH.TabStop = false;
            this.grpbx_QNH.Text = "QNH";
            // 
            // lbl_sea_level_ft
            // 
            this.lbl_sea_level_ft.Location = new System.Drawing.Point(15, 34);
            this.lbl_sea_level_ft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sea_level_ft.Name = "lbl_sea_level_ft";
            this.lbl_sea_level_ft.Size = new System.Drawing.Size(132, 18);
            this.lbl_sea_level_ft.TabIndex = 25;
            this.lbl_sea_level_ft.Text = "0";
            // 
            // lbl_qnh_pressure
            // 
            this.lbl_qnh_pressure.Location = new System.Drawing.Point(15, 74);
            this.lbl_qnh_pressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qnh_pressure.Name = "lbl_qnh_pressure";
            this.lbl_qnh_pressure.Size = new System.Drawing.Size(132, 18);
            this.lbl_qnh_pressure.TabIndex = 24;
            this.lbl_qnh_pressure.Text = "....";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(156, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "mb";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(156, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "ft";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 238);
            this.Controls.Add(this.grpbx_QNH);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.grpbx_to);
            this.Controls.Add(this.grpbx_present);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(862, 294);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(862, 294);
            this.Name = "MainForm";
            this.Text = "Altimeter";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.grpbx_present.ResumeLayout(false);
            this.grpbx_present.PerformLayout();
            this.grpbx_to.ResumeLayout(false);
            this.grpbx_to.PerformLayout();
            this.grpbx_QNH.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_qnh_pressure;
		private System.Windows.Forms.Label lbl_sea_level_ft;
		private System.Windows.Forms.GroupBox grpbx_QNH;
		private System.Windows.Forms.TextBox txtbx_to_altitude;
		private System.Windows.Forms.Label lbl_to_ft;
		private System.Windows.Forms.Label lbl_to_mb;
		private System.Windows.Forms.Label lbl_to_pressure;
		private System.Windows.Forms.TextBox txtbx_present_altitude;
		private System.Windows.Forms.TextBox txtbx_present_pressure;
		private System.Windows.Forms.Label lbl_present_ft;
		private System.Windows.Forms.Label lbl_present_mb;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Button btn_calculate;
		private System.Windows.Forms.GroupBox grpbx_to;
		private System.Windows.Forms.GroupBox grpbx_present;
	}
}
