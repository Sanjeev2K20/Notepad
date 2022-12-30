using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class notepad_form : Form
    {
        public notepad_form()
        {
            InitializeComponent();
        }

        private void notepad_form_Load(object sender, EventArgs e)
        {
            this.Text = "Untitled - Notepad";
            rtb_notepad.WordWrap = false;

            sb_date.Text = DateTime.Now.ToLongDateString();
            sb_ln_col.Text = "Ln: 1 Col: 0";
        }

        private void openFile()
        {
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                String[] sep = {"\\"};
                String[] path = ofd.FileName.Split(sep,StringSplitOptions.None);
                this.Text = path[path.Length -1] + " - Notepad";
                rtb_notepad.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void newFile()
        {
            ofd.FileName = "";
            rtb_notepad.Text = "";
            this.Text = "Untitled - Notepad";
        }

        private void saveFile()
        {
            if (ofd.FileName != "")
                rtb_notepad.SaveFile(ofd.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveAsFile()
        {
            sfd.ShowDialog();
            if (sfd.FileName != "")
            {
                rtb_notepad.SaveFile(sfd.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void cutText()
        {
            rtb_notepad.Cut();
        }

        private void copyText()
        {
            rtb_notepad.Copy();
        }

        private void pasteText()
        {
            rtb_notepad.Paste();
        }

        private void delText()
        {
            rtb_notepad.SelectedText = "";
        }

        private void setFont()
        {
            fnd.ShowDialog();
            rtb_notepad.SelectionFont = fnd.Font;
        }

        private void setColor()
        {
            clrd.ShowDialog();
            rtb_notepad.SelectionColor = clrd.Color;
        }

        private void mn_new_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void ts_btn_new_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void ts_btn_open_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void mn_open_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void ts_btn_save_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void mn_save_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void ts_btn_saveas_Click(object sender, EventArgs e)
        {
            saveAsFile();
        }

        private void mn_saveas_Click(object sender, EventArgs e)
        {
            saveAsFile();
        }

        private void mn_cut_Click(object sender, EventArgs e)
        {
            cutText();
        }

        private void ts_btn_cut_Click(object sender, EventArgs e)
        {
            cutText();
        }

        private void mn_copy_Click(object sender, EventArgs e)
        {
            copyText();
        }

        private void ts_btn_copy_Click(object sender, EventArgs e)
        {
            copyText();
        }

        private void mn_paste_Click(object sender, EventArgs e)
        {
            pasteText();
        }

        private void ts_btn_paste_Click(object sender, EventArgs e)
        {
            pasteText();
        }

        private void ts_btn_del_Click(object sender, EventArgs e)
        {
            delText();
        }

        private void mn_delete_Click(object sender, EventArgs e)
        {
            delText();
        }

        private void mn_selectall_Click(object sender, EventArgs e)
        {
            rtb_notepad.SelectAll();
        }

        private void ts_btn_left_Click(object sender, EventArgs e)
        {
            rtb_notepad.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void ts_btn_center_Click(object sender, EventArgs e)
        {
            rtb_notepad.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ts_btn_right_Click(object sender, EventArgs e)
        {
            rtb_notepad.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void mn_word_wrap_Click(object sender, EventArgs e)
        {
            rtb_notepad.WordWrap = !rtb_notepad.WordWrap;
        }

        private void ts_btn_font_Click(object sender, EventArgs e)
        {
            setFont();
        }

        private void mn_font_Click(object sender, EventArgs e)
        {
            setFont();
        }

        private void mn_color_Click(object sender, EventArgs e)
        {
            setColor();
        }

        private void ts_btn_color_Click(object sender, EventArgs e)
        {
            setColor();
        }

        private void ts_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtb_notepad_TextChanged(object sender, EventArgs e)
        {
            int index = rtb_notepad.SelectionStart;
            int line = rtb_notepad.GetLineFromCharIndex(index);


            int firstChar = rtb_notepad.GetFirstCharIndexFromLine(line);
            int column = index - firstChar;
            sb_ln_col.Text = "Ln: " + (line + 1) + " Col: " + column;
        }

        private void rtb_notepad_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int index = rtb_notepad.SelectionStart;
                int line = rtb_notepad.GetLineFromCharIndex(index);


                int firstChar = rtb_notepad.GetFirstCharIndexFromLine(line);
                int column = index - firstChar;
                sb_ln_col.Text = "Ln: " + (line + 1) + " Col: " + column;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            sb_date.Text = DateTime.Now.ToLongDateString();
        }

        private void ts_btn_find_Click(object sender, EventArgs e)
        {
            
        }

        private void mn_zoomin_Click(object sender, EventArgs e)
        {
            if(rtb_notepad.ZoomFactor <= 62)
                rtb_notepad.ZoomFactor += (float)1.1;
        }

        private void mn_zoomout_Click(object sender, EventArgs e)
        {
            if(rtb_notepad.ZoomFactor >= 1.2)
                rtb_notepad.ZoomFactor -= (float)1.1;
        }

        private void mn_zoomreset_Click(object sender, EventArgs e)
        {
            rtb_notepad.ZoomFactor = 1;
        }

        private void mn_statusbar_Click(object sender, EventArgs e)
        {
            status_bar.Visible = !status_bar.Visible;
        }

        private void mn_undo_Click(object sender, EventArgs e)
        {
            if(rtb_notepad.CanUndo)
                rtb_notepad.Undo();
        }

        private void mn_pagesetup_Click(object sender, EventArgs e)
        {
            psd.ShowDialog();
        }



    }
}
