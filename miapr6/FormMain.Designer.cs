namespace miapr6
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.bt_classificate = new System.Windows.Forms.Button();
            this.ch_main = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_distances = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_numberObjects = new System.Windows.Forms.TextBox();
            this.cb_minMax = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ch_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_distances)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_classificate
            // 
            this.bt_classificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_classificate.ForeColor = System.Drawing.Color.Green;
            this.bt_classificate.Location = new System.Drawing.Point(55, 248);
            this.bt_classificate.Name = "bt_classificate";
            this.bt_classificate.Size = new System.Drawing.Size(123, 33);
            this.bt_classificate.TabIndex = 0;
            this.bt_classificate.Text = "Classificate";
            this.bt_classificate.UseVisualStyleBackColor = true;
            this.bt_classificate.Click += new System.EventHandler(this.bt_classificate_Click);
            // 
            // ch_main
            // 
            this.ch_main.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.ch_main.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ch_main.Legends.Add(legend1);
            this.ch_main.Location = new System.Drawing.Point(251, 12);
            this.ch_main.Name = "ch_main";
            this.ch_main.Size = new System.Drawing.Size(412, 389);
            this.ch_main.TabIndex = 1;
            this.ch_main.Text = "chart1";
            // 
            // dgv_distances
            // 
            this.dgv_distances.AllowUserToAddRows = false;
            this.dgv_distances.BackgroundColor = System.Drawing.Color.White;
            this.dgv_distances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_distances.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_distances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_distances.ColumnHeadersVisible = false;
            this.dgv_distances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv_distances.Location = new System.Drawing.Point(8, 12);
            this.dgv_distances.Name = "dgv_distances";
            this.dgv_distances.RowHeadersVisible = false;
            this.dgv_distances.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv_distances.Size = new System.Drawing.Size(237, 176);
            this.dgv_distances.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 234;
            // 
            // tb_numberObjects
            // 
            this.tb_numberObjects.Location = new System.Drawing.Point(55, 209);
            this.tb_numberObjects.Name = "tb_numberObjects";
            this.tb_numberObjects.Size = new System.Drawing.Size(40, 20);
            this.tb_numberObjects.TabIndex = 3;
            // 
            // cb_minMax
            // 
            this.cb_minMax.FormattingEnabled = true;
            this.cb_minMax.Items.AddRange(new object[] {
            "min",
            "max"});
            this.cb_minMax.Location = new System.Drawing.Point(145, 209);
            this.cb_minMax.Name = "cb_minMax";
            this.cb_minMax.Size = new System.Drawing.Size(40, 21);
            this.cb_minMax.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(675, 413);
            this.Controls.Add(this.cb_minMax);
            this.Controls.Add(this.tb_numberObjects);
            this.Controls.Add(this.dgv_distances);
            this.Controls.Add(this.ch_main);
            this.Controls.Add(this.bt_classificate);
            this.Name = "FormMain";
            this.Text = "Hierarchical bucketing";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_distances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_classificate;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_main;
        private System.Windows.Forms.DataGridView dgv_distances;
        private System.Windows.Forms.TextBox tb_numberObjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox cb_minMax;
    }
}

