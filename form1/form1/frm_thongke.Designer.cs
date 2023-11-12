
namespace form1
{
    partial class frm_thongke
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_thongke = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_thongkeSanpham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbx_nam = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thongke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thongkeSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_thongke
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_thongke.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_thongke.Legends.Add(legend3);
            this.chart_thongke.Location = new System.Drawing.Point(1, 80);
            this.chart_thongke.Name = "chart_thongke";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_thongke.Series.Add(series3);
            this.chart_thongke.Size = new System.Drawing.Size(564, 499);
            this.chart_thongke.TabIndex = 0;
            this.chart_thongke.Text = "chart1";
            // 
            // chart_thongkeSanpham
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_thongkeSanpham.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_thongkeSanpham.Legends.Add(legend4);
            this.chart_thongkeSanpham.Location = new System.Drawing.Point(571, 80);
            this.chart_thongkeSanpham.Name = "chart_thongkeSanpham";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_thongkeSanpham.Series.Add(series4);
            this.chart_thongkeSanpham.Size = new System.Drawing.Size(443, 499);
            this.chart_thongkeSanpham.TabIndex = 1;
            this.chart_thongkeSanpham.Text = "chart1";
            // 
            // cbx_nam
            // 
            this.cbx_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_nam.FormattingEnabled = true;
            this.cbx_nam.Location = new System.Drawing.Point(12, 34);
            this.cbx_nam.Name = "cbx_nam";
            this.cbx_nam.Size = new System.Drawing.Size(121, 40);
            this.cbx_nam.TabIndex = 2;
            this.cbx_nam.SelectedIndexChanged += new System.EventHandler(this.cbx_nam_SelectedIndexChanged);
            // 
            // frm_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 591);
            this.Controls.Add(this.cbx_nam);
            this.Controls.Add(this.chart_thongkeSanpham);
            this.Controls.Add(this.chart_thongke);
            this.Name = "frm_thongke";
            this.Text = "frm_thongke";
            this.Load += new System.EventHandler(this.frm_thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_thongke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_thongkeSanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_thongke;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_thongkeSanpham;
        private System.Windows.Forms.ComboBox cbx_nam;
    }
}