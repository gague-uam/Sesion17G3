namespace Sesion17G3
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblID = new System.Windows.Forms.Label();
            this.TbID = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescr = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.DgvRegistros = new System.Windows.Forms.DataGridView();
            this.GbGrupos = new System.Windows.Forms.GroupBox();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.TbPrecio = new System.Windows.Forms.TextBox();
            this.TbDescp = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.BtnMostrar = new System.Windows.Forms.ToolStripButton();
            this.BtnEliminar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistros)).BeginInit();
            this.GbGrupos.SuspendLayout();
            this.gbProducto.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(53, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Codigo:";
            // 
            // TbID
            // 
            this.TbID.Location = new System.Drawing.Point(102, 29);
            this.TbID.Name = "TbID";
            this.TbID.Size = new System.Drawing.Size(100, 20);
            this.TbID.TabIndex = 1;
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(102, 55);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(100, 20);
            this.TbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Location = new System.Drawing.Point(28, 88);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(66, 13);
            this.lblDescr.TabIndex = 4;
            this.lblDescr.Text = "Descripcion:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(56, 194);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // DgvRegistros
            // 
            this.DgvRegistros.AllowUserToAddRows = false;
            this.DgvRegistros.AllowUserToDeleteRows = false;
            this.DgvRegistros.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegistros.Location = new System.Drawing.Point(21, 19);
            this.DgvRegistros.Name = "DgvRegistros";
            this.DgvRegistros.ReadOnly = true;
            this.DgvRegistros.Size = new System.Drawing.Size(721, 200);
            this.DgvRegistros.TabIndex = 7;
            // 
            // GbGrupos
            // 
            this.GbGrupos.Controls.Add(this.DgvRegistros);
            this.GbGrupos.Location = new System.Drawing.Point(27, 273);
            this.GbGrupos.Name = "GbGrupos";
            this.GbGrupos.Size = new System.Drawing.Size(758, 238);
            this.GbGrupos.TabIndex = 8;
            this.GbGrupos.TabStop = false;
            this.GbGrupos.Text = "Registro de Datos";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.TbPrecio);
            this.gbProducto.Controls.Add(this.TbDescp);
            this.gbProducto.Controls.Add(this.lblPrecio);
            this.gbProducto.Controls.Add(this.lblDescr);
            this.gbProducto.Controls.Add(this.label2);
            this.gbProducto.Controls.Add(this.TbNombre);
            this.gbProducto.Controls.Add(this.TbID);
            this.gbProducto.Controls.Add(this.lblID);
            this.gbProducto.Location = new System.Drawing.Point(27, 33);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(300, 218);
            this.gbProducto.TabIndex = 9;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Datos Generales";
            // 
            // TbPrecio
            // 
            this.TbPrecio.Location = new System.Drawing.Point(102, 191);
            this.TbPrecio.Name = "TbPrecio";
            this.TbPrecio.Size = new System.Drawing.Size(100, 20);
            this.TbPrecio.TabIndex = 8;
            // 
            // TbDescp
            // 
            this.TbDescp.Location = new System.Drawing.Point(100, 85);
            this.TbDescp.Multiline = true;
            this.TbDescp.Name = "TbDescp";
            this.TbDescp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbDescp.Size = new System.Drawing.Size(194, 86);
            this.TbDescp.TabIndex = 7;
            this.TbDescp.UseWaitCursor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnGuardar,
            this.BtnMostrar,
            this.BtnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(831, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(23, 22);
            this.BtnGuardar.Text = "toolStripButton1";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMostrar.Image")));
            this.BtnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(23, 22);
            this.BtnMostrar.Text = "toolStripButton2";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(23, 22);
            this.BtnEliminar.Text = "toolStripButton3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 556);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.GbGrupos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistros)).EndInit();
            this.GbGrupos.ResumeLayout(false);
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox TbID;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.DataGridView DgvRegistros;
        private System.Windows.Forms.GroupBox GbGrupos;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.TextBox TbPrecio;
        private System.Windows.Forms.TextBox TbDescp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnGuardar;
        private System.Windows.Forms.ToolStripButton BtnMostrar;
        private System.Windows.Forms.ToolStripButton BtnEliminar;
    }
}

