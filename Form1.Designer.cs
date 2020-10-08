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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(141, 40);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(199, 22);
            this.textBoxname.TabIndex = 1;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxphone
            // 
            this.textBoxphone.Location = new System.Drawing.Point(141, 122);
            this.textBoxphone.Name = "textBoxphone";
            this.textBoxphone.Size = new System.Drawing.Size(199, 22);
            this.textBoxphone.TabIndex = 5;
            this.textBoxphone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "phone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(141, 162);
            this.textBoxaddress.Multiline = true;
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(199, 92);
            this.textBoxaddress.TabIndex = 7;
            this.textBoxaddress.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(22, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxfamily
            // 
            this.textBoxfamily.Location = new System.Drawing.Point(141, 80);
            this.textBoxfamily.Name = "textBoxfamily";
            this.textBoxfamily.Size = new System.Drawing.Size(199, 22);
            this.textBoxfamily.TabIndex = 9;
            this.textBoxfamily.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(22, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "family";
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnew.Location = new System.Drawing.Point(48, 300);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(93, 50);
            this.btnnew.TabIndex = 10;
            this.btnnew.Text = "new";
            this.btnnew.UseVisualStyleBackColor = true;
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btndel.Location = new System.Drawing.Point(416, 300);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(93, 50);
            this.btndel.TabIndex = 12;
            this.btndel.Text = "del";
            this.btndel.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnedit.Location = new System.Drawing.Point(304, 300);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(93, 50);
            this.btnedit.TabIndex = 13;
            this.btnedit.Text = "edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsave.Location = new System.Drawing.Point(178, 300);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 50);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnprev
            // 
            this.btnprev.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnprev.Location = new System.Drawing.Point(304, 372);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(93, 50);
            this.btnprev.TabIndex = 18;
            this.btnprev.Text = "prev";
            this.btnprev.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnext.Location = new System.Drawing.Point(178, 372);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(93, 50);
            this.btnnext.TabIndex = 17;
            this.btnnext.Text = "next";
            this.btnnext.UseVisualStyleBackColor = true;
            // 
            // btnlast
            // 
            this.btnlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnlast.Location = new System.Drawing.Point(416, 372);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(93, 50);
            this.btnlast.TabIndex = 16;
            this.btnlast.Text = "last";
            this.btnlast.UseVisualStyleBackColor = true;
            // 
            // btnfirst
            // 
            this.btnfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnfirst.Location = new System.Drawing.Point(48, 372);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(93, 50);
            this.btnfirst.TabIndex = 15;
            this.btnfirst.Text = "first";
            this.btnfirst.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

