
namespace CarsDataBase
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDailyPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtModelYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtColorId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBrandId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCarId = new System.Windows.Forms.TextBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGraph = new System.Windows.Forms.Button();
            this.BtnStatistic = new System.Windows.Forms.Button();
            this.Btnupdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carDatabaseDataSet = new CarsDataBase.CarDatabaseDataSet();
            this.carDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDatabaseDataSet1 = new CarsDataBase.CarDatabaseDataSet1();
            this.tblCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CarsTableAdapter = new CarsDataBase.CarDatabaseDataSet1TableAdapters.Tbl_CarsTableAdapter();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtDailyPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtModelYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtColorId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBrandId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtCarId);
            this.groupBox1.Location = new System.Drawing.Point(36, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Save";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(157, 279);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(200, 35);
            this.TxtDescription.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "ColorId";
            // 
            // TxtDailyPrice
            // 
            this.TxtDailyPrice.Location = new System.Drawing.Point(157, 238);
            this.TxtDailyPrice.Name = "TxtDailyPrice";
            this.TxtDailyPrice.Size = new System.Drawing.Size(200, 35);
            this.TxtDailyPrice.TabIndex = 8;
            this.TxtDailyPrice.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Daily Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtModelYear
            // 
            this.TxtModelYear.Location = new System.Drawing.Point(157, 197);
            this.TxtModelYear.Name = "TxtModelYear";
            this.TxtModelYear.Size = new System.Drawing.Size(200, 35);
            this.TxtModelYear.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model Year";
            // 
            // TxtColorId
            // 
            this.TxtColorId.Location = new System.Drawing.Point(157, 156);
            this.TxtColorId.Name = "TxtColorId";
            this.TxtColorId.Size = new System.Drawing.Size(200, 35);
            this.TxtColorId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "BrandId";
            // 
            // TxtBrandId
            // 
            this.TxtBrandId.Location = new System.Drawing.Point(157, 115);
            this.TxtBrandId.Name = "TxtBrandId";
            this.TxtBrandId.Size = new System.Drawing.Size(200, 35);
            this.TxtBrandId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "CarId";
            // 
            // TxtCarId
            // 
            this.TxtCarId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtCarId.Location = new System.Drawing.Point(157, 74);
            this.TxtCarId.Name = "TxtCarId";
            this.TxtCarId.Size = new System.Drawing.Size(200, 35);
            this.TxtCarId.TabIndex = 0;
            this.TxtCarId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(121, 54);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(164, 38);
            this.BtnList.TabIndex = 1;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGraph);
            this.groupBox2.Controls.Add(this.BtnStatistic);
            this.groupBox2.Controls.Add(this.Btnupdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.BtnList);
            this.groupBox2.Location = new System.Drawing.Point(463, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 341);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnGraph
            // 
            this.BtnGraph.Location = new System.Drawing.Point(121, 274);
            this.BtnGraph.Name = "BtnGraph";
            this.BtnGraph.Size = new System.Drawing.Size(164, 38);
            this.BtnGraph.TabIndex = 6;
            this.BtnGraph.Text = "Graphs";
            this.BtnGraph.UseVisualStyleBackColor = true;
            // 
            // BtnStatistic
            // 
            this.BtnStatistic.Location = new System.Drawing.Point(121, 230);
            this.BtnStatistic.Name = "BtnStatistic";
            this.BtnStatistic.Size = new System.Drawing.Size(164, 38);
            this.BtnStatistic.TabIndex = 5;
            this.BtnStatistic.Text = "Statistic";
            this.BtnStatistic.UseVisualStyleBackColor = true;
            // 
            // Btnupdate
            // 
            this.Btnupdate.Location = new System.Drawing.Point(121, 186);
            this.Btnupdate.Name = "Btnupdate";
            this.Btnupdate.Size = new System.Drawing.Size(164, 38);
            this.Btnupdate.TabIndex = 4;
            this.Btnupdate.Text = "Update";
            this.Btnupdate.UseVisualStyleBackColor = true;
            this.Btnupdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(121, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(121, 98);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(164, 38);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(36, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(848, 217);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saves";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIdDataGridViewTextBoxColumn,
            this.brandIdDataGridViewTextBoxColumn,
            this.colorIdDataGridViewTextBoxColumn,
            this.modelYearDataGridViewTextBoxColumn,
            this.dailyPriceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCarsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // carDatabaseDataSet
            // 
            this.carDatabaseDataSet.DataSetName = "CarDatabaseDataSet";
            this.carDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carDatabaseDataSetBindingSource
            // 
            this.carDatabaseDataSetBindingSource.DataSource = this.carDatabaseDataSet;
            this.carDatabaseDataSetBindingSource.Position = 0;
            // 
            // carDatabaseDataSet1
            // 
            this.carDatabaseDataSet1.DataSetName = "CarDatabaseDataSet1";
            this.carDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCarsBindingSource
            // 
            this.tblCarsBindingSource.DataMember = "Tbl_Cars";
            this.tblCarsBindingSource.DataSource = this.carDatabaseDataSet1;
            // 
            // tbl_CarsTableAdapter
            // 
            this.tbl_CarsTableAdapter.ClearBeforeFill = true;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            this.carIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.carIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandIdDataGridViewTextBoxColumn
            // 
            this.brandIdDataGridViewTextBoxColumn.DataPropertyName = "BrandId";
            this.brandIdDataGridViewTextBoxColumn.HeaderText = "BrandId";
            this.brandIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandIdDataGridViewTextBoxColumn.Name = "brandIdDataGridViewTextBoxColumn";
            this.brandIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorIdDataGridViewTextBoxColumn
            // 
            this.colorIdDataGridViewTextBoxColumn.DataPropertyName = "ColorId";
            this.colorIdDataGridViewTextBoxColumn.HeaderText = "ColorId";
            this.colorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorIdDataGridViewTextBoxColumn.Name = "colorIdDataGridViewTextBoxColumn";
            this.colorIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelYearDataGridViewTextBoxColumn
            // 
            this.modelYearDataGridViewTextBoxColumn.DataPropertyName = "ModelYear";
            this.modelYearDataGridViewTextBoxColumn.HeaderText = "ModelYear";
            this.modelYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelYearDataGridViewTextBoxColumn.Name = "modelYearDataGridViewTextBoxColumn";
            this.modelYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // dailyPriceDataGridViewTextBoxColumn
            // 
            this.dailyPriceDataGridViewTextBoxColumn.DataPropertyName = "DailyPrice";
            this.dailyPriceDataGridViewTextBoxColumn.HeaderText = "DailyPrice";
            this.dailyPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dailyPriceDataGridViewTextBoxColumn.Name = "dailyPriceDataGridViewTextBoxColumn";
            this.dailyPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 612);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDailyPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtModelYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtColorId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBrandId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCarId;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGraph;
        private System.Windows.Forms.Button BtnStatistic;
        private System.Windows.Forms.Button Btnupdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carDatabaseDataSetBindingSource;
        private CarDatabaseDataSet carDatabaseDataSet;
        private CarDatabaseDataSet1 carDatabaseDataSet1;
        private System.Windows.Forms.BindingSource tblCarsBindingSource;
        private CarDatabaseDataSet1TableAdapters.Tbl_CarsTableAdapter tbl_CarsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}

