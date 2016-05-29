using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(txtHSA.Text);
            float b = Convert.ToSingle(txtHSB.Text);
            float c = Convert.ToSingle(txtHSC.Text);
            float nghiem;
            float nghiem1, nghiem2;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        txtNghiem.Text = "Phương trình vô sô nghiệm";
                    }
                    else
                    {
                        txtNghiem.Text = "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    nghiem = -c/b;
                    txtNghiem.Text = nghiem.ToString();
                }
            }
            else
            {
                float delta = b*b - 4*a*c;
                if(delta < 0)
                {
                    txtNghiem.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    if (delta == 0)
                    {
                        nghiem = -b/2*a;
                        txtNghiem.Text = nghiem.ToString();
                    }
                    else
                    {
                        nghiem1 = (float) Math.Round((-b + Math.Sqrt(delta))/(2*a),2);
                        nghiem2 = (float) Math.Round((-b - Math.Sqrt(delta)) / (2 * a),2);
                        txtNghiem.Text = nghiem1.ToString() + "\t" + nghiem2.ToString();
                    }
                }
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtHSA.Text = null;
            txtHSB.Text = null;
            txtHSC.Text = null;
            txtNghiem.Text = null;
        }

        

       
    }
}
