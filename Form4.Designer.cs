namespace Practica
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textuni = new System.Windows.Forms.TextBox();
            this.textcan = new System.Windows.Forms.TextBox();
            this.textdes = new System.Windows.Forms.TextBox();
            this.tablegrid = new System.Windows.Forms.DataGridView();
            this.idgrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripgrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadgrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadgrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calcConversionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasTrabajadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRestauranteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasLaboralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tablegrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unidad de Medida:";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(352, 71);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(182, 20);
            this.textid.TabIndex = 4;
            // 
            // textuni
            // 
            this.textuni.Location = new System.Drawing.Point(352, 181);
            this.textuni.Name = "textuni";
            this.textuni.Size = new System.Drawing.Size(182, 20);
            this.textuni.TabIndex = 5;
            // 
            // textcan
            // 
            this.textcan.Location = new System.Drawing.Point(352, 145);
            this.textcan.Name = "textcan";
            this.textcan.Size = new System.Drawing.Size(182, 20);
            this.textcan.TabIndex = 6;
            // 
            // textdes
            // 
            this.textdes.Location = new System.Drawing.Point(352, 107);
            this.textdes.Name = "textdes";
            this.textdes.Size = new System.Drawing.Size(182, 20);
            this.textdes.TabIndex = 7;
            // 
            // tablegrid
            // 
            this.tablegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablegrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgrid,
            this.descripgrid,
            this.cantidadgrid,
            this.unidadgrid});
            this.tablegrid.Location = new System.Drawing.Point(188, 264);
            this.tablegrid.Name = "tablegrid";
            this.tablegrid.Size = new System.Drawing.Size(441, 174);
            this.tablegrid.TabIndex = 8;
            // 
            // idgrid
            // 
            this.idgrid.HeaderText = "ID";
            this.idgrid.Name = "idgrid";
            // 
            // descripgrid
            // 
            this.descripgrid.HeaderText = "DESCRIPCION";
            this.descripgrid.Name = "descripgrid";
            // 
            // cantidadgrid
            // 
            this.cantidadgrid.HeaderText = "CANTIDAD";
            this.cantidadgrid.Name = "cantidadgrid";
            // 
            // unidadgrid
            // 
            this.unidadgrid.HeaderText = "UNIDAD DE MEDIDA";
            this.unidadgrid.Name = "unidadgrid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel1.Text = "Salir";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcConversionesToolStripMenuItem,
            this.unidadesDeMedidaToolStripMenuItem,
            this.horasTrabajadasToolStripMenuItem,
            this.menuRestauranteToolStripMenuItem,
            this.horasLaboralesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calcConversionesToolStripMenuItem
            // 
            this.calcConversionesToolStripMenuItem.Name = "calcConversionesToolStripMenuItem";
            this.calcConversionesToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.calcConversionesToolStripMenuItem.Text = "Calc. Conversiones";
            this.calcConversionesToolStripMenuItem.Click += new System.EventHandler(this.calcConversionesToolStripMenuItem_Click);
            // 
            // unidadesDeMedidaToolStripMenuItem
            // 
            this.unidadesDeMedidaToolStripMenuItem.Name = "unidadesDeMedidaToolStripMenuItem";
            this.unidadesDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.unidadesDeMedidaToolStripMenuItem.Text = "Unidades de Medida";
            this.unidadesDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadesDeMedidaToolStripMenuItem_Click);
            // 
            // horasTrabajadasToolStripMenuItem
            // 
            this.horasTrabajadasToolStripMenuItem.Name = "horasTrabajadasToolStripMenuItem";
            this.horasTrabajadasToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.horasTrabajadasToolStripMenuItem.Text = "Horas Trabajadas";
            this.horasTrabajadasToolStripMenuItem.Click += new System.EventHandler(this.horasTrabajadasToolStripMenuItem_Click);
            // 
            // menuRestauranteToolStripMenuItem
            // 
            this.menuRestauranteToolStripMenuItem.Name = "menuRestauranteToolStripMenuItem";
            this.menuRestauranteToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.menuRestauranteToolStripMenuItem.Text = "Menu Restaurante";
            this.menuRestauranteToolStripMenuItem.Click += new System.EventHandler(this.menuRestauranteToolStripMenuItem_Click);
            // 
            // horasLaboralesToolStripMenuItem
            // 
            this.horasLaboralesToolStripMenuItem.Name = "horasLaboralesToolStripMenuItem";
            this.horasLaboralesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.horasLaboralesToolStripMenuItem.Text = "Horas Laborales";
            this.horasLaboralesToolStripMenuItem.Click += new System.EventHandler(this.horasLaboralesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.salirToolStripMenuItem.Text = "Wil Smith";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tablegrid);
            this.Controls.Add(this.textdes);
            this.Controls.Add(this.textcan);
            this.Controls.Add(this.textuni);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Unidades de Medida";
            ((System.ComponentModel.ISupportInitialize)(this.tablegrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textuni;
        private System.Windows.Forms.TextBox textcan;
        private System.Windows.Forms.TextBox textdes;
        private System.Windows.Forms.DataGridView tablegrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadgrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calcConversionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadesDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasTrabajadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRestauranteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasLaboralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}