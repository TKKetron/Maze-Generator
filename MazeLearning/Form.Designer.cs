
namespace MazeLearning
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frame = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMakeRoom = new System.Windows.Forms.Button();
            this.buttonRAND = new System.Windows.Forms.Button();
            this.buttonClearSolver = new System.Windows.Forms.Button();
            this.buttonFinishPath = new System.Windows.Forms.Button();
            this.buttonFindPath = new System.Windows.Forms.Button();
            this.labelStartY = new System.Windows.Forms.Label();
            this.labelStartX = new System.Windows.Forms.Label();
            this.labelEndY = new System.Windows.Forms.Label();
            this.startXCounter = new System.Windows.Forms.NumericUpDown();
            this.labelEndX = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.endYCounter = new System.Windows.Forms.NumericUpDown();
            this.endXCounter = new System.Windows.Forms.NumericUpDown();
            this.startYCounter = new System.Windows.Forms.NumericUpDown();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.MazeType = new System.Windows.Forms.ComboBox();
            this.labelSpeedValue = new System.Windows.Forms.Label();
            this.labelSeed = new System.Windows.Forms.Label();
            this.speedSlider = new System.Windows.Forms.TrackBar();
            this.heightCounter = new System.Windows.Forms.NumericUpDown();
            this.widthCounter = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonAddItems = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startXCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endYCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endXCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startYCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.frame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 1041);
            this.panel1.TabIndex = 8;
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.DimGray;
            this.frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frame.Location = new System.Drawing.Point(0, 0);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(1904, 1041);
            this.frame.TabIndex = 1;
            this.frame.TabStop = false;
            this.frame.Paint += new System.Windows.Forms.PaintEventHandler(this.frame_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAddItems);
            this.panel2.Controls.Add(this.buttonMakeRoom);
            this.panel2.Controls.Add(this.buttonRAND);
            this.panel2.Controls.Add(this.buttonClearSolver);
            this.panel2.Controls.Add(this.buttonFinishPath);
            this.panel2.Controls.Add(this.buttonFindPath);
            this.panel2.Controls.Add(this.labelStartY);
            this.panel2.Controls.Add(this.labelStartX);
            this.panel2.Controls.Add(this.labelEndY);
            this.panel2.Controls.Add(this.startXCounter);
            this.panel2.Controls.Add(this.labelEndX);
            this.panel2.Controls.Add(this.labelEnd);
            this.panel2.Controls.Add(this.labelStart);
            this.panel2.Controls.Add(this.endYCounter);
            this.panel2.Controls.Add(this.endXCounter);
            this.panel2.Controls.Add(this.startYCounter);
            this.panel2.Controls.Add(this.labelType);
            this.panel2.Controls.Add(this.buttonFinish);
            this.panel2.Controls.Add(this.MazeType);
            this.panel2.Controls.Add(this.labelSpeedValue);
            this.panel2.Controls.Add(this.labelSeed);
            this.panel2.Controls.Add(this.speedSlider);
            this.panel2.Controls.Add(this.heightCounter);
            this.panel2.Controls.Add(this.widthCounter);
            this.panel2.Controls.Add(this.buttonGenerate);
            this.panel2.Controls.Add(this.heightLabel);
            this.panel2.Controls.Add(this.widthLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1519, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 1041);
            this.panel2.TabIndex = 9;
            // 
            // buttonMakeRoom
            // 
            this.buttonMakeRoom.Location = new System.Drawing.Point(15, 673);
            this.buttonMakeRoom.Name = "buttonMakeRoom";
            this.buttonMakeRoom.Size = new System.Drawing.Size(179, 71);
            this.buttonMakeRoom.TabIndex = 35;
            this.buttonMakeRoom.Text = "Make Room";
            this.buttonMakeRoom.UseVisualStyleBackColor = true;
            this.buttonMakeRoom.Click += new System.EventHandler(this.buttonMakeRoom_Click);
            // 
            // buttonRAND
            // 
            this.buttonRAND.Location = new System.Drawing.Point(141, 314);
            this.buttonRAND.Name = "buttonRAND";
            this.buttonRAND.Size = new System.Drawing.Size(86, 26);
            this.buttonRAND.TabIndex = 34;
            this.buttonRAND.Text = "RAND";
            this.buttonRAND.UseVisualStyleBackColor = true;
            this.buttonRAND.Click += new System.EventHandler(this.buttonRAND_Click);
            // 
            // buttonClearSolver
            // 
            this.buttonClearSolver.Location = new System.Drawing.Point(114, 582);
            this.buttonClearSolver.Name = "buttonClearSolver";
            this.buttonClearSolver.Size = new System.Drawing.Size(179, 71);
            this.buttonClearSolver.TabIndex = 33;
            this.buttonClearSolver.Text = "Clear";
            this.buttonClearSolver.UseVisualStyleBackColor = true;
            this.buttonClearSolver.Click += new System.EventHandler(this.buttonClearSolver_Click);
            // 
            // buttonFinishPath
            // 
            this.buttonFinishPath.Location = new System.Drawing.Point(211, 485);
            this.buttonFinishPath.Name = "buttonFinishPath";
            this.buttonFinishPath.Size = new System.Drawing.Size(159, 71);
            this.buttonFinishPath.TabIndex = 32;
            this.buttonFinishPath.Text = "Finish";
            this.buttonFinishPath.UseVisualStyleBackColor = true;
            this.buttonFinishPath.Click += new System.EventHandler(this.buttonFinishPath_Click);
            // 
            // buttonFindPath
            // 
            this.buttonFindPath.Location = new System.Drawing.Point(15, 485);
            this.buttonFindPath.Name = "buttonFindPath";
            this.buttonFindPath.Size = new System.Drawing.Size(179, 71);
            this.buttonFindPath.TabIndex = 31;
            this.buttonFindPath.Text = "Solve";
            this.buttonFindPath.UseVisualStyleBackColor = true;
            this.buttonFindPath.Click += new System.EventHandler(this.buttonFindPath_Click);
            // 
            // labelStartY
            // 
            this.labelStartY.AutoSize = true;
            this.labelStartY.Location = new System.Drawing.Point(250, 325);
            this.labelStartY.Name = "labelStartY";
            this.labelStartY.Size = new System.Drawing.Size(14, 15);
            this.labelStartY.TabIndex = 30;
            this.labelStartY.Text = "Y";
            // 
            // labelStartX
            // 
            this.labelStartX.AutoSize = true;
            this.labelStartX.Location = new System.Drawing.Point(85, 325);
            this.labelStartX.Name = "labelStartX";
            this.labelStartX.Size = new System.Drawing.Size(14, 15);
            this.labelStartX.TabIndex = 29;
            this.labelStartX.Text = "X";
            // 
            // labelEndY
            // 
            this.labelEndY.AutoSize = true;
            this.labelEndY.Location = new System.Drawing.Point(250, 407);
            this.labelEndY.Name = "labelEndY";
            this.labelEndY.Size = new System.Drawing.Size(14, 15);
            this.labelEndY.TabIndex = 26;
            this.labelEndY.Text = "Y";
            // 
            // startXCounter
            // 
            this.startXCounter.Location = new System.Drawing.Point(41, 355);
            this.startXCounter.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startXCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startXCounter.Name = "startXCounter";
            this.startXCounter.Size = new System.Drawing.Size(131, 23);
            this.startXCounter.TabIndex = 28;
            this.startXCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelEndX
            // 
            this.labelEndX.AutoSize = true;
            this.labelEndX.Location = new System.Drawing.Point(85, 407);
            this.labelEndX.Name = "labelEndX";
            this.labelEndX.Size = new System.Drawing.Size(14, 15);
            this.labelEndX.TabIndex = 25;
            this.labelEndX.Text = "X";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(0, 396);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(49, 15);
            this.labelEnd.TabIndex = 24;
            this.labelEnd.Text = "End Pos";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(0, 325);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(53, 15);
            this.labelStart.TabIndex = 23;
            this.labelStart.Text = "Start Pos";
            // 
            // endYCounter
            // 
            this.endYCounter.Location = new System.Drawing.Point(201, 425);
            this.endYCounter.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endYCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endYCounter.Name = "endYCounter";
            this.endYCounter.Size = new System.Drawing.Size(131, 23);
            this.endYCounter.TabIndex = 22;
            this.endYCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endXCounter
            // 
            this.endXCounter.Location = new System.Drawing.Point(41, 425);
            this.endXCounter.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endXCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endXCounter.Name = "endXCounter";
            this.endXCounter.Size = new System.Drawing.Size(131, 23);
            this.endXCounter.TabIndex = 21;
            this.endXCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startYCounter
            // 
            this.startYCounter.Location = new System.Drawing.Point(201, 355);
            this.startYCounter.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startYCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startYCounter.Name = "startYCounter";
            this.startYCounter.Size = new System.Drawing.Size(131, 23);
            this.startYCounter.TabIndex = 20;
            this.startYCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(188, 258);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 15);
            this.labelType.TabIndex = 18;
            this.labelType.Text = "Type";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(214, 110);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(159, 71);
            this.buttonFinish.TabIndex = 17;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // MazeType
            // 
            this.MazeType.FormattingEnabled = true;
            this.MazeType.Items.AddRange(new object[] {
            "Recursive",
            "Iterative",
            "Wilson",
            "Prim",
            "Aldous-Broder",
            "Kruskal"});
            this.MazeType.Location = new System.Drawing.Point(138, 276);
            this.MazeType.Name = "MazeType";
            this.MazeType.Size = new System.Drawing.Size(145, 23);
            this.MazeType.TabIndex = 16;
            // 
            // labelSpeedValue
            // 
            this.labelSpeedValue.AutoSize = true;
            this.labelSpeedValue.Location = new System.Drawing.Point(201, 232);
            this.labelSpeedValue.Name = "labelSpeedValue";
            this.labelSpeedValue.Size = new System.Drawing.Size(13, 15);
            this.labelSpeedValue.TabIndex = 15;
            this.labelSpeedValue.Text = "0";
            // 
            // labelSeed
            // 
            this.labelSeed.AutoSize = true;
            this.labelSeed.Location = new System.Drawing.Point(188, 184);
            this.labelSeed.Name = "labelSeed";
            this.labelSeed.Size = new System.Drawing.Size(39, 15);
            this.labelSeed.TabIndex = 14;
            this.labelSeed.Text = "Speed";
            // 
            // speedSlider
            // 
            this.speedSlider.LargeChange = 10;
            this.speedSlider.Location = new System.Drawing.Point(18, 202);
            this.speedSlider.Maximum = 100;
            this.speedSlider.Name = "speedSlider";
            this.speedSlider.Size = new System.Drawing.Size(355, 45);
            this.speedSlider.TabIndex = 13;
            this.speedSlider.Value = 1;
            this.speedSlider.ValueChanged += new System.EventHandler(this.speedSlider_ValueChanged);
            // 
            // heightCounter
            // 
            this.heightCounter.Location = new System.Drawing.Point(224, 67);
            this.heightCounter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.heightCounter.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.heightCounter.Name = "heightCounter";
            this.heightCounter.Size = new System.Drawing.Size(131, 23);
            this.heightCounter.TabIndex = 12;
            this.heightCounter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // widthCounter
            // 
            this.widthCounter.Location = new System.Drawing.Point(41, 67);
            this.widthCounter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.widthCounter.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.widthCounter.Name = "widthCounter";
            this.widthCounter.Size = new System.Drawing.Size(131, 23);
            this.widthCounter.TabIndex = 11;
            this.widthCounter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(18, 110);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(179, 71);
            this.buttonGenerate.TabIndex = 10;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(250, 38);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(43, 15);
            this.heightLabel.TabIndex = 9;
            this.heightLabel.Text = "Height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(85, 38);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(39, 15);
            this.widthLabel.TabIndex = 8;
            this.widthLabel.Text = "Width";
            // 
            // buttonAddItems
            // 
            this.buttonAddItems.Location = new System.Drawing.Point(203, 673);
            this.buttonAddItems.Name = "buttonAddItems";
            this.buttonAddItems.Size = new System.Drawing.Size(179, 71);
            this.buttonAddItems.TabIndex = 36;
            this.buttonAddItems.Text = "Gen Items";
            this.buttonAddItems.UseVisualStyleBackColor = true;
            this.buttonAddItems.Click += new System.EventHandler(this.buttonAddItems_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startXCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endYCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endXCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startYCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox frame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown heightCounter;
        private System.Windows.Forms.NumericUpDown widthCounter;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label labelSeed;
        private System.Windows.Forms.TrackBar speedSlider;
        private System.Windows.Forms.Label labelSpeedValue;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox MazeType;
        private System.Windows.Forms.Label labelStartY;
        private System.Windows.Forms.Label labelStartX;
        private System.Windows.Forms.Label labelEndY;
        private System.Windows.Forms.NumericUpDown startXCounter;
        private System.Windows.Forms.Label labelEndX;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.NumericUpDown endYCounter;
        private System.Windows.Forms.NumericUpDown endXCounter;
        private System.Windows.Forms.NumericUpDown startYCounter;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonFinishPath;
        private System.Windows.Forms.Button buttonFindPath;
        private System.Windows.Forms.Button buttonClearSolver;
        private System.Windows.Forms.Button buttonRAND;
        private System.Windows.Forms.Button buttonMakeRoom;
        private System.Windows.Forms.Button buttonAddItems;
    }
}

