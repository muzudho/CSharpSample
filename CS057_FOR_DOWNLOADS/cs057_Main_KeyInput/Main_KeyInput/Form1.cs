using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs057_Main_KeyInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keys = e.KeyCode;

            this.keyDownTextBox.Text = keys.ToString();

            //switch(keys){
            //    case Keys.Delete:
            //        MessageBox.Show("デリート・キーを押しました。", "△情報103！");
            //        break;
            //}
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Keys keys = e.KeyCode;

            this.keyUpTextBox.Text = keys.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;

            this.keyPressTextBox.Text = keyChar.ToString();
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Keys keys = e.KeyCode;

            this.previewKeyDownTextBox.Text = keys.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            this.KeyPreview = checkBox.Checked;

            if(!checkBox.Checked){
                // 解除した場合

                // フォームにフォーカスを戻します。
                this.ActiveControl = null;
                //×効果なし    this.Activate();
                //×効果なし    this.Focus();
            }
        }
    }
}
