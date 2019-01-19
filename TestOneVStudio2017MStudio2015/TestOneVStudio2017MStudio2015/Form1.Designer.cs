namespace TestOneVStudio2017MStudio2015
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
            this.waveformGraph1 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.knob1 = new NationalInstruments.UI.WindowsForms.Knob();
            this.complexGraph1 = new NationalInstruments.UI.WindowsForms.ComplexGraph();
            this.complexXAxis1 = new NationalInstruments.UI.ComplexXAxis();
            this.complexYAxis1 = new NationalInstruments.UI.ComplexYAxis();
            this.complexPlot1 = new NationalInstruments.UI.ComplexPlot();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complexGraph1)).BeginInit();
            this.SuspendLayout();
            // 
            // waveformGraph1
            // 
            this.waveformGraph1.Location = new System.Drawing.Point(154, 12);
            this.waveformGraph1.Name = "waveformGraph1";
            this.waveformGraph1.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph1.Size = new System.Drawing.Size(460, 259);
            this.waveformGraph1.TabIndex = 0;
            this.waveformGraph1.UseColorGenerator = true;
            this.waveformGraph1.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph1.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // knob1
            // 
            this.knob1.Location = new System.Drawing.Point(22, 12);
            this.knob1.Name = "knob1";
            this.knob1.Size = new System.Drawing.Size(109, 109);
            this.knob1.TabIndex = 1;
            // 
            // complexGraph1
            // 
            this.complexGraph1.Location = new System.Drawing.Point(154, 286);
            this.complexGraph1.Name = "complexGraph1";
            this.complexGraph1.Plots.AddRange(new NationalInstruments.UI.ComplexPlot[] {
            this.complexPlot1});
            this.complexGraph1.Size = new System.Drawing.Size(459, 148);
            this.complexGraph1.TabIndex = 2;
            this.complexGraph1.UseColorGenerator = true;
            this.complexGraph1.XAxes.AddRange(new NationalInstruments.UI.ComplexXAxis[] {
            this.complexXAxis1});
            this.complexGraph1.YAxes.AddRange(new NationalInstruments.UI.ComplexYAxis[] {
            this.complexYAxis1});
            // 
            // complexPlot1
            // 
            this.complexPlot1.XAxis = this.complexXAxis1;
            this.complexPlot1.YAxis = this.complexYAxis1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.complexGraph1);
            this.Controls.Add(this.knob1);
            this.Controls.Add(this.waveformGraph1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complexGraph1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WindowsForms.Knob knob1;
        private NationalInstruments.UI.WindowsForms.ComplexGraph complexGraph1;
        private NationalInstruments.UI.ComplexPlot complexPlot1;
        private NationalInstruments.UI.ComplexXAxis complexXAxis1;
        private NationalInstruments.UI.ComplexYAxis complexYAxis1;
    }
}

