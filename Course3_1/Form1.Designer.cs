namespace Course3_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.updTimer = new System.Windows.Forms.Timer(this.components);
            this.tCPU_label = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.RAMload_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.CPUload_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.GPU_load_label = new System.Windows.Forms.Label();
            this.GPUtree = new System.Windows.Forms.TreeView();
            this.CPUtree = new System.Windows.Forms.TreeView();
            this.RAMtree = new System.Windows.Forms.TreeView();
            this.OveralTree = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // updTimer
            // 
            this.updTimer.Interval = 2000;
            this.updTimer.Tick += new System.EventHandler(this.UPDtick);
            // 
            // tCPU_label
            // 
            this.tCPU_label.AutoSize = true;
            this.tCPU_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tCPU_label.Location = new System.Drawing.Point(183, 26);
            this.tCPU_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tCPU_label.Name = "tCPU_label";
            this.tCPU_label.Size = new System.Drawing.Size(18, 20);
            this.tCPU_label.TabIndex = 2;
            this.tCPU_label.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(9, 26);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(170, 19);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPU current temperature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(224, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "RAM load";
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.Lime;
            this.progressBar2.Location = new System.Drawing.Point(224, 26);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(170, 19);
            this.progressBar2.TabIndex = 6;
            // 
            // RAMload_label
            // 
            this.RAMload_label.AutoSize = true;
            this.RAMload_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAMload_label.Location = new System.Drawing.Point(398, 26);
            this.RAMload_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RAMload_label.Name = "RAMload_label";
            this.RAMload_label.Size = new System.Drawing.Size(18, 20);
            this.RAMload_label.TabIndex = 5;
            this.RAMload_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "CPU load";
            // 
            // progressBar3
            // 
            this.progressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.progressBar3.Location = new System.Drawing.Point(9, 75);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(170, 19);
            this.progressBar3.TabIndex = 9;
            // 
            // CPUload_label
            // 
            this.CPUload_label.AutoSize = true;
            this.CPUload_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUload_label.Location = new System.Drawing.Point(183, 75);
            this.CPUload_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUload_label.Name = "CPUload_label";
            this.CPUload_label.Size = new System.Drawing.Size(18, 20);
            this.CPUload_label.TabIndex = 8;
            this.CPUload_label.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(436, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "GPU Load";
            // 
            // progressBar4
            // 
            this.progressBar4.ForeColor = System.Drawing.Color.Lime;
            this.progressBar4.Location = new System.Drawing.Point(436, 26);
            this.progressBar4.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(170, 19);
            this.progressBar4.TabIndex = 14;
            // 
            // GPU_load_label
            // 
            this.GPU_load_label.AutoSize = true;
            this.GPU_load_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GPU_load_label.Location = new System.Drawing.Point(610, 26);
            this.GPU_load_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GPU_load_label.Name = "GPU_load_label";
            this.GPU_load_label.Size = new System.Drawing.Size(18, 20);
            this.GPU_load_label.TabIndex = 13;
            this.GPU_load_label.Text = "0";
            // 
            // GPUtree
            // 
            this.GPUtree.HideSelection = false;
            this.GPUtree.Location = new System.Drawing.Point(436, 56);
            this.GPUtree.Name = "GPUtree";
            this.GPUtree.Size = new System.Drawing.Size(209, 126);
            this.GPUtree.TabIndex = 19;
            // 
            // CPUtree
            // 
            this.CPUtree.Location = new System.Drawing.Point(9, 99);
            this.CPUtree.Name = "CPUtree";
            this.CPUtree.Size = new System.Drawing.Size(209, 533);
            this.CPUtree.TabIndex = 20;
            // 
            // RAMtree
            // 
            this.RAMtree.Location = new System.Drawing.Point(224, 56);
            this.RAMtree.Name = "RAMtree";
            this.RAMtree.Size = new System.Drawing.Size(206, 126);
            this.RAMtree.TabIndex = 21;
            // 
            // OveralTree
            // 
            this.OveralTree.Location = new System.Drawing.Point(651, 7);
            this.OveralTree.Name = "OveralTree";
            this.OveralTree.Size = new System.Drawing.Size(220, 625);
            this.OveralTree.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(290, 210);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(3, 143);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(883, 642);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.OveralTree);
            this.Controls.Add(this.RAMtree);
            this.Controls.Add(this.CPUtree);
            this.Controls.Add(this.GPUtree);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.GPU_load_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.CPUload_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.RAMload_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tCPU_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer updTimer;
        private System.Windows.Forms.Label tCPU_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label RAMload_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label CPUload_label;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label GPU_load_label;
        private System.Windows.Forms.TreeView GPUtree;
        private System.Windows.Forms.TreeView CPUtree;
        private System.Windows.Forms.TreeView RAMtree;
        private System.Windows.Forms.TreeView OveralTree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

