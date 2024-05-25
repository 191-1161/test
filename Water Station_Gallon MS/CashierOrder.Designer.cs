namespace Water_Station_Gallon_MS
{
    partial class CashierOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CashierOrder_clearBtn = new System.Windows.Forms.Button();
            this.CashierOrder_addBtn = new System.Windows.Forms.Button();
            this.CashierOrder_removeBtn = new System.Windows.Forms.Button();
            this.CashierOrder_qty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.CashierOrder_price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CashierOrder_prodName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CashierOrder_prodID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CashierOrder_category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.CashierOrder_payOrders = new System.Windows.Forms.Button();
            this.CashierOrder_receipt = new System.Windows.Forms.Button();
            this.CashierOrder_change = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CashierOrder_amount = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.CashierOrder_totalPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashierOrder_qty)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(23, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 361);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(18, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(584, 294);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Available Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CashierOrder_clearBtn);
            this.panel2.Controls.Add(this.CashierOrder_addBtn);
            this.panel2.Controls.Add(this.CashierOrder_removeBtn);
            this.panel2.Controls.Add(this.CashierOrder_qty);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.CashierOrder_price);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.CashierOrder_prodName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CashierOrder_prodID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CashierOrder_category);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 349);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Select The Orders";
            // 
            // CashierOrder_clearBtn
            // 
            this.CashierOrder_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashierOrder_clearBtn.FlatAppearance.BorderSize = 0;
            this.CashierOrder_clearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.CashierOrder_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierOrder_clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_clearBtn.ForeColor = System.Drawing.Color.White;
            this.CashierOrder_clearBtn.Location = new System.Drawing.Point(483, 260);
            this.CashierOrder_clearBtn.Name = "CashierOrder_clearBtn";
            this.CashierOrder_clearBtn.Size = new System.Drawing.Size(108, 66);
            this.CashierOrder_clearBtn.TabIndex = 17;
            this.CashierOrder_clearBtn.Text = "Clear";
            this.CashierOrder_clearBtn.UseVisualStyleBackColor = false;
            this.CashierOrder_clearBtn.Click += new System.EventHandler(this.CashierOrder_clearBtn_Click);
            // 
            // CashierOrder_addBtn
            // 
            this.CashierOrder_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashierOrder_addBtn.FlatAppearance.BorderSize = 0;
            this.CashierOrder_addBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.CashierOrder_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierOrder_addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_addBtn.ForeColor = System.Drawing.Color.White;
            this.CashierOrder_addBtn.Location = new System.Drawing.Point(30, 260);
            this.CashierOrder_addBtn.Name = "CashierOrder_addBtn";
            this.CashierOrder_addBtn.Size = new System.Drawing.Size(108, 66);
            this.CashierOrder_addBtn.TabIndex = 16;
            this.CashierOrder_addBtn.Text = "Add";
            this.CashierOrder_addBtn.UseVisualStyleBackColor = false;
            this.CashierOrder_addBtn.Click += new System.EventHandler(this.CashierOrder_addBtn_Click);
            // 
            // CashierOrder_removeBtn
            // 
            this.CashierOrder_removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashierOrder_removeBtn.FlatAppearance.BorderSize = 0;
            this.CashierOrder_removeBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.CashierOrder_removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierOrder_removeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_removeBtn.ForeColor = System.Drawing.Color.White;
            this.CashierOrder_removeBtn.Location = new System.Drawing.Point(172, 260);
            this.CashierOrder_removeBtn.Name = "CashierOrder_removeBtn";
            this.CashierOrder_removeBtn.Size = new System.Drawing.Size(108, 66);
            this.CashierOrder_removeBtn.TabIndex = 15;
            this.CashierOrder_removeBtn.Text = "Remove";
            this.CashierOrder_removeBtn.UseVisualStyleBackColor = false;
            this.CashierOrder_removeBtn.Click += new System.EventHandler(this.CashierOrder_removeBtn_Click);
            // 
            // CashierOrder_qty
            // 
            this.CashierOrder_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_qty.Location = new System.Drawing.Point(428, 146);
            this.CashierOrder_qty.Name = "CashierOrder_qty";
            this.CashierOrder_qty.Size = new System.Drawing.Size(168, 30);
            this.CashierOrder_qty.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(331, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Quantity:";
            // 
            // CashierOrder_price
            // 
            this.CashierOrder_price.AutoSize = true;
            this.CashierOrder_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_price.Location = new System.Drawing.Point(186, 209);
            this.CashierOrder_price.Name = "CashierOrder_price";
            this.CashierOrder_price.Size = new System.Drawing.Size(98, 25);
            this.CashierOrder_price.TabIndex = 11;
            this.CashierOrder_price.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price (₱):";
            // 
            // CashierOrder_prodName
            // 
            this.CashierOrder_prodName.AutoSize = true;
            this.CashierOrder_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_prodName.Location = new System.Drawing.Point(186, 151);
            this.CashierOrder_prodName.Name = "CashierOrder_prodName";
            this.CashierOrder_prodName.Size = new System.Drawing.Size(98, 25);
            this.CashierOrder_prodName.TabIndex = 9;
            this.CashierOrder_prodName.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Name:";
            // 
            // CashierOrder_prodID
            // 
            this.CashierOrder_prodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_prodID.FormattingEnabled = true;
            this.CashierOrder_prodID.Location = new System.Drawing.Point(428, 91);
            this.CashierOrder_prodID.Name = "CashierOrder_prodID";
            this.CashierOrder_prodID.Size = new System.Drawing.Size(167, 33);
            this.CashierOrder_prodID.TabIndex = 7;
            this.CashierOrder_prodID.SelectedIndexChanged += new System.EventHandler(this.CashierOrder_prodID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product ID:";
            // 
            // CashierOrder_category
            // 
            this.CashierOrder_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_category.FormattingEnabled = true;
            this.CashierOrder_category.Location = new System.Drawing.Point(127, 94);
            this.CashierOrder_category.Name = "CashierOrder_category";
            this.CashierOrder_category.Size = new System.Drawing.Size(167, 33);
            this.CashierOrder_category.TabIndex = 5;
            this.CashierOrder_category.SelectedIndexChanged += new System.EventHandler(this.CashierOrder_category_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.CashierOrder_payOrders);
            this.panel3.Controls.Add(this.CashierOrder_receipt);
            this.panel3.Controls.Add(this.CashierOrder_change);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.CashierOrder_amount);
            this.panel3.Controls.Add(this.label);
            this.panel3.Controls.Add(this.CashierOrder_totalPrice);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(645, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 716);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(13, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(388, 313);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "All Orders";
            // 
            // CashierOrder_payOrders
            // 
            this.CashierOrder_payOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_payOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashierOrder_payOrders.FlatAppearance.BorderSize = 0;
            this.CashierOrder_payOrders.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_payOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.CashierOrder_payOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_payOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierOrder_payOrders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_payOrders.ForeColor = System.Drawing.Color.White;
            this.CashierOrder_payOrders.Location = new System.Drawing.Point(13, 538);
            this.CashierOrder_payOrders.Name = "CashierOrder_payOrders";
            this.CashierOrder_payOrders.Size = new System.Drawing.Size(388, 66);
            this.CashierOrder_payOrders.TabIndex = 19;
            this.CashierOrder_payOrders.Text = "Pay Orders";
            this.CashierOrder_payOrders.UseVisualStyleBackColor = false;
            this.CashierOrder_payOrders.Click += new System.EventHandler(this.CashierOrder_payOrders_Click);
            // 
            // CashierOrder_receipt
            // 
            this.CashierOrder_receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_receipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashierOrder_receipt.FlatAppearance.BorderSize = 0;
            this.CashierOrder_receipt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_receipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.CashierOrder_receipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.CashierOrder_receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashierOrder_receipt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_receipt.ForeColor = System.Drawing.Color.White;
            this.CashierOrder_receipt.Location = new System.Drawing.Point(13, 627);
            this.CashierOrder_receipt.Name = "CashierOrder_receipt";
            this.CashierOrder_receipt.Size = new System.Drawing.Size(387, 66);
            this.CashierOrder_receipt.TabIndex = 18;
            this.CashierOrder_receipt.Text = "Receipt";
            this.CashierOrder_receipt.UseVisualStyleBackColor = false;
            this.CashierOrder_receipt.Click += new System.EventHandler(this.CashierOrder_receipt_Click);
            // 
            // CashierOrder_change
            // 
            this.CashierOrder_change.AutoSize = true;
            this.CashierOrder_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_change.Location = new System.Drawing.Point(238, 495);
            this.CashierOrder_change.Name = "CashierOrder_change";
            this.CashierOrder_change.Size = new System.Drawing.Size(50, 25);
            this.CashierOrder_change.TabIndex = 17;
            this.CashierOrder_change.Text = "0.00";
            this.CashierOrder_change.Click += new System.EventHandler(this.CashierOrder_change_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(129, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Change:";
            // 
            // CashierOrder_amount
            // 
            this.CashierOrder_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_amount.Location = new System.Drawing.Point(243, 438);
            this.CashierOrder_amount.Name = "CashierOrder_amount";
            this.CashierOrder_amount.Size = new System.Drawing.Size(156, 30);
            this.CashierOrder_amount.TabIndex = 15;
            this.CashierOrder_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CashierOrder_amount_KeyDown);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(129, 443);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 25);
            this.label.TabIndex = 14;
            this.label.Text = "Amount (₱):";
            // 
            // CashierOrder_totalPrice
            // 
            this.CashierOrder_totalPrice.AutoSize = true;
            this.CashierOrder_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierOrder_totalPrice.Location = new System.Drawing.Point(238, 385);
            this.CashierOrder_totalPrice.Name = "CashierOrder_totalPrice";
            this.CashierOrder_totalPrice.Size = new System.Drawing.Size(50, 25);
            this.CashierOrder_totalPrice.TabIndex = 13;
            this.CashierOrder_totalPrice.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(81, 385);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 25);
            this.label12.TabIndex = 12;
            this.label12.Text = "Total Price (₱):";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CashierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierOrder";
            this.Size = new System.Drawing.Size(1078, 771);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashierOrder_qty)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CashierOrder_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CashierOrder_prodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CashierOrder_prodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CashierOrder_category;
        private System.Windows.Forms.NumericUpDown CashierOrder_qty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CashierOrder_clearBtn;
        private System.Windows.Forms.Button CashierOrder_addBtn;
        private System.Windows.Forms.Button CashierOrder_removeBtn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label CashierOrder_totalPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button CashierOrder_payOrders;
        private System.Windows.Forms.Button CashierOrder_receipt;
        private System.Windows.Forms.Label CashierOrder_change;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CashierOrder_amount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
