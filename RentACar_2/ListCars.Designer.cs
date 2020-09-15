namespace RentACar_2
{
    partial class ListCars
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
            this.sPListCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentACar_2DataSet = new RentACar_2.RentACar_2DataSet();
            this.sP_ListCarTableAdapter = new RentACar_2.RentACar_2DataSetTableAdapters.SP_ListCarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sPListCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACar_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sPListCarBindingSource
            // 
            this.sPListCarBindingSource.DataMember = "SP_ListCar";
            this.sPListCarBindingSource.DataSource = this.rentACar_2DataSet;
            // 
            // rentACar_2DataSet
            // 
            this.rentACar_2DataSet.DataSetName = "RentACar_2DataSet";
            this.rentACar_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_ListCarTableAdapter
            // 
            this.sP_ListCarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(726, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ListCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListCars";
            this.Text = "Araçlar";
            this.Load += new System.EventHandler(this.ListCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPListCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACar_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RentACar_2DataSet rentACar_2DataSet;
        private System.Windows.Forms.BindingSource sPListCarBindingSource;
        private RentACar_2DataSetTableAdapters.SP_ListCarTableAdapter sP_ListCarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}