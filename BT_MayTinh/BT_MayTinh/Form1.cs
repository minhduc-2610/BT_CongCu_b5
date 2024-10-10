using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_MayTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float TinhTich(int a, int b)
        {
            return a * b;
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu giá trị nhập là số nguyên
            if (int.TryParse(txtSoA.Text, out int a) && int.TryParse(txtSoB.Text, out int b))
            {
                // Gọi hàm tính tích và hiển thị kết quả
                float tich = TinhTich(a, b);
                txtKQ.Text = tich.ToString();
            }
            else
            {
                // Thông báo nếu nhập không phải số hợp lệ
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            double number1, number2;
            if (double.TryParse(txtSoA.Text, out number1) && double.TryParse(txtSoB.Text, out number2))
            {
                double result = number1 - number2;
                txtKQ.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
