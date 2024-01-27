namespace NamesPipesDemo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tbMessage = new TextBox();
            lbMessage = new Label();
            btnSend = new Button();
            lbId = new Label();
            tbId = new TextBox();
            lbTo = new Label();
            dgMessages = new DataGridView();
            ColumnMe = new DataGridViewTextBoxColumn();
            ColumnOther = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgMessages).BeginInit();
            SuspendLayout();
            // 
            // tbMessage
            // 
            tbMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbMessage.Location = new Point(128, 383);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(477, 23);
            tbMessage.TabIndex = 0;
            // 
            // lbMessage
            // 
            lbMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbMessage.AutoSize = true;
            lbMessage.Location = new Point(12, 386);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(110, 15);
            lbMessage.TabIndex = 1;
            lbMessage.Text = "Send this  message:";
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.Enabled = false;
            btnSend.Location = new Point(713, 382);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lbId
            // 
            lbId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbId.Location = new Point(678, 16);
            lbId.Name = "lbId";
            lbId.Size = new Size(110, 15);
            lbId.TabIndex = 5;
            lbId.Text = "Id: --";
            lbId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbId
            // 
            tbId.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tbId.Location = new Point(639, 382);
            tbId.Name = "tbId";
            tbId.Size = new Size(68, 23);
            tbId.TabIndex = 6;
            // 
            // lbTo
            // 
            lbTo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbTo.AutoSize = true;
            lbTo.Location = new Point(611, 386);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(22, 15);
            lbTo.TabIndex = 7;
            lbTo.Text = "To:";
            // 
            // dgMessages
            // 
            dgMessages.AllowUserToAddRows = false;
            dgMessages.AllowUserToDeleteRows = false;
            dgMessages.AllowUserToResizeColumns = false;
            dgMessages.AllowUserToResizeRows = false;
            dgMessages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgMessages.BackgroundColor = SystemColors.Window;
            dgMessages.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgMessages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMessages.ColumnHeadersVisible = false;
            dgMessages.Columns.AddRange(new DataGridViewColumn[] { ColumnMe, ColumnOther });
            dgMessages.Enabled = false;
            dgMessages.Location = new Point(12, 43);
            dgMessages.Name = "dgMessages";
            dgMessages.ReadOnly = true;
            dgMessages.RowHeadersVisible = false;
            dgMessages.RowTemplate.Height = 25;
            dgMessages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMessages.ShowEditingIcon = false;
            dgMessages.Size = new Size(776, 333);
            dgMessages.TabIndex = 8;
            // 
            // ColumnMe
            // 
            ColumnMe.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnMe.DataPropertyName = "Item1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ColumnMe.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnMe.FillWeight = 1F;
            ColumnMe.HeaderText = "Me";
            ColumnMe.Name = "ColumnMe";
            ColumnMe.ReadOnly = true;
            // 
            // ColumnOther
            // 
            ColumnOther.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnOther.DataPropertyName = "Item2";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ColumnOther.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnOther.FillWeight = 1F;
            ColumnOther.HeaderText = "Other";
            ColumnOther.Name = "ColumnOther";
            ColumnOther.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 414);
            Controls.Add(dgMessages);
            Controls.Add(lbTo);
            Controls.Add(tbId);
            Controls.Add(lbId);
            Controls.Add(btnSend);
            Controls.Add(lbMessage);
            Controls.Add(tbMessage);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgMessages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMessage;
        private Label lbMessage;
        private Button btnSend;
        private Label lbId;
        private TextBox tbId;
        private Label lbTo;
        private DataGridView dgMessages;
        private DataGridViewTextBoxColumn ColumnMe;
        private DataGridViewTextBoxColumn ColumnOther;
    }
}