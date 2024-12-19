namespace AnimeTitles
{
    partial class FormUsers
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDel = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonAdd);
            flowLayoutPanel1.Controls.Add(buttonEdit);
            flowLayoutPanel1.Controls.Add(buttonDel);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(1257, 100);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Top;
            buttonAdd.Location = new Point(13, 13);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Padding = new Padding(10);
            buttonAdd.Size = new Size(170, 50);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(189, 13);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(10);
            buttonEdit.Size = new Size(170, 50);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(365, 13);
            buttonDel.Name = "buttonDel";
            buttonDel.Padding = new Padding(10);
            buttonDel.Size = new Size(170, 50);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(1257, 650);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1237, 630);
            dataGridView1.TabIndex = 0;
            // 
            // FormUsers
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 750);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormUsers";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDel;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}
