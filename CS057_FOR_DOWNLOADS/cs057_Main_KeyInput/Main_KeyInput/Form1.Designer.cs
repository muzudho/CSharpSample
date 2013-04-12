namespace cs057_Main_KeyInput
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.keyDownTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyUpTextBox = new System.Windows.Forms.TextBox();
            this.keyPressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.previewKeyDownTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.explainTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "(2)押したキー(KeyDown)：";
            // 
            // keyDownTextBox
            // 
            this.keyDownTextBox.Enabled = false;
            this.keyDownTextBox.Location = new System.Drawing.Point(200, 80);
            this.keyDownTextBox.Name = "keyDownTextBox";
            this.keyDownTextBox.Size = new System.Drawing.Size(128, 19);
            this.keyDownTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "(4)放したキー(KeyUp)：";
            // 
            // keyUpTextBox
            // 
            this.keyUpTextBox.Enabled = false;
            this.keyUpTextBox.Location = new System.Drawing.Point(200, 144);
            this.keyUpTextBox.Name = "keyUpTextBox";
            this.keyUpTextBox.Size = new System.Drawing.Size(128, 19);
            this.keyUpTextBox.TabIndex = 3;
            // 
            // keyPressTextBox
            // 
            this.keyPressTextBox.Enabled = false;
            this.keyPressTextBox.Location = new System.Drawing.Point(200, 112);
            this.keyPressTextBox.Name = "keyPressTextBox";
            this.keyPressTextBox.Size = new System.Drawing.Size(128, 19);
            this.keyPressTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "(3)押したキー(KeyPress)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "(1)押したキー(PreviewKeyDown)：";
            // 
            // previewKeyDownTextBox
            // 
            this.previewKeyDownTextBox.Enabled = false;
            this.previewKeyDownTextBox.Location = new System.Drawing.Point(200, 48);
            this.previewKeyDownTextBox.Name = "previewKeyDownTextBox";
            this.previewKeyDownTextBox.Size = new System.Drawing.Size(128, 19);
            this.previewKeyDownTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "↓";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "↓";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "↓";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "C#でのキー入力について";
            // 
            // explainTextBox
            // 
            this.explainTextBox.Location = new System.Drawing.Point(256, 212);
            this.explainTextBox.Multiline = true;
            this.explainTextBox.Name = "explainTextBox";
            this.explainTextBox.ReadOnly = true;
            this.explainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.explainTextBox.Size = new System.Drawing.Size(368, 144);
            this.explainTextBox.TabIndex = 12;
            this.explainTextBox.Text = resources.GetString("explainTextBox.Text");
            this.explainTextBox.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 19);
            this.textBox1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "(6)ただのテキストボックス";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(340, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(243, 16);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "(5)テキストボックスにフォーカスがあっても反応中";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 366);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.explainTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.previewKeyDownTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keyPressTextBox);
            this.Controls.Add(this.keyUpTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyDownTextBox);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "C#練習057　キー入力を受け取るサンプルです。";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyDownTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyUpTextBox;
        private System.Windows.Forms.TextBox keyPressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox previewKeyDownTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox explainTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

