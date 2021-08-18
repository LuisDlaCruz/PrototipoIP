
namespace Polideportivo.Vista
{
    partial class formCompras
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prototipoipDataSet = new Polideportivo.prototipoipDataSet();
            this.comprasdetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compras_detalleTableAdapter = new Polideportivo.prototipoipDataSetTableAdapters.compras_detalleTableAdapter();
            this.documentocompraencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadcompradetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costocompradetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigobodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototipoipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasdetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentocompraencaDataGridViewTextBoxColumn,
            this.codigoproductoDataGridViewTextBoxColumn,
            this.cantidadcompradetDataGridViewTextBoxColumn,
            this.costocompradetDataGridViewTextBoxColumn,
            this.codigobodegaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comprasdetalleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(102, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // prototipoipDataSet
            // 
            this.prototipoipDataSet.DataSetName = "prototipoipDataSet";
            this.prototipoipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comprasdetalleBindingSource
            // 
            this.comprasdetalleBindingSource.DataMember = "compras_detalle";
            this.comprasdetalleBindingSource.DataSource = this.prototipoipDataSet;
            // 
            // compras_detalleTableAdapter
            // 
            this.compras_detalleTableAdapter.ClearBeforeFill = true;
            // 
            // documentocompraencaDataGridViewTextBoxColumn
            // 
            this.documentocompraencaDataGridViewTextBoxColumn.DataPropertyName = "documento_compraenca";
            this.documentocompraencaDataGridViewTextBoxColumn.HeaderText = "documento_compraenca";
            this.documentocompraencaDataGridViewTextBoxColumn.Name = "documentocompraencaDataGridViewTextBoxColumn";
            // 
            // codigoproductoDataGridViewTextBoxColumn
            // 
            this.codigoproductoDataGridViewTextBoxColumn.DataPropertyName = "codigo_producto";
            this.codigoproductoDataGridViewTextBoxColumn.HeaderText = "codigo_producto";
            this.codigoproductoDataGridViewTextBoxColumn.Name = "codigoproductoDataGridViewTextBoxColumn";
            // 
            // cantidadcompradetDataGridViewTextBoxColumn
            // 
            this.cantidadcompradetDataGridViewTextBoxColumn.DataPropertyName = "cantidad_compradet";
            this.cantidadcompradetDataGridViewTextBoxColumn.HeaderText = "cantidad_compradet";
            this.cantidadcompradetDataGridViewTextBoxColumn.Name = "cantidadcompradetDataGridViewTextBoxColumn";
            // 
            // costocompradetDataGridViewTextBoxColumn
            // 
            this.costocompradetDataGridViewTextBoxColumn.DataPropertyName = "costo_compradet";
            this.costocompradetDataGridViewTextBoxColumn.HeaderText = "costo_compradet";
            this.costocompradetDataGridViewTextBoxColumn.Name = "costocompradetDataGridViewTextBoxColumn";
            // 
            // codigobodegaDataGridViewTextBoxColumn
            // 
            this.codigobodegaDataGridViewTextBoxColumn.DataPropertyName = "codigo_bodega";
            this.codigobodegaDataGridViewTextBoxColumn.HeaderText = "codigo_bodega";
            this.codigobodegaDataGridViewTextBoxColumn.Name = "codigobodegaDataGridViewTextBoxColumn";
            // 
            // formCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formCompras";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prototipoipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasdetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private prototipoipDataSet prototipoipDataSet;
        private System.Windows.Forms.BindingSource comprasdetalleBindingSource;
        private prototipoipDataSetTableAdapters.compras_detalleTableAdapter compras_detalleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentocompraencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadcompradetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costocompradetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigobodegaDataGridViewTextBoxColumn;
    }
}