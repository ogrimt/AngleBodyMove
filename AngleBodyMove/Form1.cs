using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngleBodyMove
{
    public partial class Form1 : Form
    {
        double x = 0, y = 0;
        double y_round;
        double t;//время
        double a;//угол
        double V_0;//скорость
        const double g = 9.81;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
                L_value.Text = "";
                Hmax_value.Text = "";
                t_value.Text = ""; 
            try
            {
                a = Convert.ToDouble(angle_value.Text) * (3.141592 / 180);
                V_0 = Convert.ToDouble(V_0_value.Text);
            }
            catch (Exception) {

                MessageBox.Show("Проверьте введённые данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Invalidate();
            this.Paint += new PaintEventHandler(Form1_Paint);
            timer1.Start();
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 50;
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, 
                new Rectangle(
                    (int)(50 * x), (int)(400 - 50 * y), 5, 5));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void angle_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void V_0_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += 0.01;
            x = (V_0 * Math.Cos(a)) * t;
            y = (V_0 * Math.Sin(a)) * t - g * t * t / 2;
            y_round = Math.Round(y, 0);
            Invalidate();
            if(y != 0 && y < 0 && y_round == 0)
            {
                if(angle_value.Text != "" && V_0_value.Text != "") { 
                    L_value.Text = Convert.ToString(Math.Round((V_0 * Math.Cos(a)) * (2 * (V_0 * Math.Sin(a) / (g))), 2));
                    Hmax_value.Text = Convert.ToString(Math.Round(Math.Pow(V_0 * Math.Sin(a), 2) / (2 * g), 2));
                    t_value.Text = Convert.ToString(Math.Round(2*(V_0 * Math.Sin(a)/(g)), 2));
                }
                timer1.Stop();
            }
        }
    }

}
