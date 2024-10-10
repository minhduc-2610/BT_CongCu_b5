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

		private void btnThuong_Click(object sender, EventArgs e)
		{
			try
			{
				// Lấy giá trị từ các TextBox
				double num1 = double.Parse(txtSoA.Text);
				double num2 = double.Parse(txtSoB.Text);

				// Kiểm tra chia cho 0
				if (num2 == 0)
				{
					MessageBox.Show("Không thể chia cho 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				double result = num1 / num2;

				txtKQ.Text = result.ToString();
			}
			catch (FormatException)
			{
				MessageBox.Show("Vui lòng nhập số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
