namespace Water_Station_Gallon_MS
{
    partial class AdminAddCategories
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addCategories_updateBtn = new System.Windows.Forms.Button();
            this.addCategories_clearBtn = new System.Windows.Forms.Button();
            this.addCategories_removeBtn = new System.Windows.Forms.Button();
            this.addCategories_addBtn = new System.Windows.Forms.Button();
            this.addCategories_category = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(352, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 652);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 579);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "All Categories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addCategories_updateBtn);
            this.panel1.Controls.Add(this.addCategories_clearBtn);
            this.panel1.Controls.Add(this.addCategories_removeBtn);
            this.panel1.Controls.Add(this.addCategories_addBtn);
            this.panel1.Controls.Add(this.addCategories_category);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 652);
            this.panel1.TabIndex = 6;
            // 
            // addCategories_updateBtn
            // 
            this.addCategories_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.addCategories_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCategories_updateBtn.FlatAppearance.BorderSize = 0;
            this.addCategories_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.addCategories_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.addCategories_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.addCategories_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addCategories_updateBtn.Location = new System.Drawing.Point(153, 163);
            this.addCategories_updateBtn.Name = "addCategories_updateBtn";
            this.addCategories_updateBtn.Size = new System.Drawing.Size(108, 66);
            this.addCategories_updateBtn.TabIndex = 6;
            this.addCategories_updateBtn.Text = "Update";
            this.addCategories_updateBtn.UseVisualStyleBackColor = false;
            this.addCategories_updateBtn.Click += new System.EventHandler(this.addCategories_updateBtn_Click);
            // 
            // addCategories_clearBtn
            // 
            this.addCategories_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.addCategories_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCategories_clearBtn.FlatAppearance.BorderSize = 0;
            this.addCategories_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.addCategories_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.addCategories_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.addCategories_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addCategories_clearBtn.Location = new System.Drawing.Point(153, 235);
            this.addCategories_clearBtn.Name = "addCategories_clearBtn";
            this.addCategories_clearBtn.Size = new System.Drawing.Size(108, 67);
            this.addCategories_clearBtn.TabIndex = 8;
            this.addCategories_clearBtn.Text = "Clear";
            this.addCategories_clearBtn.UseVisualStyleBackColor = false;
            this.addCategories_clearBtn.Click += new System.EventHandler(this.addCategories_clearBtn_Click);
            // 
            // addCategories_removeBtn
            // 
            this.addCategories_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.addCategories_removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCategories_removeBtn.FlatAppearance.BorderSize = 0;
            this.addCategories_removeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.addCategories_removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.addCategories_removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.addCategories_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_removeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_removeBtn.ForeColor = System.Drawing.Color.White;
            this.addCategories_removeBtn.Location = new System.Drawing.Point(36, 235);
            this.addCategories_removeBtn.Name = "addCategories_removeBtn";
            this.addCategories_removeBtn.Size = new System.Drawing.Size(111, 67);
            this.addCategories_removeBtn.TabIndex = 7;
            this.addCategories_removeBtn.Text = "Remove";
            this.addCategories_removeBtn.UseVisualStyleBackColor = false;
            this.addCategories_removeBtn.Click += new System.EventHandler(this.addCategories_removeBtn_Click);
            // 
            // addCategories_addBtn
            // 
            this.addCategories_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.addCategories_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCategories_addBtn.FlatAppearance.BorderSize = 0;
            this.addCategories_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.addCategories_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.addCategories_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.addCategories_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategories_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_addBtn.ForeColor = System.Drawing.Color.White;
            this.addCategories_addBtn.Location = new System.Drawing.Point(36, 163);
            this.addCategories_addBtn.Name = "addCategories_addBtn";
            this.addCategories_addBtn.Size = new System.Drawing.Size(108, 66);
            this.addCategories_addBtn.TabIndex = 0;
            this.addCategories_addBtn.Text = "Add";
            this.addCategories_addBtn.UseVisualStyleBackColor = false;
            this.addCategories_addBtn.Click += new System.EventHandler(this.addCategories_addBtn_Click);
            // 
            // addCategories_category
            // 
            this.addCategories_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_category.Location = new System.Drawing.Point(42, 110);
            this.addCategories_category.Name = "addCategories_category";
            this.addCategories_category.Size = new System.Drawing.Size(216, 30);
            this.addCategories_category.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // AdminAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddCategories";
            this.Size = new System.Drawing.Size(1078, 770);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addCategories_updateBtn;
        private System.Windows.Forms.Button addCategories_clearBtn;
        private System.Windows.Forms.Button addCategories_removeBtn;
        private System.Windows.Forms.Button addCategories_addBtn;
        private System.Windows.Forms.TextBox addCategories_category;
        private System.Windows.Forms.Label label1;
    }
}
