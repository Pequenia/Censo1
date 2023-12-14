using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Censo1
{
    public partial class Form1 : Form
    {
        private readonly MiDbContext dbContext = new MiDbContext();

        public Form1()
        {
            InitializeComponent();
            ConfigureForm();
            LoadData();
        }

        private void ConfigureForm()
        {
            this.AutoSize = false;
            this.Width = 800;
            this.Height = 600;
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadData()
        {
            try
            {
                var equipos = dbContext.InformacionEquipos.ToList();
                dgvCenso.DataSource = equipos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
