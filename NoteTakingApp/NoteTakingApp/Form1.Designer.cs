namespace NoteTakingApp
{
    partial class NoteTaker
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.previousNotes = new System.Windows.Forms.DataGridView();
            this.loadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(319, 38);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(478, 31);
            this.titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(319, 101);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(478, 499);
            this.noteBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(319, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // previousNotes
            // 
            this.previousNotes.BackgroundColor = System.Drawing.Color.White;
            this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNotes.Location = new System.Drawing.Point(12, 9);
            this.previousNotes.Name = "previousNotes";
            this.previousNotes.RowHeadersWidth = 62;
            this.previousNotes.RowTemplate.Height = 33;
            this.previousNotes.Size = new System.Drawing.Size(301, 494);
            this.previousNotes.TabIndex = 4;
            this.previousNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes_CellDoubleClick);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.DarkOrange;
            this.loadButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadButton.Location = new System.Drawing.Point(12, 509);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(141, 43);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(159, 509);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(154, 43);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(159, 560);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(154, 40);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.newButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newButton.Location = new System.Drawing.Point(12, 560);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(141, 40);
            this.newButton.TabIndex = 8;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(809, 612);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.previousNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "NoteTaker";
            this.Text = "Note Taker";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox titleBox;
        private TextBox noteBox;
        private Label label1;
        private Label label2;
        private DataGridView previousNotes;
        private Button loadButton;
        private Button deleteButton;
        private Button saveButton;
        private Button newButton;
    }
}