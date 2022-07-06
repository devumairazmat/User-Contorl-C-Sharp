using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            this.Load += new EventHandler(UserControl1_Load);
            this.cmbState.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }
        public string SlectedText
        {
            get { return cmbState.Text; }
        }
        public string Selectedvalue
        {
            get { return cmbState.SelectedValue.ToString(); }
        }
        public event EventHandler SelectedIdexChanged;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIdexChanged != null)
                SelectedIdexChanged(sender, e);
        }
        void UserControl1_Load(object sender, EventArgs e)
        {
            BindComboBox();
        }
        private void BindComboBox()
        {
            DataTable dtState = new System.Data.DataTable();
            dtState.Columns.Add("txtPart");
            dtState.Columns.Add("valuePart");
            dtState.Rows.Add("Lahore", "1");  
            dtState.Rows.Add("Fsb", "2");
            dtState.Rows.Add("Isl", "3");
            dtState.Rows.Add("Pindi", "4");
            dtState.Rows.Add("Mian channu", "5");
            cmbState.DataSource = dtState;
            cmbState.DisplayMember = "txtPart";
            cmbState.ValueMember = "ValuePart";
        }

    }
}
