
namespace Presentacion
{
    partial class FmrCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrCatalogo));
            this.panelArriba = new System.Windows.Forms.Panel();
            this.ptbRestaurar = new System.Windows.Forms.PictureBox();
            this.ptbMinimizar = new System.Windows.Forms.PictureBox();
            this.ptbMaximizar = new System.Windows.Forms.PictureBox();
            this.ptbCerrar = new System.Windows.Forms.PictureBox();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.ptbImagenes = new System.Windows.Forms.PictureBox();
            this.dgvTablaBD = new System.Windows.Forms.DataGridView();
            this.panelArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaBD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelArriba
            // 
            this.panelArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.panelArriba.Controls.Add(this.ptbRestaurar);
            this.panelArriba.Controls.Add(this.ptbMinimizar);
            this.panelArriba.Controls.Add(this.ptbMaximizar);
            this.panelArriba.Controls.Add(this.ptbCerrar);
            this.panelArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArriba.Location = new System.Drawing.Point(0, 0);
            this.panelArriba.Name = "panelArriba";
            this.panelArriba.Size = new System.Drawing.Size(1015, 58);
            this.panelArriba.TabIndex = 0;
            this.panelArriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelArriba_MouseDown);
            // 
            // ptbRestaurar
            // 
            this.ptbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("ptbRestaurar.Image")));
            this.ptbRestaurar.Location = new System.Drawing.Point(943, 0);
            this.ptbRestaurar.Name = "ptbRestaurar";
            this.ptbRestaurar.Size = new System.Drawing.Size(33, 33);
            this.ptbRestaurar.TabIndex = 3;
            this.ptbRestaurar.TabStop = false;
            this.ptbRestaurar.Visible = false;
            this.ptbRestaurar.Click += new System.EventHandler(this.ptbRestaurar_Click);
            // 
            // ptbMinimizar
            // 
            this.ptbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinimizar.Image")));
            this.ptbMinimizar.Location = new System.Drawing.Point(904, 0);
            this.ptbMinimizar.Name = "ptbMinimizar";
            this.ptbMinimizar.Size = new System.Drawing.Size(33, 33);
            this.ptbMinimizar.TabIndex = 4;
            this.ptbMinimizar.TabStop = false;
            this.ptbMinimizar.Click += new System.EventHandler(this.ptbMinimizar_Click);
            // 
            // ptbMaximizar
            // 
            this.ptbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaximizar.Image")));
            this.ptbMaximizar.Location = new System.Drawing.Point(943, 0);
            this.ptbMaximizar.Name = "ptbMaximizar";
            this.ptbMaximizar.Size = new System.Drawing.Size(33, 33);
            this.ptbMaximizar.TabIndex = 5;
            this.ptbMaximizar.TabStop = false;
            this.ptbMaximizar.Click += new System.EventHandler(this.ptbMaximizar_Click);
            // 
            // ptbCerrar
            // 
            this.ptbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCerrar.Image")));
            this.ptbCerrar.Location = new System.Drawing.Point(982, 0);
            this.ptbCerrar.Name = "ptbCerrar";
            this.ptbCerrar.Size = new System.Drawing.Size(33, 33);
            this.ptbCerrar.TabIndex = 2;
            this.ptbCerrar.TabStop = false;
            this.ptbCerrar.Click += new System.EventHandler(this.ptbCerrar_Click);
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 58);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(183, 408);
            this.panelIzquierdo.TabIndex = 1;
            // 
            // ptbImagenes
            // 
            this.ptbImagenes.Location = new System.Drawing.Point(740, 64);
            this.ptbImagenes.Name = "ptbImagenes";
            this.ptbImagenes.Size = new System.Drawing.Size(246, 292);
            this.ptbImagenes.TabIndex = 2;
            this.ptbImagenes.TabStop = false;
            // 
            // dgvTablaBD
            // 
            this.dgvTablaBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaBD.Location = new System.Drawing.Point(189, 64);
            this.dgvTablaBD.Name = "dgvTablaBD";
            this.dgvTablaBD.Size = new System.Drawing.Size(545, 292);
            this.dgvTablaBD.TabIndex = 3;
            // 
            // FmrCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1015, 466);
            this.Controls.Add(this.dgvTablaBD);
            this.Controls.Add(this.ptbImagenes);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.panelArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.FmrCatalogo_Load);
            this.panelArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelArriba;
        private System.Windows.Forms.PictureBox ptbRestaurar;
        private System.Windows.Forms.PictureBox ptbMinimizar;
        private System.Windows.Forms.PictureBox ptbMaximizar;
        private System.Windows.Forms.PictureBox ptbCerrar;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.PictureBox ptbImagenes;
        private System.Windows.Forms.DataGridView dgvTablaBD;
    }
}