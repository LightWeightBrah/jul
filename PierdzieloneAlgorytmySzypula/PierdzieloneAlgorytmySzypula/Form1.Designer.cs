namespace PierdzieloneAlgorytmySzypula
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
            resultLabel = new Label();
            bubbleButton = new Button();
            insertionButton = new Button();
            countingButton = new Button();
            mergeButton = new Button();
            generateArrayButton = new Button();
            inputLabel = new Label();
            quickButton = new Button();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            resultLabel.Location = new Point(341, 374);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(65, 25);
            resultLabel.TabIndex = 0;
            resultLabel.Text = "label1";
            // 
            // bubbleButton
            // 
            bubbleButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bubbleButton.Location = new Point(26, 129);
            bubbleButton.Name = "bubbleButton";
            bubbleButton.Size = new Size(168, 77);
            bubbleButton.TabIndex = 2;
            bubbleButton.Text = "Bubble Sort";
            bubbleButton.UseVisualStyleBackColor = true;
            bubbleButton.Click += this.OnBubbleSortButtonClick;
            // 
            // insertionButton
            // 
            insertionButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            insertionButton.Location = new Point(224, 129);
            insertionButton.Name = "insertionButton";
            insertionButton.Size = new Size(168, 77);
            insertionButton.TabIndex = 3;
            insertionButton.Text = "Insertion Sort";
            insertionButton.UseVisualStyleBackColor = true;
            insertionButton.Click += this.OnInsertionSortButtonClick;
            // 
            // countingButton
            // 
            countingButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            countingButton.Location = new Point(416, 129);
            countingButton.Name = "countingButton";
            countingButton.Size = new Size(168, 77);
            countingButton.TabIndex = 4;
            countingButton.Text = "Counting SOrt";
            countingButton.UseVisualStyleBackColor = true;
            countingButton.Click += this.OnCountingButtonClick;
            // 
            // mergeButton
            // 
            mergeButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            mergeButton.Location = new Point(610, 129);
            mergeButton.Name = "mergeButton";
            mergeButton.Size = new Size(168, 77);
            mergeButton.TabIndex = 5;
            mergeButton.Text = "Merge Sort";
            mergeButton.UseVisualStyleBackColor = true;
            mergeButton.Click += this.OnMergeButtonClick;
            // 
            // generateArrayButton
            // 
            generateArrayButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            generateArrayButton.Location = new Point(26, 22);
            generateArrayButton.Name = "generateArrayButton";
            generateArrayButton.Size = new Size(168, 77);
            generateArrayButton.TabIndex = 6;
            generateArrayButton.Text = "Generate Array";
            generateArrayButton.UseVisualStyleBackColor = true;
            generateArrayButton.Click += this.OnGenerateArrayButtonClick;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            inputLabel.Location = new Point(304, 48);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(65, 25);
            inputLabel.TabIndex = 7;
            inputLabel.Text = "label1";
            // 
            // quickButton
            // 
            quickButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            quickButton.Location = new Point(304, 221);
            quickButton.Name = "quickButton";
            quickButton.Size = new Size(168, 77);
            quickButton.TabIndex = 8;
            quickButton.Text = "Quick Sort";
            quickButton.UseVisualStyleBackColor = true;
            quickButton.Click += this.OnQuickButtonClick;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(quickButton);
            this.Controls.Add(inputLabel);
            this.Controls.Add(generateArrayButton);
            this.Controls.Add(mergeButton);
            this.Controls.Add(countingButton);
            this.Controls.Add(insertionButton);
            this.Controls.Add(bubbleButton);
            this.Controls.Add(resultLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label resultLabel;
        private Button bubbleButton;
        private Button insertionButton;
        private Button countingButton;
        private Button mergeButton;
        private Button generateArrayButton;
        private Label inputLabel;
        private Button quickButton;
    }
}