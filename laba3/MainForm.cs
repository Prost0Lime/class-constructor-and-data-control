/*
 * Created by SharpDevelop.
 * User: adfgh
 * Date: 15-03-2019
 * Time: 14:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace laba3
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
		Parall P1 = new Parall(); 
		Parall P2 = new Parall(7,17,10);
		Parall P3 = new Parall(); 		
		Parall P4 = new Parall();
		Parall P5 = new Parall();
		Parall P;
	void Button1Click(object sender, EventArgs e)
	{try {
			if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked) {
		MessageBox.Show("Объект не выбран");}
			else{
	P.setA(Convert.ToDouble(textBox1.Text));
	P.setB(Convert.ToDouble(textBox2.Text)); 
	P.setC(Convert.ToDouble(textBox3.Text));
				} 
			
		}catch(FormatException){
				MessageBox.Show("Вы ввели не число!");
			}
		}
	void Button2Click(object sender, EventArgs e) 
{ 
	try{
	textBox5.Text=Convert.ToString(P.geta());
	textBox6.Text=Convert.ToString(P.getb());
	textBox7.Text=Convert.ToString(P.getc());
	
	textBox4.Text=Convert.ToString(P.getPloschad());
	textBox8.Text=Convert.ToString(P.getObem());
	}catch(NullReferenceException){
		MessageBox.Show("вы не выбрали объект!");
		}
	}
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			P = P1;
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			P = P2;
		}
		void RadioButton3CheckedChanged(object sender, EventArgs e)
		{
			P = P3;
		}
		void RadioButton4CheckedChanged(object sender, EventArgs e)
		{
			P = P4;
		}
		void RadioButton5CheckedChanged(object sender, EventArgs e)
		{
			P = P5;
		}
		}
	
	
class Parall { 

private double a;
private double b;
private double c;
	
	public Parall()
	{
		a = 4;
		b = 5	;
		c = 3;
	}
	public Parall (double a, double b, double c){
		this.a = a;
		this.b = b;
		this.c = c;
	}

	public double geta () {return a;}
	public double getb () {return b;} 
	public double getc() {return c;} 
	
public void setA (double a1) {
		if (a1<17 || a1>7) {
			a=a1;
	}else{
		MessageBox.Show("Выход за диапазон");
	}}
public void setB (double b1) { 
	if (b1>0)
		b=b1;
	else
		MessageBox.Show("Отрицательные значения");	
}
public void setC (double c1) { 
		if (c1>0){
		c=c1;
		}else{
		MessageBox.Show("Отрицательные значения");
}
	}

public double getPloschad () {
	return 2*getc()*(geta()+getb());
			}
public double getObem () {
	return geta()*getb()*getc();
			}
		}
	}

