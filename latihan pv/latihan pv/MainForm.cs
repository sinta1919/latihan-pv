/*
 * Created by SharpDevelop.
 * User: user
 * Date: 07/03/2022
 * Time: 22:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace latihan_pv
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void DoneClick(object sender, EventArgs e) 
		{
			MessageBox.Show ( "Nama :"+this.textBox1.Text +"\r"+"Nim :"
			                 + this.textBox2.Text +"\r"+"Kom :" + this.textBox3.Text);
		}
		void Button1Click(object sender, EventArgs e)
		{
	MessageBox.Show ( "Nama :"+this.textBox1.Text +"\r"+"Nim :"
			                 + this.textBox2.Text +"\r"+"Kom :" + this.textBox3.Text);
		}
	}
}
