namespace WinRGZOSI
{
    partial class Emulator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        /// 
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExceptionLabel = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BuffersAmount = new System.Windows.Forms.TextBox();
            this.FileSize = new System.Windows.Forms.TextBox();
            this.BufferSize = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CollapsePanel = new System.Windows.Forms.Panel();
            this.ExitPanel = new System.Windows.Forms.Panel();
            this.vzuflowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.vzupanel1 = new System.Windows.Forms.Panel();
            this.vzupanel2 = new System.Windows.Forms.Panel();
            this.vzupanel3 = new System.Windows.Forms.Panel();
            this.vzupanel4 = new System.Windows.Forms.Panel();
            this.vzupanel5 = new System.Windows.Forms.Panel();
            this.vzupanel6 = new System.Windows.Forms.Panel();
            this.vzupanel7 = new System.Windows.Forms.Panel();
            this.vzupanel8 = new System.Windows.Forms.Panel();
            this.vzupanel9 = new System.Windows.Forms.Panel();
            this.vzupanel10 = new System.Windows.Forms.Panel();
            this.vzupanel11 = new System.Windows.Forms.Panel();
            this.vzupanel12 = new System.Windows.Forms.Panel();
            this.vzupanel13 = new System.Windows.Forms.Panel();
            this.vzupanel14 = new System.Windows.Forms.Panel();
            this.bufferflowpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bufferpanel1 = new System.Windows.Forms.Panel();
            this.bufferpanel2 = new System.Windows.Forms.Panel();
            this.bufferpanel3 = new System.Windows.Forms.Panel();
            this.bufferpanel4 = new System.Windows.Forms.Panel();
            this.bufferpanel5 = new System.Windows.Forms.Panel();
            this.bufferpanel6 = new System.Windows.Forms.Panel();
            this.bufferpanel7 = new System.Windows.Forms.Panel();
            this.bufferpanel8 = new System.Windows.Forms.Panel();
            this.bufferpanel9 = new System.Windows.Forms.Panel();
            this.bufferpanel10 = new System.Windows.Forms.Panel();
            this.bufferpanel11 = new System.Windows.Forms.Panel();
            this.bufferpanel12 = new System.Windows.Forms.Panel();
            this.bufferpanel13 = new System.Windows.Forms.Panel();
            this.bufferpanel14 = new System.Windows.Forms.Panel();
            this.vzupanel = new System.Windows.Forms.Label();
            this.Bufferlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.vzuflowpanel.SuspendLayout();
            this.bufferflowpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ExceptionLabel);
            this.panel1.Controls.Add(this.CheckButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BuffersAmount);
            this.panel1.Controls.Add(this.FileSize);
            this.panel1.Controls.Add(this.BufferSize);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 206);
            this.panel1.TabIndex = 0;
            // 
            // ExceptionLabel
            // 
            this.ExceptionLabel.AutoSize = true;
            this.ExceptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExceptionLabel.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExceptionLabel.ForeColor = System.Drawing.Color.Red;
            this.ExceptionLabel.Location = new System.Drawing.Point(383, 178);
            this.ExceptionLabel.Name = "ExceptionLabel";
            this.ExceptionLabel.Size = new System.Drawing.Size(184, 18);
            this.ExceptionLabel.TabIndex = 5;
            this.ExceptionLabel.Text = "Incorrect input values";
            this.ExceptionLabel.Visible = false;
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckButton.Location = new System.Drawing.Point(432, 77);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckButton.Size = new System.Drawing.Size(69, 62);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButtonClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "КОЛИЧЕСТВО БУФЕРОВ";
            // 
            // BuffersAmount
            // 
            this.BuffersAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BuffersAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BuffersAmount.Location = new System.Drawing.Point(245, 29);
            this.BuffersAmount.MaxLength = 2;
            this.BuffersAmount.Name = "BuffersAmount";
            this.BuffersAmount.Size = new System.Drawing.Size(60, 29);
            this.BuffersAmount.TabIndex = 0;
            // 
            // FileSize
            // 
            this.FileSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FileSize.Location = new System.Drawing.Point(245, 152);
            this.FileSize.MaxLength = 5;
            this.FileSize.Name = "FileSize";
            this.FileSize.Size = new System.Drawing.Size(60, 29);
            this.FileSize.TabIndex = 0;
            // 
            // BufferSize
            // 
            this.BufferSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BufferSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BufferSize.Location = new System.Drawing.Point(245, 91);
            this.BufferSize.MaxLength = 5;
            this.BufferSize.Name = "BufferSize";
            this.BufferSize.Size = new System.Drawing.Size(60, 29);
            this.BufferSize.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 176);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(77, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "РАЗМЕР ФАЙЛА";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "РАЗМЕР БУФЕРА";
            // 
            // TopPanel
            // 
            this.TopPanel.AllowDrop = true;
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TopPanel.Controls.Add(this.CollapsePanel);
            this.TopPanel.Controls.Add(this.ExitPanel);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(967, 36);
            this.TopPanel.TabIndex = 1;
            // 
            // CollapsePanel
            // 
            this.CollapsePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CollapsePanel.BackColor = System.Drawing.Color.Gray;
            this.CollapsePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CollapsePanel.Location = new System.Drawing.Point(889, 0);
            this.CollapsePanel.Name = "CollapsePanel";
            this.CollapsePanel.Size = new System.Drawing.Size(36, 36);
            this.CollapsePanel.TabIndex = 2;
            this.CollapsePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CollapsePanel_MouseClick);
            this.CollapsePanel.MouseLeave += new System.EventHandler(this.CollapsePanel_Leave);
            this.CollapsePanel.MouseHover += new System.EventHandler(this.CollapsePanel_Hover);
            // 
            // ExitPanel
            // 
            this.ExitPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitPanel.BackColor = System.Drawing.Color.LightCoral;
            this.ExitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExitPanel.Location = new System.Drawing.Point(931, 0);
            this.ExitPanel.Name = "ExitPanel";
            this.ExitPanel.Size = new System.Drawing.Size(36, 36);
            this.ExitPanel.TabIndex = 0;
            this.ExitPanel.Click += new System.EventHandler(this.ExitClick);
            this.ExitPanel.MouseLeave += new System.EventHandler(this.ExitHoverLeave);
            this.ExitPanel.MouseHover += new System.EventHandler(this.ExitHover);
            // 
            // vzuflowpanel
            // 
            this.vzuflowpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vzuflowpanel.BackColor = System.Drawing.Color.Green;
            this.vzuflowpanel.Controls.Add(this.vzupanel1);
            this.vzuflowpanel.Controls.Add(this.vzupanel2);
            this.vzuflowpanel.Controls.Add(this.vzupanel3);
            this.vzuflowpanel.Controls.Add(this.vzupanel4);
            this.vzuflowpanel.Controls.Add(this.vzupanel5);
            this.vzuflowpanel.Controls.Add(this.vzupanel6);
            this.vzuflowpanel.Controls.Add(this.vzupanel7);
            this.vzuflowpanel.Controls.Add(this.vzupanel8);
            this.vzuflowpanel.Controls.Add(this.vzupanel9);
            this.vzuflowpanel.Controls.Add(this.vzupanel10);
            this.vzuflowpanel.Controls.Add(this.vzupanel11);
            this.vzuflowpanel.Controls.Add(this.vzupanel12);
            this.vzuflowpanel.Controls.Add(this.vzupanel13);
            this.vzuflowpanel.Controls.Add(this.vzupanel14);
            this.vzuflowpanel.Location = new System.Drawing.Point(172, 66);
            this.vzuflowpanel.Name = "vzuflowpanel";
            this.vzuflowpanel.Padding = new System.Windows.Forms.Padding(5, 6, 5, 5);
            this.vzuflowpanel.Size = new System.Drawing.Size(753, 80);
            this.vzuflowpanel.TabIndex = 3;
            // 
            // vzupanel1
            // 
            this.vzupanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel1.Location = new System.Drawing.Point(10, 9);
            this.vzupanel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel1.Name = "vzupanel1";
            this.vzupanel1.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel1.Size = new System.Drawing.Size(43, 60);
            this.vzupanel1.TabIndex = 0;
            this.vzupanel1.Visible = false;
            // 
            // vzupanel2
            // 
            this.vzupanel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel2.Location = new System.Drawing.Point(63, 9);
            this.vzupanel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel2.Name = "vzupanel2";
            this.vzupanel2.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel2.Size = new System.Drawing.Size(43, 60);
            this.vzupanel2.TabIndex = 0;
            this.vzupanel2.Visible = false;
            // 
            // vzupanel3
            // 
            this.vzupanel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel3.Location = new System.Drawing.Point(116, 9);
            this.vzupanel3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel3.Name = "vzupanel3";
            this.vzupanel3.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel3.Size = new System.Drawing.Size(43, 60);
            this.vzupanel3.TabIndex = 0;
            this.vzupanel3.Visible = false;
            // 
            // vzupanel4
            // 
            this.vzupanel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel4.Location = new System.Drawing.Point(169, 9);
            this.vzupanel4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel4.Name = "vzupanel4";
            this.vzupanel4.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel4.Size = new System.Drawing.Size(43, 60);
            this.vzupanel4.TabIndex = 0;
            this.vzupanel4.Visible = false;
            // 
            // vzupanel5
            // 
            this.vzupanel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel5.Location = new System.Drawing.Point(222, 9);
            this.vzupanel5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel5.Name = "vzupanel5";
            this.vzupanel5.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel5.Size = new System.Drawing.Size(43, 60);
            this.vzupanel5.TabIndex = 0;
            this.vzupanel5.Visible = false;
            // 
            // vzupanel6
            // 
            this.vzupanel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel6.Location = new System.Drawing.Point(275, 9);
            this.vzupanel6.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel6.Name = "vzupanel6";
            this.vzupanel6.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel6.Size = new System.Drawing.Size(43, 60);
            this.vzupanel6.TabIndex = 0;
            this.vzupanel6.Visible = false;
            // 
            // vzupanel7
            // 
            this.vzupanel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel7.Location = new System.Drawing.Point(328, 9);
            this.vzupanel7.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel7.Name = "vzupanel7";
            this.vzupanel7.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel7.Size = new System.Drawing.Size(43, 60);
            this.vzupanel7.TabIndex = 0;
            this.vzupanel7.Visible = false;
            // 
            // vzupanel8
            // 
            this.vzupanel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel8.Location = new System.Drawing.Point(381, 9);
            this.vzupanel8.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel8.Name = "vzupanel8";
            this.vzupanel8.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel8.Size = new System.Drawing.Size(43, 60);
            this.vzupanel8.TabIndex = 0;
            this.vzupanel8.Visible = false;
            // 
            // vzupanel9
            // 
            this.vzupanel9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel9.Location = new System.Drawing.Point(434, 9);
            this.vzupanel9.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel9.Name = "vzupanel9";
            this.vzupanel9.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel9.Size = new System.Drawing.Size(43, 60);
            this.vzupanel9.TabIndex = 0;
            this.vzupanel9.Visible = false;
            // 
            // vzupanel10
            // 
            this.vzupanel10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel10.Location = new System.Drawing.Point(487, 9);
            this.vzupanel10.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel10.Name = "vzupanel10";
            this.vzupanel10.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel10.Size = new System.Drawing.Size(43, 60);
            this.vzupanel10.TabIndex = 0;
            this.vzupanel10.Visible = false;
            // 
            // vzupanel11
            // 
            this.vzupanel11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel11.Location = new System.Drawing.Point(540, 9);
            this.vzupanel11.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel11.Name = "vzupanel11";
            this.vzupanel11.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel11.Size = new System.Drawing.Size(43, 60);
            this.vzupanel11.TabIndex = 0;
            this.vzupanel11.Visible = false;
            // 
            // vzupanel12
            // 
            this.vzupanel12.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel12.Location = new System.Drawing.Point(593, 9);
            this.vzupanel12.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel12.Name = "vzupanel12";
            this.vzupanel12.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel12.Size = new System.Drawing.Size(43, 60);
            this.vzupanel12.TabIndex = 0;
            this.vzupanel12.Visible = false;
            // 
            // vzupanel13
            // 
            this.vzupanel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel13.Location = new System.Drawing.Point(646, 9);
            this.vzupanel13.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel13.Name = "vzupanel13";
            this.vzupanel13.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel13.Size = new System.Drawing.Size(43, 60);
            this.vzupanel13.TabIndex = 0;
            this.vzupanel13.Visible = false;
            // 
            // vzupanel14
            // 
            this.vzupanel14.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vzupanel14.Location = new System.Drawing.Point(699, 9);
            this.vzupanel14.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.vzupanel14.Name = "vzupanel14";
            this.vzupanel14.Padding = new System.Windows.Forms.Padding(3);
            this.vzupanel14.Size = new System.Drawing.Size(43, 60);
            this.vzupanel14.TabIndex = 0;
            this.vzupanel14.Visible = false;
            // 
            // bufferflowpanel
            // 
            this.bufferflowpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bufferflowpanel.BackColor = System.Drawing.Color.Green;
            this.bufferflowpanel.Controls.Add(this.bufferpanel1);
            this.bufferflowpanel.Controls.Add(this.bufferpanel2);
            this.bufferflowpanel.Controls.Add(this.bufferpanel3);
            this.bufferflowpanel.Controls.Add(this.bufferpanel4);
            this.bufferflowpanel.Controls.Add(this.bufferpanel5);
            this.bufferflowpanel.Controls.Add(this.bufferpanel6);
            this.bufferflowpanel.Controls.Add(this.bufferpanel7);
            this.bufferflowpanel.Controls.Add(this.bufferpanel8);
            this.bufferflowpanel.Controls.Add(this.bufferpanel9);
            this.bufferflowpanel.Controls.Add(this.bufferpanel10);
            this.bufferflowpanel.Controls.Add(this.bufferpanel11);
            this.bufferflowpanel.Controls.Add(this.bufferpanel12);
            this.bufferflowpanel.Controls.Add(this.bufferpanel13);
            this.bufferflowpanel.Controls.Add(this.bufferpanel14);
            this.bufferflowpanel.Location = new System.Drawing.Point(172, 232);
            this.bufferflowpanel.Name = "bufferflowpanel";
            this.bufferflowpanel.Padding = new System.Windows.Forms.Padding(5, 6, 5, 5);
            this.bufferflowpanel.Size = new System.Drawing.Size(753, 80);
            this.bufferflowpanel.TabIndex = 3;
            // 
            // bufferpanel1
            // 
            this.bufferpanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel1.Location = new System.Drawing.Point(10, 9);
            this.bufferpanel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel1.Name = "bufferpanel1";
            this.bufferpanel1.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel1.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel1.TabIndex = 0;
            this.bufferpanel1.Visible = false;
            // 
            // bufferpanel2
            // 
            this.bufferpanel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel2.Location = new System.Drawing.Point(63, 9);
            this.bufferpanel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel2.Name = "bufferpanel2";
            this.bufferpanel2.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel2.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel2.TabIndex = 0;
            this.bufferpanel2.Visible = false;
            // 
            // bufferpanel3
            // 
            this.bufferpanel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel3.Location = new System.Drawing.Point(116, 9);
            this.bufferpanel3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel3.Name = "bufferpanel3";
            this.bufferpanel3.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel3.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel3.TabIndex = 0;
            this.bufferpanel3.Visible = false;
            // 
            // bufferpanel4
            // 
            this.bufferpanel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel4.Location = new System.Drawing.Point(169, 9);
            this.bufferpanel4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel4.Name = "bufferpanel4";
            this.bufferpanel4.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel4.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel4.TabIndex = 0;
            this.bufferpanel4.Visible = false;
            // 
            // bufferpanel5
            // 
            this.bufferpanel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel5.Location = new System.Drawing.Point(222, 9);
            this.bufferpanel5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel5.Name = "bufferpanel5";
            this.bufferpanel5.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel5.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel5.TabIndex = 0;
            this.bufferpanel5.Visible = false;
            // 
            // bufferpanel6
            // 
            this.bufferpanel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel6.Location = new System.Drawing.Point(275, 9);
            this.bufferpanel6.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel6.Name = "bufferpanel6";
            this.bufferpanel6.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel6.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel6.TabIndex = 0;
            this.bufferpanel6.Visible = false;
            // 
            // bufferpanel7
            // 
            this.bufferpanel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel7.Location = new System.Drawing.Point(328, 9);
            this.bufferpanel7.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel7.Name = "bufferpanel7";
            this.bufferpanel7.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel7.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel7.TabIndex = 0;
            this.bufferpanel7.Visible = false;
            // 
            // bufferpanel8
            // 
            this.bufferpanel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel8.Location = new System.Drawing.Point(381, 9);
            this.bufferpanel8.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel8.Name = "bufferpanel8";
            this.bufferpanel8.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel8.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel8.TabIndex = 0;
            this.bufferpanel8.Visible = false;
            // 
            // bufferpanel9
            // 
            this.bufferpanel9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel9.Location = new System.Drawing.Point(434, 9);
            this.bufferpanel9.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel9.Name = "bufferpanel9";
            this.bufferpanel9.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel9.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel9.TabIndex = 0;
            this.bufferpanel9.Visible = false;
            // 
            // bufferpanel10
            // 
            this.bufferpanel10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel10.Location = new System.Drawing.Point(487, 9);
            this.bufferpanel10.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel10.Name = "bufferpanel10";
            this.bufferpanel10.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel10.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel10.TabIndex = 0;
            this.bufferpanel10.Visible = false;
            // 
            // bufferpanel11
            // 
            this.bufferpanel11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel11.Location = new System.Drawing.Point(540, 9);
            this.bufferpanel11.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel11.Name = "bufferpanel11";
            this.bufferpanel11.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel11.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel11.TabIndex = 0;
            this.bufferpanel11.Visible = false;
            // 
            // bufferpanel12
            // 
            this.bufferpanel12.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel12.Location = new System.Drawing.Point(593, 9);
            this.bufferpanel12.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel12.Name = "bufferpanel12";
            this.bufferpanel12.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel12.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel12.TabIndex = 0;
            this.bufferpanel12.Visible = false;
            // 
            // bufferpanel13
            // 
            this.bufferpanel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel13.Location = new System.Drawing.Point(646, 9);
            this.bufferpanel13.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel13.Name = "bufferpanel13";
            this.bufferpanel13.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel13.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel13.TabIndex = 0;
            this.bufferpanel13.Visible = false;
            // 
            // bufferpanel14
            // 
            this.bufferpanel14.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bufferpanel14.Location = new System.Drawing.Point(699, 9);
            this.bufferpanel14.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bufferpanel14.Name = "bufferpanel14";
            this.bufferpanel14.Padding = new System.Windows.Forms.Padding(3);
            this.bufferpanel14.Size = new System.Drawing.Size(43, 60);
            this.bufferpanel14.TabIndex = 0;
            this.bufferpanel14.Visible = false;
            // 
            // vzupanel
            // 
            this.vzupanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vzupanel.AutoSize = true;
            this.vzupanel.BackColor = System.Drawing.Color.Transparent;
            this.vzupanel.Font = new System.Drawing.Font("Cascadia Mono", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vzupanel.ForeColor = System.Drawing.Color.Azure;
            this.vzupanel.Location = new System.Drawing.Point(46, 90);
            this.vzupanel.Name = "vzupanel";
            this.vzupanel.Size = new System.Drawing.Size(63, 35);
            this.vzupanel.TabIndex = 4;
            this.vzupanel.Text = "ВЗУ";
            // 
            // Bufferlabel
            // 
            this.Bufferlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bufferlabel.AutoSize = true;
            this.Bufferlabel.Font = new System.Drawing.Font("Cascadia Mono", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bufferlabel.ForeColor = System.Drawing.Color.Azure;
            this.Bufferlabel.Location = new System.Drawing.Point(36, 257);
            this.Bufferlabel.Name = "Bufferlabel";
            this.Bufferlabel.Size = new System.Drawing.Size(111, 35);
            this.Bufferlabel.TabIndex = 5;
            this.Bufferlabel.Text = "ЯЧЕЙКИ";
            // 
            // Emulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(967, 588);
            this.ControlBox = false;
            this.Controls.Add(this.Bufferlabel);
            this.Controls.Add(this.vzupanel);
            this.Controls.Add(this.bufferflowpanel);
            this.Controls.Add(this.vzuflowpanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Emulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emulator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.vzuflowpanel.ResumeLayout(false);
            this.bufferflowpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox BuffersAmount;
        private TextBox FileSize;
        private TextBox BufferSize;
        private Panel TopPanel;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Panel ExitPanel;
        private Panel CollapsePanel;
        private Button CheckButton;
        private Label ExceptionLabel;
        private FlowLayoutPanel vzuflowpanel;
        private Panel vzupanel1;
        private Panel vzupanel2;
        private Panel vzupanel3;
        private Panel vzupanel4;
        private Panel vzupanel5;
        private Panel vzupanel6;
        private Panel vzupanel7;
        private Panel vzupanel8;
        private Panel vzupanel9;
        private Panel vzupanel10;
        private Panel vzupanel11;
        private Panel vzupanel12;
        private Panel vzupanel13;
        private Panel vzupanel14;
        private FlowLayoutPanel bufferflowpanel;
        private Panel bufferpanel1;
        private Panel bufferpanel2;
        private Panel bufferpanel3;
        private Panel bufferpanel4;
        private Panel bufferpanel5;
        private Panel bufferpanel6;
        private Panel bufferpanel7;
        private Panel bufferpanel8;
        private Panel bufferpanel9;
        private Panel bufferpanel10;
        private Panel bufferpanel11;
        private Panel bufferpanel12;
        private Panel bufferpanel13;
        private Panel bufferpanel14;
        private Label vzupanel;
        private Label Bufferlabel;
    }
}