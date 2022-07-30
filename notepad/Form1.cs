using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = saveFileDialog1.ShowDialog();
            if(d==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                richTextBox1.Clear();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            if(d==DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(path!=null)
            {
                richTextBox1.SaveFile(path);
            }else
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                richTextBox1.Clear();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            path = null;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if( colorDialog1.ShowDialog() ==DialogResult.OK)
            {
                if(richTextBox1.SelectedText!="")
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
                else
                {
                    richTextBox1.ForeColor = colorDialog1.Color;

                }
            }

        }
        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (richTextBox1.SelectedText != "")
                    {
                        richTextBox1.SelectionFont = fontDialog1.Font;
                    }
                    else
                    {
                        richTextBox1.Font = fontDialog1.Font;
                    }
                }
            }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }
    }
    }

