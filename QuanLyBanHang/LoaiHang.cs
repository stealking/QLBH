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
    public partial class LoaiHang : Form
    {
        public LoaiHang()
        {
            InitializeComponent();
            

        }
        dbConnect dbc = new dbConnect();
        bool isInsert = true;
        void SetNull()
        {
            txtMaLoai.Text = string.Empty;
            txtTenLoai.Text = string.Empty;
            txtMoTa.Text = string.Empty;

        }

        void LoadData()
        {
            dgvLoaiHang.DataSource = dbc.getData("Select * From LoaiHang");
        }
        private void LoaiHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        
    }
}
