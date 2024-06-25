namespace Presentacion
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
            button1 = new Button();
            label1 = new Label();
            txtRol = new TextBox();
            dgvRoles = new DataGridView();
            txtBuscar = new TextBox();
            Buscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(489, 34);
            button1.Name = "button1";
            button1.Size = new Size(125, 46);
            button1.TabIndex = 0;
            button1.Text = "btnRegistrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 47);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre ROL";
            // 
            // txtRol
            // 
            txtRol.Location = new Point(277, 44);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(125, 27);
            txtRol.TabIndex = 2;
            // 
            // dgvRoles
            // 
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(127, 190);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.RowTemplate.Height = 29;
            dgvRoles.Size = new Size(487, 188);
            dgvRoles.TabIndex = 3;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(277, 157);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(337, 27);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // Buscar
            // 
            Buscar.AutoSize = true;
            Buscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Buscar.Location = new Point(127, 157);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(100, 20);
            Buscar.TabIndex = 5;
            Buscar.Text = "Nombre ROL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Buscar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvRoles);
            Controls.Add(txtRol);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtRol;
        private DataGridView dgvRoles;
        private TextBox txtBuscar;
        private Label Buscar;
    }
}
