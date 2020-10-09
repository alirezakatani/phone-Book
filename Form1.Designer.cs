namespace phone
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxfamily = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnfirst = new System.Windows.Forms.Button();
            this.comboBoxsearched = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxsearchfor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(212, 62);
            this.textBoxname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.ReadOnly = true;
            this.textBoxname.Size = new System.Drawing.Size(296, 30);
            this.textBoxname.TabIndex = 1;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxphone
            // 
            this.textBoxphone.Location = new System.Drawing.Point(212, 191);
            this.textBoxphone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxphone.Name = "textBoxphone";
            this.textBoxphone.ReadOnly = true;
            this.textBoxphone.Size = new System.Drawing.Size(296, 30);
            this.textBoxphone.TabIndex = 5;
            this.textBoxphone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(33, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(212, 253);
            this.textBoxaddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxaddress.Multiline = true;
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.ReadOnly = true;
            this.textBoxaddress.Size = new System.Drawing.Size(296, 142);
            this.textBoxaddress.TabIndex = 7;
            this.textBoxaddress.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(33, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxfamily
            // 
            this.textBoxfamily.Location = new System.Drawing.Point(212, 125);
            this.textBoxfamily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxfamily.Name = "textBoxfamily";
            this.textBoxfamily.ReadOnly = true;
            this.textBoxfamily.Size = new System.Drawing.Size(296, 30);
            this.textBoxfamily.TabIndex = 9;
            this.textBoxfamily.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(33, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "family";
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnew.Location = new System.Drawing.Point(15, 469);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(140, 78);
            this.btnnew.TabIndex = 10;
            this.btnnew.Text = "new";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndel.Location = new System.Drawing.Point(460, 469);
            this.btndel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(140, 78);
            this.btndel.TabIndex = 12;
            this.btndel.Text = "del";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnedit.Location = new System.Drawing.Point(312, 469);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(140, 78);
            this.btnedit.TabIndex = 13;
            this.btnedit.Text = "edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsave.Location = new System.Drawing.Point(164, 469);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(140, 78);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnprev
            // 
            this.btnprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnprev.Location = new System.Drawing.Point(315, 581);
            this.btnprev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(140, 78);
            this.btnprev.TabIndex = 18;
            this.btnprev.Text = "prev";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnext.Location = new System.Drawing.Point(166, 581);
            this.btnnext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(140, 78);
            this.btnnext.TabIndex = 17;
            this.btnnext.Text = "next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnlast.Location = new System.Drawing.Point(464, 581);
            this.btnlast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(140, 78);
            this.btnlast.TabIndex = 16;
            this.btnlast.Text = "last";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnfirst.Location = new System.Drawing.Point(18, 581);
            this.btnfirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(140, 78);
            this.btnfirst.TabIndex = 15;
            this.btnfirst.Text = "first";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // comboBoxsearched
            // 
            this.comboBoxsearched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxsearched.FormattingEnabled = true;
            this.comboBoxsearched.Items.AddRange(new object[] {
            "firstname",
            "lastname",
            "phoneno",
            "address"});
            this.comboBoxsearched.Location = new System.Drawing.Point(904, 52);
            this.comboBoxsearched.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxsearched.Name = "comboBoxsearched";
            this.comboBoxsearched.Size = new System.Drawing.Size(276, 33);
            this.comboBoxsearched.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(645, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "searched by:";
            // 
            // textBoxsearchfor
            // 
            this.textBoxsearchfor.Location = new System.Drawing.Point(904, 125);
            this.textBoxsearchfor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxsearchfor.Name = "textBoxsearchfor";
            this.textBoxsearchfor.Size = new System.Drawing.Size(276, 30);
            this.textBoxsearchfor.TabIndex = 22;
            this.textBoxsearchfor.TextChanged += new System.EventHandler(this.textBoxsearchfor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(645, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "searched for:";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsearch.Location = new System.Drawing.Point(652, 180);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(196, 66);
            this.btnsearch.TabIndex = 23;
            this.btnsearch.Text = "search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(652, 342);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 303);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 703);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.textBoxsearchfor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxsearched);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.textBoxfamily);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxaddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxfamily;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.ComboBox comboBoxsearched;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxsearchfor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

