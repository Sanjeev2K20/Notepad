namespace Notepad
{
    partial class notepad_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notepad_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_open = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_save = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_pagesetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_find = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_replace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_selectall = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_zoomin = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_zoomout = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_zoomreset = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_statusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_word_wrap = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_font = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_color = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_viewhelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_btn_new = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_open = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_save = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_saveas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btn_cut = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_copy = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_paste = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_del = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btn_find = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_replace = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btn_left = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_center = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_right = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btn_font = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_color = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btn_exit = new System.Windows.Forms.ToolStripButton();
            this.rtb_notepad = new System.Windows.Forms.RichTextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.fnd = new System.Windows.Forms.FontDialog();
            this.clrd = new System.Windows.Forms.ColorDialog();
            this.status_bar = new System.Windows.Forms.StatusStrip();
            this.sb_date = new System.Windows.Forms.ToolStripStatusLabel();
            this.sb_ln_col = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.psd = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.status_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.formatToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_new,
            this.mn_open,
            this.mn_save,
            this.mn_saveas,
            this.toolStripSeparator6,
            this.mn_pagesetup,
            this.mn_print,
            this.toolStripSeparator7,
            this.mn_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mn_new
            // 
            this.mn_new.Name = "mn_new";
            this.mn_new.Size = new System.Drawing.Size(152, 22);
            this.mn_new.Text = "New";
            this.mn_new.Click += new System.EventHandler(this.mn_new_Click);
            // 
            // mn_open
            // 
            this.mn_open.Name = "mn_open";
            this.mn_open.Size = new System.Drawing.Size(152, 22);
            this.mn_open.Text = "Open";
            this.mn_open.Click += new System.EventHandler(this.mn_open_Click);
            // 
            // mn_save
            // 
            this.mn_save.Name = "mn_save";
            this.mn_save.Size = new System.Drawing.Size(152, 22);
            this.mn_save.Text = "Save";
            this.mn_save.Click += new System.EventHandler(this.mn_save_Click);
            // 
            // mn_saveas
            // 
            this.mn_saveas.Name = "mn_saveas";
            this.mn_saveas.Size = new System.Drawing.Size(152, 22);
            this.mn_saveas.Text = "Save As";
            this.mn_saveas.Click += new System.EventHandler(this.mn_saveas_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // mn_pagesetup
            // 
            this.mn_pagesetup.Name = "mn_pagesetup";
            this.mn_pagesetup.Size = new System.Drawing.Size(152, 22);
            this.mn_pagesetup.Text = "Page Setup";
            this.mn_pagesetup.Click += new System.EventHandler(this.mn_pagesetup_Click);
            // 
            // mn_print
            // 
            this.mn_print.Name = "mn_print";
            this.mn_print.Size = new System.Drawing.Size(152, 22);
            this.mn_print.Text = "Print";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(149, 6);
            // 
            // mn_exit
            // 
            this.mn_exit.Name = "mn_exit";
            this.mn_exit.Size = new System.Drawing.Size(152, 22);
            this.mn_exit.Text = "Exit";
            this.mn_exit.Click += new System.EventHandler(this.mn_exit_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_undo,
            this.toolStripSeparator8,
            this.mn_cut,
            this.mn_copy,
            this.mn_paste,
            this.mn_delete,
            this.toolStripSeparator9,
            this.mn_find,
            this.mn_replace,
            this.toolStripSeparator10,
            this.mn_selectall});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.openToolStripMenuItem.Text = "Edit";
            // 
            // mn_undo
            // 
            this.mn_undo.Name = "mn_undo";
            this.mn_undo.Size = new System.Drawing.Size(164, 22);
            this.mn_undo.Text = "Undo";
            this.mn_undo.Click += new System.EventHandler(this.mn_undo_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(161, 6);
            // 
            // mn_cut
            // 
            this.mn_cut.Name = "mn_cut";
            this.mn_cut.Size = new System.Drawing.Size(164, 22);
            this.mn_cut.Text = "Cut";
            this.mn_cut.Click += new System.EventHandler(this.mn_cut_Click);
            // 
            // mn_copy
            // 
            this.mn_copy.Name = "mn_copy";
            this.mn_copy.Size = new System.Drawing.Size(164, 22);
            this.mn_copy.Text = "Copy";
            this.mn_copy.Click += new System.EventHandler(this.mn_copy_Click);
            // 
            // mn_paste
            // 
            this.mn_paste.Name = "mn_paste";
            this.mn_paste.Size = new System.Drawing.Size(164, 22);
            this.mn_paste.Text = "Paste";
            this.mn_paste.Click += new System.EventHandler(this.mn_paste_Click);
            // 
            // mn_delete
            // 
            this.mn_delete.Name = "mn_delete";
            this.mn_delete.Size = new System.Drawing.Size(164, 22);
            this.mn_delete.Text = "Delete";
            this.mn_delete.Click += new System.EventHandler(this.mn_delete_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(161, 6);
            // 
            // mn_find
            // 
            this.mn_find.Name = "mn_find";
            this.mn_find.Size = new System.Drawing.Size(164, 22);
            this.mn_find.Text = "Find";
            // 
            // mn_replace
            // 
            this.mn_replace.Name = "mn_replace";
            this.mn_replace.Size = new System.Drawing.Size(164, 22);
            this.mn_replace.Text = "Find and Replace";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(161, 6);
            // 
            // mn_selectall
            // 
            this.mn_selectall.Name = "mn_selectall";
            this.mn_selectall.Size = new System.Drawing.Size(164, 22);
            this.mn_selectall.Text = "Select All";
            this.mn_selectall.Click += new System.EventHandler(this.mn_selectall_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.mn_statusbar});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_zoomin,
            this.mn_zoomout,
            this.mn_zoomreset});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // mn_zoomin
            // 
            this.mn_zoomin.Name = "mn_zoomin";
            this.mn_zoomin.Size = new System.Drawing.Size(178, 22);
            this.mn_zoomin.Text = "Zoom In";
            this.mn_zoomin.Click += new System.EventHandler(this.mn_zoomin_Click);
            // 
            // mn_zoomout
            // 
            this.mn_zoomout.Name = "mn_zoomout";
            this.mn_zoomout.Size = new System.Drawing.Size(178, 22);
            this.mn_zoomout.Text = "Zoom Out";
            this.mn_zoomout.Click += new System.EventHandler(this.mn_zoomout_Click);
            // 
            // mn_zoomreset
            // 
            this.mn_zoomreset.Name = "mn_zoomreset";
            this.mn_zoomreset.Size = new System.Drawing.Size(178, 22);
            this.mn_zoomreset.Text = "Reset Default Zoom";
            this.mn_zoomreset.Click += new System.EventHandler(this.mn_zoomreset_Click);
            // 
            // mn_statusbar
            // 
            this.mn_statusbar.Checked = true;
            this.mn_statusbar.CheckOnClick = true;
            this.mn_statusbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mn_statusbar.Name = "mn_statusbar";
            this.mn_statusbar.Size = new System.Drawing.Size(152, 22);
            this.mn_statusbar.Text = "Status Bar";
            this.mn_statusbar.Click += new System.EventHandler(this.mn_statusbar_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_word_wrap,
            this.mn_font,
            this.mn_color});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // mn_word_wrap
            // 
            this.mn_word_wrap.CheckOnClick = true;
            this.mn_word_wrap.Name = "mn_word_wrap";
            this.mn_word_wrap.Size = new System.Drawing.Size(152, 22);
            this.mn_word_wrap.Text = "Word Wrap";
            this.mn_word_wrap.Click += new System.EventHandler(this.mn_word_wrap_Click);
            // 
            // mn_font
            // 
            this.mn_font.Name = "mn_font";
            this.mn_font.Size = new System.Drawing.Size(152, 22);
            this.mn_font.Text = "Font";
            this.mn_font.Click += new System.EventHandler(this.mn_font_Click);
            // 
            // mn_color
            // 
            this.mn_color.Name = "mn_color";
            this.mn_color.Size = new System.Drawing.Size(152, 22);
            this.mn_color.Text = "Color";
            this.mn_color.Click += new System.EventHandler(this.mn_color_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_viewhelp,
            this.toolStripSeparator11,
            this.mn_about});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mn_viewhelp
            // 
            this.mn_viewhelp.Name = "mn_viewhelp";
            this.mn_viewhelp.Size = new System.Drawing.Size(127, 22);
            this.mn_viewhelp.Text = "View Help";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(124, 6);
            // 
            // mn_about
            // 
            this.mn_about.Name = "mn_about";
            this.mn_about.Size = new System.Drawing.Size(127, 22);
            this.mn_about.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_btn_new,
            this.ts_btn_open,
            this.ts_btn_save,
            this.ts_btn_saveas,
            this.toolStripSeparator1,
            this.ts_btn_cut,
            this.ts_btn_copy,
            this.ts_btn_paste,
            this.ts_btn_del,
            this.toolStripSeparator2,
            this.ts_btn_find,
            this.ts_btn_replace,
            this.toolStripSeparator3,
            this.ts_btn_left,
            this.ts_btn_center,
            this.ts_btn_right,
            this.toolStripSeparator4,
            this.ts_btn_font,
            this.ts_btn_color,
            this.toolStripSeparator5,
            this.ts_btn_exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(676, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_btn_new
            // 
            this.ts_btn_new.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_new.Image")));
            this.ts_btn_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_new.Name = "ts_btn_new";
            this.ts_btn_new.Size = new System.Drawing.Size(35, 35);
            this.ts_btn_new.Text = "New";
            this.ts_btn_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_new.Click += new System.EventHandler(this.ts_btn_new_Click);
            // 
            // ts_btn_open
            // 
            this.ts_btn_open.Image = global::Notepad.Properties.Resources.open;
            this.ts_btn_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_open.Name = "ts_btn_open";
            this.ts_btn_open.Size = new System.Drawing.Size(40, 35);
            this.ts_btn_open.Text = "Open";
            this.ts_btn_open.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_open.Click += new System.EventHandler(this.ts_btn_open_Click);
            // 
            // ts_btn_save
            // 
            this.ts_btn_save.Image = global::Notepad.Properties.Resources.save;
            this.ts_btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_save.Name = "ts_btn_save";
            this.ts_btn_save.Size = new System.Drawing.Size(35, 35);
            this.ts_btn_save.Text = "Save";
            this.ts_btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_save.Click += new System.EventHandler(this.ts_btn_save_Click);
            // 
            // ts_btn_saveas
            // 
            this.ts_btn_saveas.Image = global::Notepad.Properties.Resources.save_as;
            this.ts_btn_saveas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_saveas.Name = "ts_btn_saveas";
            this.ts_btn_saveas.Size = new System.Drawing.Size(51, 35);
            this.ts_btn_saveas.Text = "Save As";
            this.ts_btn_saveas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_saveas.Click += new System.EventHandler(this.ts_btn_saveas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // ts_btn_cut
            // 
            this.ts_btn_cut.Image = global::Notepad.Properties.Resources.cutting;
            this.ts_btn_cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_cut.Name = "ts_btn_cut";
            this.ts_btn_cut.Size = new System.Drawing.Size(30, 35);
            this.ts_btn_cut.Text = "Cut";
            this.ts_btn_cut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_cut.Click += new System.EventHandler(this.ts_btn_cut_Click);
            // 
            // ts_btn_copy
            // 
            this.ts_btn_copy.Image = global::Notepad.Properties.Resources.copy;
            this.ts_btn_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_copy.Name = "ts_btn_copy";
            this.ts_btn_copy.Size = new System.Drawing.Size(39, 35);
            this.ts_btn_copy.Text = "Copy";
            this.ts_btn_copy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_copy.Click += new System.EventHandler(this.ts_btn_copy_Click);
            // 
            // ts_btn_paste
            // 
            this.ts_btn_paste.Image = global::Notepad.Properties.Resources.paste;
            this.ts_btn_paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_paste.Name = "ts_btn_paste";
            this.ts_btn_paste.Size = new System.Drawing.Size(39, 35);
            this.ts_btn_paste.Text = "Paste";
            this.ts_btn_paste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_paste.Click += new System.EventHandler(this.ts_btn_paste_Click);
            // 
            // ts_btn_del
            // 
            this.ts_btn_del.Image = global::Notepad.Properties.Resources.delete;
            this.ts_btn_del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_del.Name = "ts_btn_del";
            this.ts_btn_del.Size = new System.Drawing.Size(28, 35);
            this.ts_btn_del.Text = "Del";
            this.ts_btn_del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_del.Click += new System.EventHandler(this.ts_btn_del_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // ts_btn_find
            // 
            this.ts_btn_find.Image = global::Notepad.Properties.Resources.find;
            this.ts_btn_find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_find.Name = "ts_btn_find";
            this.ts_btn_find.Size = new System.Drawing.Size(34, 35);
            this.ts_btn_find.Text = "Find";
            this.ts_btn_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_find.Click += new System.EventHandler(this.ts_btn_find_Click);
            // 
            // ts_btn_replace
            // 
            this.ts_btn_replace.Image = global::Notepad.Properties.Resources.find_and_replace;
            this.ts_btn_replace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_replace.Name = "ts_btn_replace";
            this.ts_btn_replace.Size = new System.Drawing.Size(52, 35);
            this.ts_btn_replace.Text = "Replace";
            this.ts_btn_replace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // ts_btn_left
            // 
            this.ts_btn_left.Image = global::Notepad.Properties.Resources.align_left;
            this.ts_btn_left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_left.Name = "ts_btn_left";
            this.ts_btn_left.Size = new System.Drawing.Size(31, 35);
            this.ts_btn_left.Text = "Left";
            this.ts_btn_left.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_left.Click += new System.EventHandler(this.ts_btn_left_Click);
            // 
            // ts_btn_center
            // 
            this.ts_btn_center.Image = global::Notepad.Properties.Resources.align_center;
            this.ts_btn_center.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_center.Name = "ts_btn_center";
            this.ts_btn_center.Size = new System.Drawing.Size(46, 35);
            this.ts_btn_center.Text = "Center";
            this.ts_btn_center.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_center.Click += new System.EventHandler(this.ts_btn_center_Click);
            // 
            // ts_btn_right
            // 
            this.ts_btn_right.Image = global::Notepad.Properties.Resources.right_align;
            this.ts_btn_right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_right.Name = "ts_btn_right";
            this.ts_btn_right.Size = new System.Drawing.Size(39, 35);
            this.ts_btn_right.Text = "Right";
            this.ts_btn_right.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_right.Click += new System.EventHandler(this.ts_btn_right_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // ts_btn_font
            // 
            this.ts_btn_font.Image = global::Notepad.Properties.Resources.font;
            this.ts_btn_font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_font.Name = "ts_btn_font";
            this.ts_btn_font.Size = new System.Drawing.Size(35, 35);
            this.ts_btn_font.Text = "Font";
            this.ts_btn_font.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_font.Click += new System.EventHandler(this.ts_btn_font_Click);
            // 
            // ts_btn_color
            // 
            this.ts_btn_color.Image = global::Notepad.Properties.Resources.palette;
            this.ts_btn_color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_color.Name = "ts_btn_color";
            this.ts_btn_color.Size = new System.Drawing.Size(40, 35);
            this.ts_btn_color.Text = "Color";
            this.ts_btn_color.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_color.Click += new System.EventHandler(this.ts_btn_color_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // ts_btn_exit
            // 
            this.ts_btn_exit.Image = global::Notepad.Properties.Resources.exit;
            this.ts_btn_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_exit.Name = "ts_btn_exit";
            this.ts_btn_exit.Size = new System.Drawing.Size(30, 35);
            this.ts_btn_exit.Text = "Exit";
            this.ts_btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_exit.Click += new System.EventHandler(this.ts_btn_exit_Click);
            // 
            // rtb_notepad
            // 
            this.rtb_notepad.AutoWordSelection = true;
            this.rtb_notepad.Location = new System.Drawing.Point(0, 65);
            this.rtb_notepad.Name = "rtb_notepad";
            this.rtb_notepad.Size = new System.Drawing.Size(676, 320);
            this.rtb_notepad.TabIndex = 2;
            this.rtb_notepad.Text = "";
            this.rtb_notepad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtb_notepad_MouseClick);
            this.rtb_notepad.TextChanged += new System.EventHandler(this.rtb_notepad_TextChanged);
            // 
            // ofd
            // 
            this.ofd.FileName = "Open File";
            this.ofd.Filter = "(Text Documents) | *.txt";
            // 
            // sfd
            // 
            this.sfd.Filter = "Text Documents | *.txt";
            // 
            // status_bar
            // 
            this.status_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sb_date,
            this.sb_ln_col});
            this.status_bar.Location = new System.Drawing.Point(0, 363);
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(676, 22);
            this.status_bar.TabIndex = 3;
            this.status_bar.Text = "statusStrip1";
            // 
            // sb_date
            // 
            this.sb_date.Name = "sb_date";
            this.sb_date.Size = new System.Drawing.Size(31, 17);
            this.sb_date.Text = "Date";
            // 
            // sb_ln_col
            // 
            this.sb_ln_col.Margin = new System.Windows.Forms.Padding(400, 3, 0, 2);
            this.sb_ln_col.Name = "sb_ln_col";
            this.sb_ln_col.Size = new System.Drawing.Size(41, 17);
            this.sb_ln_col.Text = "Ln Col";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notepad_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 385);
            this.Controls.Add(this.status_bar);
            this.Controls.Add(this.rtb_notepad);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "notepad_form";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.notepad_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.status_bar.ResumeLayout(false);
            this.status_bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_btn_new;
        private System.Windows.Forms.ToolStripButton ts_btn_open;
        private System.Windows.Forms.ToolStripButton ts_btn_save;
        private System.Windows.Forms.ToolStripButton ts_btn_saveas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_btn_cut;
        private System.Windows.Forms.ToolStripButton ts_btn_copy;
        private System.Windows.Forms.ToolStripButton ts_btn_paste;
        private System.Windows.Forms.ToolStripButton ts_btn_del;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ts_btn_find;
        private System.Windows.Forms.ToolStripButton ts_btn_replace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ts_btn_left;
        private System.Windows.Forms.ToolStripButton ts_btn_center;
        private System.Windows.Forms.ToolStripButton ts_btn_right;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ts_btn_font;
        private System.Windows.Forms.ToolStripButton ts_btn_color;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ts_btn_exit;
        private System.Windows.Forms.ToolStripMenuItem mn_new;
        private System.Windows.Forms.ToolStripMenuItem mn_open;
        private System.Windows.Forms.ToolStripMenuItem mn_save;
        private System.Windows.Forms.ToolStripMenuItem mn_saveas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mn_pagesetup;
        private System.Windows.Forms.ToolStripMenuItem mn_print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mn_exit;
        private System.Windows.Forms.ToolStripMenuItem mn_undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mn_cut;
        private System.Windows.Forms.ToolStripMenuItem mn_copy;
        private System.Windows.Forms.ToolStripMenuItem mn_paste;
        private System.Windows.Forms.ToolStripMenuItem mn_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem mn_find;
        private System.Windows.Forms.ToolStripMenuItem mn_replace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem mn_selectall;
        private System.Windows.Forms.ToolStripMenuItem mn_word_wrap;
        private System.Windows.Forms.ToolStripMenuItem mn_font;
        private System.Windows.Forms.ToolStripMenuItem mn_color;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_zoomin;
        private System.Windows.Forms.ToolStripMenuItem mn_zoomout;
        private System.Windows.Forms.ToolStripMenuItem mn_zoomreset;
        private System.Windows.Forms.ToolStripMenuItem mn_statusbar;
        private System.Windows.Forms.ToolStripMenuItem mn_viewhelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem mn_about;
        private System.Windows.Forms.RichTextBox rtb_notepad;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.FontDialog fnd;
        private System.Windows.Forms.ColorDialog clrd;
        private System.Windows.Forms.StatusStrip status_bar;
        private System.Windows.Forms.ToolStripStatusLabel sb_date;
        private System.Windows.Forms.ToolStripStatusLabel sb_ln_col;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PageSetupDialog psd;
    }
}