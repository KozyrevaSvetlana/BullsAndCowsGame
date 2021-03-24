using System;
using System.Windows.Forms;

namespace BullWindowsFormsApp
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
        }

        private void rulesOkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
