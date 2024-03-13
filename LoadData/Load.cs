using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach.LoadData
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        // Set up default text for ComboBoxes
        private void Load_Load(object sender, EventArgs e)
        { xDataType.SelectedIndex = 0; yDataType.SelectedIndex = 0; fileType.SelectedIndex = 0; }

        #region Customization
        // used for default text in textbox
        private void fileURL_Enter(object sender, EventArgs e)  
        { if (fileURL.ForeColor != Color.Black) SetText("", Color.Black); }

        private void fileURL_Leave(object sender, EventArgs e)
        { if (fileURL.Text.Trim() == "") SetText("File path", Color.Gray);}

        #endregion

        #region Get Data
        private void fileURL_Validating(object sender, CancelEventArgs e) // Checks if file exists and, if so, loads it
        {
            if (!File.Exists(fileURL.Text) && (fileURL.ForeColor != Color.Gray)) errorProvider1.SetError(fileURL, "Invalid Path");
            else errorProvider1.SetError(fileURL, null); PostAndSaveData(fileURL.Text);
        }

        private void browseBT_Click(object sender, EventArgs e)           // Same, but uses openFileDialog
        { if (openFileDialog1.ShowDialog() == DialogResult.OK) SetText(openFileDialog1.FileName, Color.Black); PostAndSaveData(fileURL.Text); }

        private void altBrowseBT_Click(object sender, EventArgs e)        // Same, but with my argly control
        {
            // Добавить
        }

        #endregion

        // returns data to main forms
        private void submitBT_Click(object sender, EventArgs e)           
        { 
            if (result) Close();
            else
            {

            }
        }
    }
}