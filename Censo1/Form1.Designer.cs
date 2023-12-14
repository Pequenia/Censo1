namespace Censo1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCenso = new DataGridView();
            cbLinea = new ComboBox();
            lbLinea = new Label();
            btnAgregar = new Button();
            lbTitulo = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            manualDeUsuaruiToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            respaldosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvCenso).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCenso
            // 
            dgvCenso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCenso.Location = new Point(48, 127);
            dgvCenso.Name = "dgvCenso";
            dgvCenso.RowHeadersWidth = 51;
            dgvCenso.RowTemplate.Height = 29;
            dgvCenso.Size = new Size(1073, 468);
            dgvCenso.TabIndex = 0;
            // 
            // cbLinea
            // 
            cbLinea.FormattingEnabled = true;
            cbLinea.Location = new Point(101, 66);
            cbLinea.Name = "cbLinea";
            cbLinea.Size = new Size(219, 28);
            cbLinea.TabIndex = 1;
            // 
            // lbLinea
            // 
            lbLinea.AutoSize = true;
            lbLinea.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbLinea.Location = new Point(48, 65);
            lbLinea.Name = "lbLinea";
            lbLinea.Size = new Size(52, 25);
            lbLinea.TabIndex = 2;
            lbLinea.Text = "Linea";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1027, 65);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            lbTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitulo.Location = new Point(541, 28);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(93, 38);
            lbTitulo.TabIndex = 4;
            lbTitulo.Text = "Censo";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1183, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { respaldosToolStripMenuItem, ayudaToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualDeUsuaruiToolStripMenuItem, acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(160, 26);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuaruiToolStripMenuItem
            // 
            manualDeUsuaruiToolStripMenuItem.Name = "manualDeUsuaruiToolStripMenuItem";
            manualDeUsuaruiToolStripMenuItem.Size = new Size(224, 26);
            manualDeUsuaruiToolStripMenuItem.Text = "Manual de usuario";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(224, 26);
            acercaDeToolStripMenuItem.Text = "Acerca de:";
            // 
            // respaldosToolStripMenuItem
            // 
            respaldosToolStripMenuItem.Name = "respaldosToolStripMenuItem";
            respaldosToolStripMenuItem.Size = new Size(160, 26);
            respaldosToolStripMenuItem.Text = "Respaldos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 644);
            Controls.Add(lbTitulo);
            Controls.Add(btnAgregar);
            Controls.Add(lbLinea);
            Controls.Add(cbLinea);
            Controls.Add(dgvCenso);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCenso).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCenso;
        private ComboBox cbLinea;
        private Label lbLinea;
        private Button btnAgregar;
        private Label lbTitulo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem respaldosToolStripMenuItem;
        private ToolStripMenuItem manualDeUsuaruiToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}