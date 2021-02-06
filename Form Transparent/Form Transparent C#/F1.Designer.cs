/*
 * Created by SharpDevelop.
 * User: Sela Smith
 * Date: 06/02/2021
 * Time: 12:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Form_Transparent_C_
{
	partial class F1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel Menu;
		private System.Windows.Forms.Panel Conteudo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label close;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Label label3;
		
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
			this.Menu = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.close = new System.Windows.Forms.Label();
			this.Conteudo = new System.Windows.Forms.Panel();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Menu.SuspendLayout();
			this.Conteudo.SuspendLayout();
			this.SuspendLayout();
			// 
			// Menu
			// 
			this.Menu.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.Menu.Controls.Add(this.label3);
			this.Menu.Controls.Add(this.close);
			this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
			this.Menu.Location = new System.Drawing.Point(0, 0);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(847, 36);
			this.Menu.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(6, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 28);
			this.label3.TabIndex = 1;
			this.label3.Text = "V";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label3.MouseLeave += new System.EventHandler(this.Label3MouseLeave);
			this.label3.MouseHover += new System.EventHandler(this.Label3MouseHover);
			// 
			// close
			// 
			this.close.Font = new System.Drawing.Font("Microsoft Tai Le", 15.25F, System.Drawing.FontStyle.Bold);
			this.close.ForeColor = System.Drawing.Color.White;
			this.close.Location = new System.Drawing.Point(817, 6);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(22, 23);
			this.close.TabIndex = 0;
			this.close.Text = "X";
			this.close.Click += new System.EventHandler(this.CloseClick);
			// 
			// Conteudo
			// 
			this.Conteudo.BackColor = System.Drawing.Color.LawnGreen;
			this.Conteudo.Controls.Add(this.btn2);
			this.Conteudo.Controls.Add(this.btn1);
			this.Conteudo.Controls.Add(this.label2);
			this.Conteudo.Controls.Add(this.label1);
			this.Conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Conteudo.Location = new System.Drawing.Point(0, 36);
			this.Conteudo.Name = "Conteudo";
			this.Conteudo.Size = new System.Drawing.Size(847, 265);
			this.Conteudo.TabIndex = 1;
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.ForeColor = System.Drawing.Color.White;
			this.btn2.Location = new System.Drawing.Point(432, 171);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(156, 41);
			this.btn2.TabIndex = 7;
			this.btn2.Text = "Offline";
			this.btn2.UseVisualStyleBackColor = false;
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.ForeColor = System.Drawing.Color.White;
			this.btn1.Location = new System.Drawing.Point(258, 171);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(156, 41);
			this.btn1.TabIndex = 6;
			this.btn1.Text = "Online";
			this.btn1.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(211, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(425, 28);
			this.label2.TabIndex = 5;
			this.label2.Text = "Creando, Desenvolvendo , Evoluindo";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(328, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 32);
			this.label1.TabIndex = 4;
			this.label1.Text = "C# UI - Design";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// F1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(847, 301);
			this.Controls.Add(this.Conteudo);
			this.Controls.Add(this.Menu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.Name = "F1";
			this.Text = "F1";
			this.Load += new System.EventHandler(this.F1Load);
			this.Menu.ResumeLayout(false);
			this.Conteudo.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		}
	}
