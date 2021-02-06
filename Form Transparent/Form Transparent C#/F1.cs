/*
 * Created by SharpDevelop.
 * User: Sela Smith
 * Date: 06/02/2021
 * Time: 12:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Form_Transparent_C_
{
	/// <summary>
	/// Description of F1.
	/// </summary>
	public partial class F1 : Form
	{
		public F1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void F1Load(object sender, EventArgs e)
		{
	
		}
		void CloseClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Label3MouseHover(object sender, EventArgs e)
		{
			this.btn2.Visible = false;
			this.btn1.Visible = false;
			this.label2.Visible = false;
			this.label1.Visible = false;
			
			
		}
		void Label3MouseLeave(object sender, EventArgs e)
		{
			
			this.btn2.Visible = true;
			this.btn1.Visible = true;
			this.label2.Visible = true;
			this.label1.Visible = true;

		}
		
	}
}
