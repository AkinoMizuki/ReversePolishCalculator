using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace dentaku00
{
    

    public partial class Form1 : Form
    {

        double x=0,y=0,z=0,t=0,d=0,j=1,i=10,f=0,k=0;//桁カウンター上限15桁
        string m;//演算結果桁検知用

        public Form1()
        {
            InitializeComponent();
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Close();
        }

        private void バージョン確認ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (Form2 dig = new Form2())
            {
                Form2 dlg = new Form2 ();
                dlg.StartPosition = FormStartPosition.Manual;
                dlg.Left = this.Left + (this.Width - dlg.Width) / 2;
                dlg.Top = this.Top + (this.Height - dlg.Height) / 2;
                dlg.Owner = this; // 常に親ウィンドウの手前に表示
                dlg.ShowDialog(this);// モードレス・ダイアログとして表示 
            }
        }

        public void Entr_Click(object sender, EventArgs e)
        {
            t = z;
            z = y;
            y = x;
            x = 0;
            d = 0;
            f = 0;
            j = 1;//少数桁カウンタクリア
            k = 0;//桁カウンタークリア

            textBox1.Text = "" + x + ""; 
        }

        public void button9_Click(object sender, EventArgs e)
        {
            if (k >= 15) { }

            else if (f == 1){}
            else if (d == 0)
            {
                x *= 10;
                x += 1;
                k++;
            }
            else {
                j *= 10;
                d = 0;
                d += 1;
                d /= j; 
                x += d;
                d = 1;
                k++;
            }
            textBox1.Text = "" + x + ""; 
        }

 /*       private void button18_Click(object sender, EventArgs e)
        {
            
        }
        */
        private void button18_Click_1(object sender, EventArgs e)
        {
            textBox1.ResetText();
            x = 0;//xレジスタクリア
            f = 0;
            d = 0;
            j = 1;//少数桁カウンタクリア
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (k >= 15) { }

            else if (f == 1) { }
            else if (d == 0)
            {
                x *= 10;
                x += 2;
                k++;
            }
            
            else {
                j *= 10;
                d = 0;
                d += 2;
                d /= j; 
                x += d;
                d = 1;
                k++;
            
            }
            textBox1.Text = "" + x + ""; 
        
        }

        private void button13_Click(object sender, EventArgs e)
        {
            d = 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (k >= 15) { }

            else if (f == 1) { }
            else if (d == 0)
            {
                x *= 10;
                x += 3;
                k++;
            }
            
            else
            {
                j *= 10;
                d = 0;
                d += 3;
                d /= j;
                x += d;
                d = 1;
                k++;

            }
            textBox1.Text = "" + x + ""; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (k >= 15) { }

            else if (f == 1) { }
            else if (d == 0)
            {
                x *= 10;
                x += 4;
                k++;
            }

            else
            {
                j *= 10;
                d = 0;
                d += 4;
                d /= j;
                x += d;
                d = 1;
                k++;

            }
            textBox1.Text = "" + x + ""; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (k >= 15) { }
 
            else if (f == 1) { }
            else if (d == 0)
            {
                x *= 10;
                x += 5;
                k++;
            }

            else
            {
                j *= 10;
                d = 0;
                d += 5;
                d /= j;
                x += d;
                d = 1;
                k++;

            }
            textBox1.Text = "" + x + ""; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (k >= 15) { }
 
            else if (f == 1) { }
            else if (d == 0)
            {
                x *= 10;
                x += 6;
                k++;
            }
            
            else
            {
                j *= 10;
                d = 0;
                d += 6;
                d /= j;
                x += d;
                d = 1;
                k++;

            }
            textBox1.Text = "" + x + ""; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (k >= 15) { }
 
            else if (f == 1) { }
            else if (d == 0)
            {
                x *= 10;
                x += 7;
                k++;
            }
 
//            else if (x >= 9.99999999999999) { }
            
            else
            {
                j *= 10;
                d = 0;
                d += 7;
                d /= j;
                x += d;
                d = 1;
                k++;

            }
            textBox1.Text = "" + x + ""; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (k >= 15) { }

            else if (f == 1) { }
            else if (d == 0)
            {
                x *= 10;
                x += 8;
                k++;
            }

            else
            {
                j *= 10;
                d = 0;
                d += 8;
                d /= j;
                x += d;
                d = 1;
                k++;

            }
            textBox1.Text = "" + x + ""; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(k>=15){}

            else if (f == 1) { }
            else if (d == 0)
            {
                x *= 10;
                x += 9;
                k++;
            }
            
            else
            {
                j *= 10;
                d = 0;
                d += 9;
                d /= j;
                x += d;
                d = 1;
                k++;

            }
            textBox1.Text = "" + x + ""; 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (k >= 15) { }

            else if (f == 1) { }
            else if (d == 0)
            {
                x *= 10;
                k++;
            }
            
            else
            {
                j *= 10;
                d = 0;
                d /= j;
                x += d;
                d = 1;
                k++;

            }
            textBox1.Text = "" + x + ""; 
        }

        private void button8_Click(object sender, EventArgs e)
        {  
            y += x;
            x = y;
            if (x >= 99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }/*
            else if (x >= -99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }
            else if (x >= 9.99999999999999)
            { 
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }*/
            else
            {
            y = z;
            z = t;
             textBox1.Text = "" + x + ""; 
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            y -= x;
            x = y;
/*            m = x.ToString();
            if (m >= (int)15)
*/            if (x >= 99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }/*
            else if (x >= -99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }
            else if (x >= 9.99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }*/
            else
            {
                y = z;
                z = t;
                textBox1.Text = "" + x + "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            y *= x;
            x = y;
            if (x >= 99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }/*
            else if (x >= -99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }
            else if (x >= 9.99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }*/
            else
            {
                y = z;
                z = t;
                textBox1.Text = "" + x + "";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (x == 0) {textBox1.Text = "0で割ることができません。" ;}
            else{
                y /= x;
                x = y;
                if (x >= 99999999999999)
                {
                    textBox1.Text = "桁オーバーです、Xを初期化します。";
                    x = 0;
                }/*
                else if (x >= -99999999999999)
                {
                    textBox1.Text = "桁オーバーです、Xを初期化します。";
                    x = 0;
                }
                else if (x >= 9.99999999999999)
                {
                    textBox1.Text = "桁オーバーです、Xを初期化します。";
                    x = 0;
                }*/
                else
                {
                    y = z;
                    z = t;
                    textBox1.Text = "" + x + "";
                }
            }
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            x -= x*2;
            if (x >= 99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }/*
            else if (x >= -999999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }
            if (x >= 9.99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }*/
            else
            {
                textBox1.Text = "" + x + "";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            t = 0;//tレジスタクリア
            z = 0;//zレジスタクリア
            y = 0;//yレジスタクリア
            x = 0;//xレジスタクリア
            f = 0;
            d = 0;
            k = 0;//桁カウンタークリア
            j = 1;//少数桁カウンタクリア
        }

        private void button19_Click(object sender, EventArgs e)
        {
            y *= x;
            x = y/100;
            if (x >= 99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }/*
            else if (x >= -99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }
            else if (x >= 9.99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }*/
            else
            {
                y = z;
                z = t;
                f = 1;
                textBox1.Text = "" + x + "";
            } 
        }

        private void button21_Click(object sender, EventArgs e)
        {
            x = 3.14159265;
            f = 1;
            textBox1.Text = "" + x + ""; 
        }

        private void button22_Click(object sender, EventArgs e)
        {
            x = 1/x;
            if (x >= 99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }/*
            else if (x >= -99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }
            else if (x >= 9.99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }*/
            else
            {
                f = 1;
                textBox1.Text = "" + x + "";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            x = Math.Sqrt(x);
            if (x >= 99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }/*
            else if (x >= -99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }
            else if (x >= 9.99999999999999)
            {
                textBox1.Text = "桁オーバーです、Xを初期化します。";
                x = 0;
            }*/
            else
            {
                f = 1;
                textBox1.Text = "" + x + "";
            }
        }

        private void クリップボードにコピーToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("" + x + "");
        }
    }
}
