using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace salamatjino
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			double x1, y1, z1, res1, x2, y2, z2, res2, x3, y3, z3, res3;
			x1 = Convert.ToDouble(textBox1.Text);
			y1 = Convert.ToDouble(textBox2.Text);
			z1 = Convert.ToDouble(textBox3.Text);
			res1 = Convert.ToDouble(textBox4.Text);
			textBox13.Text = Convert.ToString(1/x1*x1);
			textBox14.Text = Convert.ToString(1/x1*y1);
			textBox15.Text = Convert.ToString(1/x1*z1);
			textBox16.Text = Convert.ToString(1/x1*res1);
			
			x2 = Convert.ToDouble(textBox5.Text);
			y2 = Convert.ToDouble(textBox6.Text);
			z2 = Convert.ToDouble(textBox7.Text);
			res2 = Convert.ToDouble(textBox8.Text);
			textBox17.Text = Convert.ToString(x2);
			textBox18.Text = Convert.ToString(y2);
			textBox19.Text = Convert.ToString(z2);
			textBox20.Text = Convert.ToString(res2);
			
			x3 = Convert.ToDouble(textBox9.Text);
			y3 = Convert.ToDouble(textBox10.Text);
			z3 = Convert.ToDouble(textBox11.Text);
			res3 = Convert.ToDouble(textBox12.Text);
			textBox21.Text = Convert.ToString(x3);
			textBox22.Text = Convert.ToString(y3);
			textBox23.Text = Convert.ToString(z3);
			textBox24.Text = Convert.ToString(res3);
			
			label4.Text = "1. Multiplied 1/(" + x1 + ") to R1";
			
			textBox25.Text = textBox13.Text;
			textBox26.Text = textBox14.Text;
			textBox27.Text = textBox15.Text;
			textBox28.Text = textBox16.Text;
			
			textBox29.Text = Convert.ToString(Convert.ToDouble(textBox13.Text)*-1*Convert.ToDouble(textBox17.Text)+Convert.ToDouble(textBox17.Text));
			textBox30.Text = Convert.ToString(Convert.ToDouble(textBox14.Text)*-1*Convert.ToDouble(textBox17.Text)+Convert.ToDouble(textBox18.Text));
			textBox31.Text = Convert.ToString(Convert.ToDouble(textBox15.Text)*-1*Convert.ToDouble(textBox17.Text)+Convert.ToDouble(textBox19.Text));
			textBox32.Text = Convert.ToString(Convert.ToDouble(textBox16.Text)*-1*Convert.ToDouble(textBox17.Text)+Convert.ToDouble(textBox20.Text));
			
			textBox33.Text = Convert.ToString(Convert.ToDouble(textBox13.Text)*-1*Convert.ToDouble(textBox21.Text)+Convert.ToDouble(textBox21.Text));
			textBox34.Text = Convert.ToString(Convert.ToDouble(textBox14.Text)*-1*Convert.ToDouble(textBox21.Text)+Convert.ToDouble(textBox22.Text));
			textBox35.Text = Convert.ToString(Convert.ToDouble(textBox15.Text)*-1*Convert.ToDouble(textBox21.Text)+Convert.ToDouble(textBox23.Text));
			textBox36.Text = Convert.ToString(Convert.ToDouble(textBox16.Text)*-1*Convert.ToDouble(textBox21.Text)+Convert.ToDouble(textBox24.Text));
			
			label11.Text = "2. Multiplied -(" + textBox17.Text + ") to R1 and added to R2;";
			label12.Text = "3. Multiplied -(" + textBox21.Text + ") to R1 and added to R3";
			//
			textBox37.Text = textBox25.Text;
			textBox38.Text = textBox26.Text;
			textBox39.Text = textBox27.Text;
			textBox40.Text = textBox28.Text;
			
			textBox41.Text = Convert.ToString(1/Convert.ToDouble(textBox30.Text)*Convert.ToDouble(textBox29.Text));
			textBox42.Text = Convert.ToString(1/Convert.ToDouble(textBox30.Text)*Convert.ToDouble(textBox30.Text));
			textBox43.Text = Convert.ToString(1/Convert.ToDouble(textBox30.Text)*Convert.ToDouble(textBox31.Text));
			textBox44.Text = Convert.ToString(1/Convert.ToDouble(textBox30.Text)*Convert.ToDouble(textBox32.Text));
			
			label16.Text = "4. Multiplied 1/(" + textBox30.Text + ") to R2";
			
			textBox45.Text = textBox33.Text;
			textBox46.Text = textBox34.Text;
			textBox47.Text = textBox35.Text;
			textBox48.Text = textBox36.Text;
			//5-6
			textBox49.Text = Convert.ToString(Convert.ToDouble(textBox41.Text)*-1*Convert.ToDouble(textBox38.Text)+Convert.ToDouble(textBox37.Text));
			textBox50.Text = Convert.ToString(Convert.ToDouble(textBox42.Text)*-1*Convert.ToDouble(textBox38.Text)+Convert.ToDouble(textBox38.Text));
			textBox51.Text = Convert.ToString(Convert.ToDouble(textBox43.Text)*-1*Convert.ToDouble(textBox38.Text)+Convert.ToDouble(textBox39.Text));
			textBox52.Text = Convert.ToString(Convert.ToDouble(textBox44.Text)*-1*Convert.ToDouble(textBox38.Text)+Convert.ToDouble(textBox40.Text));
			
			textBox53.Text = textBox41.Text;
			textBox54.Text = textBox42.Text;
			textBox55.Text = textBox43.Text;
			textBox56.Text = textBox44.Text;
			
			textBox57.Text = Convert.ToString(Convert.ToDouble(textBox41.Text)*-1*Convert.ToDouble(textBox46.Text)+Convert.ToDouble(textBox45.Text));
			textBox58.Text = Convert.ToString(Convert.ToDouble(textBox42.Text)*-1*Convert.ToDouble(textBox46.Text)+Convert.ToDouble(textBox46.Text));
			textBox59.Text = Convert.ToString(Convert.ToDouble(textBox43.Text)*-1*Convert.ToDouble(textBox46.Text)+Convert.ToDouble(textBox47.Text));
			textBox60.Text = Convert.ToString(Convert.ToDouble(textBox44.Text)*-1*Convert.ToDouble(textBox46.Text)+Convert.ToDouble(textBox48.Text));
			//7
			label24.Text = "5. Multiplied -(" + textBox38.Text + ") to R2 and added to R1;";
			label23.Text = "6. Multiplied -(" + textBox46.Text + ") to R2 and added to R3;";
			
			textBox61.Text = textBox49.Text;
			textBox62.Text = textBox50.Text;
			textBox63.Text = textBox51.Text;
			textBox64.Text = textBox52.Text;
			
			textBox65.Text = textBox53.Text;
			textBox66.Text = textBox54.Text;
			textBox67.Text = textBox55.Text;
			textBox68.Text = textBox56.Text;
			
			textBox69.Text = Convert.ToString(1/Convert.ToDouble(textBox59.Text)*Convert.ToDouble(textBox57.Text));
			textBox70.Text = Convert.ToString(1/Convert.ToDouble(textBox59.Text)*Convert.ToDouble(textBox58.Text));
			textBox71.Text = Convert.ToString(1/Convert.ToDouble(textBox59.Text)*Convert.ToDouble(textBox59.Text));
			textBox72.Text = Convert.ToString(1/Convert.ToDouble(textBox59.Text)*Convert.ToDouble(textBox60.Text));
			
			label25.Text = "7. Multiplied 1/(" + textBox59.Text + ") to R3";
			
			textBox73.Text = Convert.ToString(Convert.ToDouble(textBox69.Text)*-1*Convert.ToDouble(textBox63.Text)+Convert.ToDouble(textBox61.Text));
			textBox74.Text = Convert.ToString(Convert.ToDouble(textBox70.Text)*-1*Convert.ToDouble(textBox63.Text)+Convert.ToDouble(textBox62.Text));
			textBox75.Text = Convert.ToString(Convert.ToDouble(textBox71.Text)*-1*Convert.ToDouble(textBox63.Text)+Convert.ToDouble(textBox63.Text));
			textBox76.Text = Convert.ToString(Convert.ToDouble(textBox72.Text)*-1*Convert.ToDouble(textBox63.Text)+Convert.ToDouble(textBox64.Text));
			
			textBox77.Text = Convert.ToString(Convert.ToDouble(textBox69.Text)*-1*Convert.ToDouble(textBox67.Text)+Convert.ToDouble(textBox65.Text));
			textBox78.Text = Convert.ToString(Convert.ToDouble(textBox70.Text)*-1*Convert.ToDouble(textBox67.Text)+Convert.ToDouble(textBox66.Text));
			textBox79.Text = Convert.ToString(Convert.ToDouble(textBox71.Text)*-1*Convert.ToDouble(textBox67.Text)+Convert.ToDouble(textBox67.Text));
			textBox80.Text = Convert.ToString(Convert.ToDouble(textBox72.Text)*-1*Convert.ToDouble(textBox67.Text)+Convert.ToDouble(textBox68.Text));
			
			textBox81.Text = textBox69.Text;
			textBox82.Text = textBox70.Text;
			textBox83.Text = textBox71.Text;
			textBox84.Text = textBox72.Text;
			
			label30.Text = "8. Multiplied -(" + textBox63.Text + ") to R3 and added to R1;";
			label29.Text = "9. Multiplied -(" + textBox67.Text + ") to R3 and added to R2;";
			
			label31.Text = "(x, y, z) = (" + textBox76.Text + ", " + textBox80.Text + ", " + textBox84.Text + ")";

		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Label11Click(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void Label23Click(object sender, EventArgs e)
		{
	
		}
		void Label25Click(object sender, EventArgs e)
		{
	
		}
	}
}
