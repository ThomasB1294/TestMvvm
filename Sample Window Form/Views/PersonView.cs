using SampleWindowForm.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWindowForm.Views
{
    public partial class PersonView : Form
    {
        private PersonViewModel _viewModel;
        public PersonView(PersonViewModel viewModel)
        {
            _viewModel = viewModel;
            InitializeComponent();
            MainGrid.DataSource = _viewModel.People;
            MainGrid.DataBindings.Add(new Binding("Enabled", _viewModel, "CanEdit"));
        }

        private void MainGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (_viewModel.DoesBeginWithT(e.RowIndex))
                e.CellStyle.BackColor = Color.Red;
            //e.CellStyle.ForeColor = Color.Aqua;
        }

        private async void SaveClick(object sender, EventArgs e)
        {
            bool saved = await _viewModel.Save();
            if(saved)
            {
                MessageBox.Show("Saved!");
                return;
            }
            MessageBox.Show("There was an issue saving");
        }
    }
}
