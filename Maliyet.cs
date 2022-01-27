using System;
using System.Windows.Forms;

namespace KruskalProjesi
{
    public partial class MaliyetForm : Form
    {
        public MaliyetForm()
        {
            InitializeComponent();
        }

        public int maliyetGirdisi;       

        private void OnaylaButton_Click(object sender, EventArgs e)
        {            
            maliyetGirdisi = Convert.ToInt32(MaliyetUpDown.Value);           
            Close();
        }

        private void MaliyetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (maliyetGirdisi == 0)
            {
                MessageBox.Show("Değer Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
        }
    }
}
