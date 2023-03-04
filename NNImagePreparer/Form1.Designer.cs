namespace NNImagePreparer
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.inPathBox = new System.Windows.Forms.TextBox();
			this.selectInputPathButton = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.selectOutputPathButton = new System.Windows.Forms.Button();
			this.outPathBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.resolutionXUpDown = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.resolutionYUpDown = new System.Windows.Forms.NumericUpDown();
			this.cropCheckBox = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.totalFilesLabel = new System.Windows.Forms.Label();
			this.startButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.resolutionXUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.resolutionYUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// inPathBox
			// 
			this.inPathBox.Enabled = false;
			this.inPathBox.Location = new System.Drawing.Point(12, 12);
			this.inPathBox.Name = "inPathBox";
			this.inPathBox.Size = new System.Drawing.Size(497, 23);
			this.inPathBox.TabIndex = 0;
			// 
			// selectInputPathButton
			// 
			this.selectInputPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.selectInputPathButton.Location = new System.Drawing.Point(515, 12);
			this.selectInputPathButton.Name = "selectInputPathButton";
			this.selectInputPathButton.Size = new System.Drawing.Size(140, 23);
			this.selectInputPathButton.TabIndex = 1;
			this.selectInputPathButton.Text = "Select input root";
			this.selectInputPathButton.UseVisualStyleBackColor = true;
			this.selectInputPathButton.Click += new System.EventHandler(this.OpenInputFileDialogBtn_Click);
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(12, 259);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(643, 23);
			this.progressBar.TabIndex = 2;
			// 
			// selectOutputPathButton
			// 
			this.selectOutputPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.selectOutputPathButton.Location = new System.Drawing.Point(515, 41);
			this.selectOutputPathButton.Name = "selectOutputPathButton";
			this.selectOutputPathButton.Size = new System.Drawing.Size(140, 23);
			this.selectOutputPathButton.TabIndex = 4;
			this.selectOutputPathButton.Text = "Select output root";
			this.selectOutputPathButton.UseVisualStyleBackColor = true;
			this.selectOutputPathButton.Click += new System.EventHandler(this.OpenOutputFileDialogBtn_Click);
			// 
			// outPathBox
			// 
			this.outPathBox.Enabled = false;
			this.outPathBox.Location = new System.Drawing.Point(12, 41);
			this.outPathBox.Name = "outPathBox";
			this.outPathBox.Size = new System.Drawing.Size(497, 23);
			this.outPathBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Total image files:";
			// 
			// resolutionXUpDown
			// 
			this.resolutionXUpDown.Location = new System.Drawing.Point(113, 105);
			this.resolutionXUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.resolutionXUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.resolutionXUpDown.Name = "resolutionXUpDown";
			this.resolutionXUpDown.Size = new System.Drawing.Size(63, 23);
			this.resolutionXUpDown.TabIndex = 6;
			this.resolutionXUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Target resolution";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(182, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "x";
			// 
			// resolutionYUpDown
			// 
			this.resolutionYUpDown.Location = new System.Drawing.Point(201, 105);
			this.resolutionYUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.resolutionYUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.resolutionYUpDown.Name = "resolutionYUpDown";
			this.resolutionYUpDown.Size = new System.Drawing.Size(63, 23);
			this.resolutionYUpDown.TabIndex = 10;
			this.resolutionYUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
			// 
			// cropCheckBox
			// 
			this.cropCheckBox.AutoSize = true;
			this.cropCheckBox.Location = new System.Drawing.Point(12, 137);
			this.cropCheckBox.Name = "cropCheckBox";
			this.cropCheckBox.Size = new System.Drawing.Size(101, 19);
			this.cropCheckBox.TabIndex = 11;
			this.cropCheckBox.Text = "Use cropping?";
			this.cropCheckBox.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 241);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 15);
			this.label3.TabIndex = 12;
			this.label3.Text = "Progress:";
			// 
			// totalFilesLabel
			// 
			this.totalFilesLabel.AutoSize = true;
			this.totalFilesLabel.Location = new System.Drawing.Point(113, 83);
			this.totalFilesLabel.Name = "totalFilesLabel";
			this.totalFilesLabel.Size = new System.Drawing.Size(13, 15);
			this.totalFilesLabel.TabIndex = 13;
			this.totalFilesLabel.Text = "0";
			// 
			// startButton
			// 
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.startButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.startButton.Location = new System.Drawing.Point(12, 180);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(164, 49);
			this.startButton.TabIndex = 14;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 294);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.totalFilesLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cropCheckBox);
			this.Controls.Add(this.resolutionYUpDown);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.resolutionXUpDown);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.selectOutputPathButton);
			this.Controls.Add(this.outPathBox);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.selectInputPathButton);
			this.Controls.Add(this.inPathBox);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.resolutionXUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.resolutionYUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox inPathBox;
		private Button selectInputPathButton;
		private ProgressBar progressBar;
		private Button selectOutputPathButton;
		private TextBox outPathBox;
		private Label label1;
		private NumericUpDown resolutionXUpDown;
		private Label label2;
		private Label label4;
		private NumericUpDown resolutionYUpDown;
		private CheckBox cropCheckBox;
		private Label label3;
		private Label totalFilesLabel;
		private Button startButton;
	}
}