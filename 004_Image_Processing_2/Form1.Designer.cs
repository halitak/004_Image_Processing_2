namespace _004_Image_Processing_2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextboxBrightness = new System.Windows.Forms.ToolStripTextBox();
            this.btnBrightness = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextboxContrast = new System.Windows.Forms.ToolStripTextBox();
            this.btnContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNormalize = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHistogram = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReverseX = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReverseY = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textboxDegress = new System.Windows.Forms.ToolStripTextBox();
            this.btnRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textboxShift = new System.Windows.Forms.ToolStripTextBox();
            this.btnShift = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnZoomIn2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.ToolStripMenuItem();
            this.loadChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadChartRGB = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadChartGray = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stretchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textboxTreshold = new System.Windows.Forms.ToolStripTextBox();
            this.btnTresholding = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOtsu = new System.Windows.Forms.ToolStripMenuItem();
            this.textboxStretching = new System.Windows.Forms.ToolStripTextBox();
            this.btnStretching = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 287);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.pixelToolStripMenuItem,
            this.btnClear,
            this.loadChartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.btnNormalize,
            this.btnHistogram,
            this.stretchingToolStripMenuItem,
            this.ımageToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.ınvertToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // ınvertToolStripMenuItem
            // 
            this.ınvertToolStripMenuItem.Name = "ınvertToolStripMenuItem";
            this.ınvertToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.ınvertToolStripMenuItem.Text = "Invert";
            this.ınvertToolStripMenuItem.Click += new System.EventHandler(this.ınvertToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextboxBrightness,
            this.btnBrightness});
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            // 
            // TextboxBrightness
            // 
            this.TextboxBrightness.Name = "TextboxBrightness";
            this.TextboxBrightness.Size = new System.Drawing.Size(100, 23);
            // 
            // btnBrightness
            // 
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(160, 22);
            this.btnBrightness.Text = "Go";
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextboxContrast,
            this.btnContrast});
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.contrastToolStripMenuItem.Text = "Contrast";
            // 
            // TextboxContrast
            // 
            this.TextboxContrast.Name = "TextboxContrast";
            this.TextboxContrast.Size = new System.Drawing.Size(100, 23);
            // 
            // btnContrast
            // 
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(160, 22);
            this.btnContrast.Text = "Go";
            this.btnContrast.Click += new System.EventHandler(this.btnContrast_Click);
            // 
            // btnNormalize
            // 
            this.btnNormalize.Name = "btnNormalize";
            this.btnNormalize.Size = new System.Drawing.Size(197, 22);
            this.btnNormalize.Text = "Normalize";
            this.btnNormalize.Click += new System.EventHandler(this.btnNormalize_Click);
            // 
            // btnHistogram
            // 
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(197, 22);
            this.btnHistogram.Text = "Histogram equalization";
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // pixelToolStripMenuItem
            // 
            this.pixelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reverseToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.shiftToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.pixelToolStripMenuItem.Name = "pixelToolStripMenuItem";
            this.pixelToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.pixelToolStripMenuItem.Text = "Pixel";
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReverseX,
            this.btnReverseY});
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.reverseToolStripMenuItem.Text = "Reverse";
            // 
            // btnReverseX
            // 
            this.btnReverseX.Name = "btnReverseX";
            this.btnReverseX.Size = new System.Drawing.Size(81, 22);
            this.btnReverseX.Text = "X";
            this.btnReverseX.Click += new System.EventHandler(this.btnReverseX_Click);
            // 
            // btnReverseY
            // 
            this.btnReverseY.Name = "btnReverseY";
            this.btnReverseY.Size = new System.Drawing.Size(81, 22);
            this.btnReverseY.Text = "Y";
            this.btnReverseY.Click += new System.EventHandler(this.btnReverseY_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textboxDegress,
            this.btnRotate});
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // textboxDegress
            // 
            this.textboxDegress.Name = "textboxDegress";
            this.textboxDegress.Size = new System.Drawing.Size(100, 23);
            // 
            // btnRotate
            // 
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(160, 22);
            this.btnRotate.Text = "Go";
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // shiftToolStripMenuItem
            // 
            this.shiftToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textboxShift,
            this.btnShift});
            this.shiftToolStripMenuItem.Name = "shiftToolStripMenuItem";
            this.shiftToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.shiftToolStripMenuItem.Text = "Shift";
            // 
            // textboxShift
            // 
            this.textboxShift.Name = "textboxShift";
            this.textboxShift.Size = new System.Drawing.Size(100, 23);
            // 
            // btnShift
            // 
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(160, 22);
            this.btnShift.Text = "Do";
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZoomIn,
            this.btnZoomOut,
            this.btnZoomIn2});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(95, 22);
            this.btnZoomIn.Text = "In";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(95, 22);
            this.btnZoomOut.Text = "Out";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn2
            // 
            this.btnZoomIn2.Name = "btnZoomIn2";
            this.btnZoomIn2.Size = new System.Drawing.Size(95, 22);
            this.btnZoomIn2.Text = "In-2";
            this.btnZoomIn2.Click += new System.EventHandler(this.btnZoomIn2_Click);
            // 
            // btnClear
            // 
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(46, 20);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // loadChartToolStripMenuItem
            // 
            this.loadChartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadChartRGB,
            this.btnLoadChartGray});
            this.loadChartToolStripMenuItem.Name = "loadChartToolStripMenuItem";
            this.loadChartToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.loadChartToolStripMenuItem.Text = "Load Chart";
            // 
            // btnLoadChartRGB
            // 
            this.btnLoadChartRGB.Name = "btnLoadChartRGB";
            this.btnLoadChartRGB.Size = new System.Drawing.Size(98, 22);
            this.btnLoadChartRGB.Text = "RGB";
            this.btnLoadChartRGB.Click += new System.EventHandler(this.btnLoadChartRGB_Click_1);
            // 
            // btnLoadChartGray
            // 
            this.btnLoadChartGray.Name = "btnLoadChartGray";
            this.btnLoadChartGray.Size = new System.Drawing.Size(98, 22);
            this.btnLoadChartGray.Text = "Gray";
            this.btnLoadChartGray.Click += new System.EventHandler(this.btnLoadChartGray_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 321);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Red";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Green";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1252, 335);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(13, 321);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Gray;
            series4.Legend = "Legend1";
            series4.Name = "Gray";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(1252, 335);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
            // 
            // stretchingToolStripMenuItem
            // 
            this.stretchingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textboxStretching,
            this.btnStretching});
            this.stretchingToolStripMenuItem.Name = "stretchingToolStripMenuItem";
            this.stretchingToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.stretchingToolStripMenuItem.Text = "Histogram stretching";
            // 
            // ımageToolStripMenuItem
            // 
            this.ımageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textboxTreshold,
            this.btnTresholding,
            this.toolStripSeparator1,
            this.btnOtsu});
            this.ımageToolStripMenuItem.Name = "ımageToolStripMenuItem";
            this.ımageToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ımageToolStripMenuItem.Text = "Image Tresholding";
            // 
            // textboxTreshold
            // 
            this.textboxTreshold.Name = "textboxTreshold";
            this.textboxTreshold.Size = new System.Drawing.Size(100, 23);
            // 
            // btnTresholding
            // 
            this.btnTresholding.Name = "btnTresholding";
            this.btnTresholding.Size = new System.Drawing.Size(160, 22);
            this.btnTresholding.Text = "Do";
            this.btnTresholding.Click += new System.EventHandler(this.btnTresholding_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // btnOtsu
            // 
            this.btnOtsu.Name = "btnOtsu";
            this.btnOtsu.Size = new System.Drawing.Size(160, 22);
            this.btnOtsu.Text = "With Otsu";
            this.btnOtsu.Click += new System.EventHandler(this.btnOtsu_Click);
            // 
            // textboxStretching
            // 
            this.textboxStretching.Name = "textboxStretching";
            this.textboxStretching.Size = new System.Drawing.Size(100, 23);
            // 
            // btnStretching
            // 
            this.btnStretching.Name = "btnStretching";
            this.btnStretching.Size = new System.Drawing.Size(160, 22);
            this.btnStretching.Text = "Do";
            this.btnStretching.Click += new System.EventHandler(this.btnStretching_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 668);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TextboxBrightness;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TextboxContrast;
        private System.Windows.Forms.ToolStripMenuItem btnBrightness;
        private System.Windows.Forms.ToolStripMenuItem btnContrast;
        private System.Windows.Forms.ToolStripMenuItem btnNormalize;
        private System.Windows.Forms.ToolStripMenuItem reverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnReverseX;
        private System.Windows.Forms.ToolStripMenuItem btnReverseY;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox textboxDegress;
        private System.Windows.Forms.ToolStripMenuItem btnRotate;
        private System.Windows.Forms.ToolStripMenuItem btnClear;
        private System.Windows.Forms.ToolStripMenuItem shiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox textboxShift;
        private System.Windows.Forms.ToolStripMenuItem btnShift;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnZoomIn;
        private System.Windows.Forms.ToolStripMenuItem btnZoomOut;
        private System.Windows.Forms.ToolStripMenuItem btnZoomIn2;
        private System.Windows.Forms.ToolStripMenuItem loadChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLoadChartRGB;
        private System.Windows.Forms.ToolStripMenuItem btnLoadChartGray;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ToolStripMenuItem btnHistogram;
        private System.Windows.Forms.ToolStripMenuItem stretchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ımageToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox textboxTreshold;
        private System.Windows.Forms.ToolStripMenuItem btnTresholding;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnOtsu;
        private System.Windows.Forms.ToolStripTextBox textboxStretching;
        private System.Windows.Forms.ToolStripMenuItem btnStretching;
    }
}

