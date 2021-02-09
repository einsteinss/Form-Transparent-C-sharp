/*
 * Created by SharpDevelop.
 * User: Sela Smith
 * Date: 09/02/2021
 * Time: 08:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Form_Transparent_C_
{
	partial class F2
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel Menu;
		private System.Windows.Forms.Label BGIHover;
		private System.Windows.Forms.Label Fechar;
		
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Menu = new System.Windows.Forms.Panel();
			this.BGIHover = new System.Windows.Forms.Label();
			this.Fechar = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.Menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkGray;
			this.panel2.Controls.Add(this.btn2);
			this.panel2.Controls.Add(this.btn1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(847, 301);
			this.panel2.TabIndex = 1;
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn2.Location = new System.Drawing.Point(432, 197);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(156, 41);
			this.btn2.TabIndex = 11;
			this.btn2.Text = "Offline";
			this.btn2.UseVisualStyleBackColor = false;
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn1.Location = new System.Drawing.Point(258, 197);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(156, 41);
			this.btn1.TabIndex = 10;
			this.btn1.Text = "Online";
			this.btn1.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(211, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(425, 28);
			this.label4.TabIndex = 9;
			this.label4.Text = "Creando, Desenvolvendo , Evoluindo";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(328, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(190, 32);
			this.label5.TabIndex = 8;
			this.label5.Text = "C# UI - Design";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Menu
			// 
			this.Menu.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.Menu.Controls.Add(this.BGIHover);
			this.Menu.Controls.Add(this.Fechar);
			this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
			this.Menu.Location = new System.Drawing.Point(0, 0);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(847, 39);
			this.Menu.TabIndex = 2;
			// 
			// BGIHover
			// 
			this.BGIHover.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BGIHover.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BGIHover.Location = new System.Drawing.Point(6, 6);
			this.BGIHover.Name = "BGIHover";
			this.BGIHover.Size = new System.Drawing.Size(23, 28);
			this.BGIHover.TabIndex = 1;
			this.BGIHover.Text = "V";
			this.BGIHover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BGIHover.Click += new System.EventHandler(this.BGIHoverClick);
			// 
			// Fechar
			// 
			this.Fechar.Font = new System.Drawing.Font("Microsoft Tai Le", 15.25F, System.Drawing.FontStyle.Bold);
			this.Fechar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Fechar.Location = new System.Drawing.Point(817, 6);
			this.Fechar.Name = "Fechar";
			this.Fechar.Size = new System.Drawing.Size(22, 23);
			this.Fechar.TabIndex = 0;
			this.Fechar.Text = "X";
			this.Fechar.Click += new System.EventHandler(this.FecharClick);
			// 
			// F2
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(847, 301);
			this.Controls.Add(this.Menu);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "F2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "F2";
			this.TransparencyKey = System.Drawing.Color.DarkGray;
			this.panel2.ResumeLayout(false);
			this.Menu.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
