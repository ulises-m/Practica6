
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practica6
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int aciertos = 0;
		String nombre = "";
		String codigo = "";
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
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			       codigo = textBox1.Text;
			       nombre = textBox2.Text;
			       if (textBox1.Text == "" || textBox2.Text == ""){
			       
			       	MessageBox.Show("Introduzca su codigo y Nombre!");
			       
			       return ;
			       }
	    
	       	
	       if (this.radioButton1.Checked){
	       	aciertos++;
	       }
	       if (checkBox1.Checked)
	       {
	       	aciertos++;
	       }
	       if (checkBox3.Checked)
	       {
	       	aciertos++;
	       
	       }
	       if (checkBox4.Checked)
	       {
	       	aciertos++;
	       
	       }
	       
	       
	       if(this.numericUpDown1.Text == "31"){
	       	aciertos++;
	       }
	       if (monthCalendar1.SelectionEnd.ToShortDateString() == "07/05/1945"){
	       
	       aciertos++;
	       }
	       
	       if (aciertos == 6){
       MessageBox.Show("Codigo: "+codigo+"\nNombre: "+nombre+"\n\nAciertos: "+aciertos+"\nBien Hecho Tienes 100!!");
	           
	           }
	           else 
	           	 MessageBox.Show("Codigo: "+codigo+"\nNombre: "+nombre+"\n\nAciertos: "+aciertos);
	           	
        aciertos = 0;
		}

		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
		}
	}
}
