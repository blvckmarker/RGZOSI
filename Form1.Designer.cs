
namespace Clipboard
{
    partial class Emultor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emultor));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonBufferToProgr = new System.Windows.Forms.Button();
			this.buttonVzuToBuffer = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.BufferNums = new System.Windows.Forms.Label();
			this.BufferSize = new System.Windows.Forms.Label();
			this.FileSize = new System.Windows.Forms.Label();
			this.textBoxBufferNums = new System.Windows.Forms.TextBox();
			this.textBoxBufferSize = new System.Windows.Forms.TextBox();
			this.textBoxFileSize = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.VZU = new System.Windows.Forms.Label();
			this.Buffer = new System.Windows.Forms.Label();
			this.Ris1 = new System.Windows.Forms.Panel();
			this.Ris2 = new System.Windows.Forms.Panel();
			this.Ris3 = new System.Windows.Forms.Panel();
			this.Ris4 = new System.Windows.Forms.Panel();
			this.Ris5 = new System.Windows.Forms.Panel();
			this.Ris6 = new System.Windows.Forms.Panel();
			this.Ris7 = new System.Windows.Forms.Panel();
			this.Ris8 = new System.Windows.Forms.Panel();
			this.Ris9 = new System.Windows.Forms.Panel();
			this.Ris10 = new System.Windows.Forms.Panel();
			this.Ris11 = new System.Windows.Forms.Panel();
			this.Ris12 = new System.Windows.Forms.Panel();
			this.Ris13 = new System.Windows.Forms.Panel();
			this.Ris14 = new System.Windows.Forms.Panel();
			this.Ris1_14 = new System.Windows.Forms.Panel();
			this.Ris1_13 = new System.Windows.Forms.Panel();
			this.Ris1_12 = new System.Windows.Forms.Panel();
			this.Ris1_11 = new System.Windows.Forms.Panel();
			this.Ris1_10 = new System.Windows.Forms.Panel();
			this.Ris1_9 = new System.Windows.Forms.Panel();
			this.Ris1_8 = new System.Windows.Forms.Panel();
			this.Ris1_7 = new System.Windows.Forms.Panel();
			this.Ris1_6 = new System.Windows.Forms.Panel();
			this.Ris1_5 = new System.Windows.Forms.Panel();
			this.Ris1_4 = new System.Windows.Forms.Panel();
			this.Ris1_3 = new System.Windows.Forms.Panel();
			this.Ris1_2 = new System.Windows.Forms.Panel();
			this.Ris1_1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.panelka2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGreen;
			this.panel1.Controls.Add(this.buttonBufferToProgr);
			this.panel1.Controls.Add(this.buttonVzuToBuffer);
			this.panel1.Location = new System.Drawing.Point(440, 245);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(191, 121);
			this.panel1.TabIndex = 2;
			// 
			// buttonBufferToProgr
			// 
			this.buttonBufferToProgr.BackColor = System.Drawing.Color.Gray;
			this.buttonBufferToProgr.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonBufferToProgr.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonBufferToProgr.Location = new System.Drawing.Point(17, 72);
			this.buttonBufferToProgr.Margin = new System.Windows.Forms.Padding(2);
			this.buttonBufferToProgr.Name = "buttonBufferToProgr";
			this.buttonBufferToProgr.Size = new System.Drawing.Size(162, 41);
			this.buttonBufferToProgr.TabIndex = 2;
			this.buttonBufferToProgr.Text = "Буфер=>Программа";
			this.buttonBufferToProgr.UseVisualStyleBackColor = false;
			this.buttonBufferToProgr.Click += new System.EventHandler(this.BufferToProgr_Click);
			// 
			// buttonVzuToBuffer
			// 
			this.buttonVzuToBuffer.BackColor = System.Drawing.Color.Gray;
			this.buttonVzuToBuffer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonVzuToBuffer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonVzuToBuffer.Location = new System.Drawing.Point(17, 15);
			this.buttonVzuToBuffer.Margin = new System.Windows.Forms.Padding(2);
			this.buttonVzuToBuffer.Name = "buttonVzuToBuffer";
			this.buttonVzuToBuffer.Size = new System.Drawing.Size(162, 41);
			this.buttonVzuToBuffer.TabIndex = 1;
			this.buttonVzuToBuffer.Text = "ВЗУ=>Буфер";
			this.buttonVzuToBuffer.UseVisualStyleBackColor = false;
			this.buttonVzuToBuffer.Click += new System.EventHandler(this.VzuToBuffer_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.panel3.Controls.Add(this.BufferNums);
			this.panel3.Controls.Add(this.BufferSize);
			this.panel3.Controls.Add(this.FileSize);
			this.panel3.Controls.Add(this.textBoxBufferNums);
			this.panel3.Controls.Add(this.textBoxBufferSize);
			this.panel3.Controls.Add(this.textBoxFileSize);
			this.panel3.Location = new System.Drawing.Point(1, 245);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(442, 121);
			this.panel3.TabIndex = 4;
			// 
			// BufferNums
			// 
			this.BufferNums.AutoSize = true;
			this.BufferNums.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BufferNums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.BufferNums.Location = new System.Drawing.Point(270, 24);
			this.BufferNums.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.BufferNums.Name = "BufferNums";
			this.BufferNums.Size = new System.Drawing.Size(168, 23);
			this.BufferNums.TabIndex = 11;
			this.BufferNums.Text = "Количество буферов";
			// 
			// BufferSize
			// 
			this.BufferSize.AutoSize = true;
			this.BufferSize.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BufferSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.BufferSize.Location = new System.Drawing.Point(144, 24);
			this.BufferSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.BufferSize.Name = "BufferSize";
			this.BufferSize.Size = new System.Drawing.Size(122, 23);
			this.BufferSize.TabIndex = 10;
			this.BufferSize.Text = "Размер буфера";
			// 
			// FileSize
			// 
			this.FileSize.AutoSize = true;
			this.FileSize.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.FileSize.Location = new System.Drawing.Point(15, 24);
			this.FileSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.FileSize.Name = "FileSize";
			this.FileSize.Size = new System.Drawing.Size(116, 23);
			this.FileSize.TabIndex = 9;
			this.FileSize.Text = "Размер файла";
			// 
			// textBoxBufferNums
			// 
			this.textBoxBufferNums.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxBufferNums.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.textBoxBufferNums.Location = new System.Drawing.Point(315, 50);
			this.textBoxBufferNums.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxBufferNums.Multiline = true;
			this.textBoxBufferNums.Name = "textBoxBufferNums";
			this.textBoxBufferNums.Size = new System.Drawing.Size(78, 31);
			this.textBoxBufferNums.TabIndex = 8;
			this.textBoxBufferNums.TextChanged += new System.EventHandler(this.textBoxBufferNums_TextChanged);
			// 
			// textBoxBufferSize
			// 
			this.textBoxBufferSize.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxBufferSize.Location = new System.Drawing.Point(169, 50);
			this.textBoxBufferSize.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxBufferSize.Multiline = true;
			this.textBoxBufferSize.Name = "textBoxBufferSize";
			this.textBoxBufferSize.Size = new System.Drawing.Size(78, 31);
			this.textBoxBufferSize.TabIndex = 7;
			this.textBoxBufferSize.TextChanged += new System.EventHandler(this.textBoxBufferSize_TextChanged);
			// 
			// textBoxFileSize
			// 
			this.textBoxFileSize.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxFileSize.Location = new System.Drawing.Point(31, 50);
			this.textBoxFileSize.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxFileSize.Multiline = true;
			this.textBoxFileSize.Name = "textBoxFileSize";
			this.textBoxFileSize.Size = new System.Drawing.Size(78, 31);
			this.textBoxFileSize.TabIndex = 6;
			this.textBoxFileSize.TextChanged += new System.EventHandler(this.textBoxFileSize_TextChanged);
			// 
			// VZU
			// 
			this.VZU.AutoSize = true;
			this.VZU.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.VZU.Location = new System.Drawing.Point(15, 37);
			this.VZU.Name = "VZU";
			this.VZU.Size = new System.Drawing.Size(47, 26);
			this.VZU.TabIndex = 5;
			this.VZU.Text = "ВЗУ";
			// 
			// Buffer
			// 
			this.Buffer.AutoSize = true;
			this.Buffer.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Buffer.Location = new System.Drawing.Point(3, 117);
			this.Buffer.Name = "Buffer";
			this.Buffer.Size = new System.Drawing.Size(68, 26);
			this.Buffer.TabIndex = 6;
			this.Buffer.Text = "Буфер";
			// 
			// Ris1
			// 
			this.Ris1.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris1.Location = new System.Drawing.Point(78, 21);
			this.Ris1.Name = "Ris1";
			this.Ris1.Size = new System.Drawing.Size(31, 62);
			this.Ris1.TabIndex = 7;
			this.Ris1.Visible = false;
			// 
			// Ris2
			// 
			this.Ris2.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris2.Location = new System.Drawing.Point(115, 21);
			this.Ris2.Name = "Ris2";
			this.Ris2.Size = new System.Drawing.Size(31, 62);
			this.Ris2.TabIndex = 8;
			this.Ris2.Visible = false;
			// 
			// Ris3
			// 
			this.Ris3.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris3.Location = new System.Drawing.Point(152, 21);
			this.Ris3.Name = "Ris3";
			this.Ris3.Size = new System.Drawing.Size(31, 62);
			this.Ris3.TabIndex = 9;
			this.Ris3.Visible = false;
			// 
			// Ris4
			// 
			this.Ris4.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris4.Location = new System.Drawing.Point(189, 21);
			this.Ris4.Name = "Ris4";
			this.Ris4.Size = new System.Drawing.Size(31, 62);
			this.Ris4.TabIndex = 10;
			this.Ris4.Visible = false;
			// 
			// Ris5
			// 
			this.Ris5.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris5.Location = new System.Drawing.Point(226, 21);
			this.Ris5.Name = "Ris5";
			this.Ris5.Size = new System.Drawing.Size(31, 62);
			this.Ris5.TabIndex = 11;
			this.Ris5.Visible = false;
			// 
			// Ris6
			// 
			this.Ris6.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris6.Location = new System.Drawing.Point(263, 21);
			this.Ris6.Name = "Ris6";
			this.Ris6.Size = new System.Drawing.Size(31, 62);
			this.Ris6.TabIndex = 12;
			this.Ris6.Visible = false;
			// 
			// Ris7
			// 
			this.Ris7.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris7.Location = new System.Drawing.Point(300, 21);
			this.Ris7.Name = "Ris7";
			this.Ris7.Size = new System.Drawing.Size(31, 62);
			this.Ris7.TabIndex = 13;
			this.Ris7.Visible = false;
			// 
			// Ris8
			// 
			this.Ris8.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris8.Location = new System.Drawing.Point(337, 21);
			this.Ris8.Name = "Ris8";
			this.Ris8.Size = new System.Drawing.Size(31, 62);
			this.Ris8.TabIndex = 14;
			this.Ris8.Visible = false;
			// 
			// Ris9
			// 
			this.Ris9.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris9.Location = new System.Drawing.Point(374, 21);
			this.Ris9.Name = "Ris9";
			this.Ris9.Size = new System.Drawing.Size(31, 62);
			this.Ris9.TabIndex = 15;
			this.Ris9.Visible = false;
			// 
			// Ris10
			// 
			this.Ris10.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris10.Location = new System.Drawing.Point(411, 21);
			this.Ris10.Name = "Ris10";
			this.Ris10.Size = new System.Drawing.Size(31, 62);
			this.Ris10.TabIndex = 16;
			this.Ris10.Visible = false;
			// 
			// Ris11
			// 
			this.Ris11.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris11.Location = new System.Drawing.Point(448, 21);
			this.Ris11.Name = "Ris11";
			this.Ris11.Size = new System.Drawing.Size(31, 62);
			this.Ris11.TabIndex = 17;
			this.Ris11.Visible = false;
			// 
			// Ris12
			// 
			this.Ris12.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris12.Location = new System.Drawing.Point(485, 21);
			this.Ris12.Name = "Ris12";
			this.Ris12.Size = new System.Drawing.Size(31, 62);
			this.Ris12.TabIndex = 18;
			this.Ris12.Visible = false;
			// 
			// Ris13
			// 
			this.Ris13.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris13.Location = new System.Drawing.Point(522, 21);
			this.Ris13.Name = "Ris13";
			this.Ris13.Size = new System.Drawing.Size(31, 62);
			this.Ris13.TabIndex = 19;
			this.Ris13.Visible = false;
			// 
			// Ris14
			// 
			this.Ris14.BackColor = System.Drawing.SystemColors.Desktop;
			this.Ris14.Location = new System.Drawing.Point(559, 21);
			this.Ris14.Name = "Ris14";
			this.Ris14.Size = new System.Drawing.Size(31, 62);
			this.Ris14.TabIndex = 20;
			this.Ris14.Visible = false;
			// 
			// Ris1_14
			// 
			this.Ris1_14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_14.Location = new System.Drawing.Point(559, 100);
			this.Ris1_14.Name = "Ris1_14";
			this.Ris1_14.Size = new System.Drawing.Size(31, 62);
			this.Ris1_14.TabIndex = 34;
			this.Ris1_14.Visible = false;
			// 
			// Ris1_13
			// 
			this.Ris1_13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_13.Location = new System.Drawing.Point(522, 100);
			this.Ris1_13.Name = "Ris1_13";
			this.Ris1_13.Size = new System.Drawing.Size(31, 62);
			this.Ris1_13.TabIndex = 33;
			this.Ris1_13.Visible = false;
			// 
			// Ris1_12
			// 
			this.Ris1_12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_12.Location = new System.Drawing.Point(485, 100);
			this.Ris1_12.Name = "Ris1_12";
			this.Ris1_12.Size = new System.Drawing.Size(31, 62);
			this.Ris1_12.TabIndex = 32;
			this.Ris1_12.Visible = false;
			// 
			// Ris1_11
			// 
			this.Ris1_11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_11.Location = new System.Drawing.Point(448, 100);
			this.Ris1_11.Name = "Ris1_11";
			this.Ris1_11.Size = new System.Drawing.Size(31, 62);
			this.Ris1_11.TabIndex = 31;
			this.Ris1_11.Visible = false;
			// 
			// Ris1_10
			// 
			this.Ris1_10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_10.Location = new System.Drawing.Point(411, 100);
			this.Ris1_10.Name = "Ris1_10";
			this.Ris1_10.Size = new System.Drawing.Size(31, 62);
			this.Ris1_10.TabIndex = 30;
			this.Ris1_10.Visible = false;
			// 
			// Ris1_9
			// 
			this.Ris1_9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_9.Location = new System.Drawing.Point(374, 100);
			this.Ris1_9.Name = "Ris1_9";
			this.Ris1_9.Size = new System.Drawing.Size(31, 62);
			this.Ris1_9.TabIndex = 29;
			this.Ris1_9.Visible = false;
			// 
			// Ris1_8
			// 
			this.Ris1_8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_8.Location = new System.Drawing.Point(337, 100);
			this.Ris1_8.Name = "Ris1_8";
			this.Ris1_8.Size = new System.Drawing.Size(31, 62);
			this.Ris1_8.TabIndex = 28;
			this.Ris1_8.Visible = false;
			// 
			// Ris1_7
			// 
			this.Ris1_7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_7.Location = new System.Drawing.Point(300, 100);
			this.Ris1_7.Name = "Ris1_7";
			this.Ris1_7.Size = new System.Drawing.Size(31, 62);
			this.Ris1_7.TabIndex = 27;
			this.Ris1_7.Visible = false;
			// 
			// Ris1_6
			// 
			this.Ris1_6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_6.Location = new System.Drawing.Point(263, 100);
			this.Ris1_6.Name = "Ris1_6";
			this.Ris1_6.Size = new System.Drawing.Size(31, 62);
			this.Ris1_6.TabIndex = 26;
			this.Ris1_6.Visible = false;
			this.Ris1_6.Paint += new System.Windows.Forms.PaintEventHandler(this.Ris1_6_Paint);
			// 
			// Ris1_5
			// 
			this.Ris1_5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_5.Location = new System.Drawing.Point(226, 100);
			this.Ris1_5.Name = "Ris1_5";
			this.Ris1_5.Size = new System.Drawing.Size(31, 62);
			this.Ris1_5.TabIndex = 25;
			this.Ris1_5.Visible = false;
			// 
			// Ris1_4
			// 
			this.Ris1_4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_4.Location = new System.Drawing.Point(189, 100);
			this.Ris1_4.Name = "Ris1_4";
			this.Ris1_4.Size = new System.Drawing.Size(31, 62);
			this.Ris1_4.TabIndex = 24;
			this.Ris1_4.Visible = false;
			// 
			// Ris1_3
			// 
			this.Ris1_3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_3.Location = new System.Drawing.Point(152, 100);
			this.Ris1_3.Name = "Ris1_3";
			this.Ris1_3.Size = new System.Drawing.Size(31, 62);
			this.Ris1_3.TabIndex = 23;
			this.Ris1_3.Visible = false;
			// 
			// Ris1_2
			// 
			this.Ris1_2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_2.Location = new System.Drawing.Point(115, 100);
			this.Ris1_2.Name = "Ris1_2";
			this.Ris1_2.Size = new System.Drawing.Size(31, 62);
			this.Ris1_2.TabIndex = 22;
			this.Ris1_2.Visible = false;
			// 
			// Ris1_1
			// 
			this.Ris1_1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.Ris1_1.Location = new System.Drawing.Point(78, 100);
			this.Ris1_1.Name = "Ris1_1";
			this.Ris1_1.Size = new System.Drawing.Size(31, 62);
			this.Ris1_1.TabIndex = 21;
			this.Ris1_1.Visible = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(0, 196);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(646, 49);
			this.panel2.TabIndex = 35;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(237, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Программа";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// panelka2
			// 
			this.panelka2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panelka2.Location = new System.Drawing.Point(78, 162);
			this.panelka2.Name = "panelka2";
			this.panelka2.Size = new System.Drawing.Size(31, 4);
			this.panelka2.TabIndex = 36;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel5.Location = new System.Drawing.Point(78, 96);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(31, 4);
			this.panel5.TabIndex = 37;
			// 
			// Emultor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 429);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panelka2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.Ris1_14);
			this.Controls.Add(this.Ris1_13);
			this.Controls.Add(this.Ris1_12);
			this.Controls.Add(this.Ris1_11);
			this.Controls.Add(this.Ris1_10);
			this.Controls.Add(this.Ris1_9);
			this.Controls.Add(this.Ris1_8);
			this.Controls.Add(this.Ris1_7);
			this.Controls.Add(this.Ris1_6);
			this.Controls.Add(this.Ris1_5);
			this.Controls.Add(this.Ris1_4);
			this.Controls.Add(this.Ris1_3);
			this.Controls.Add(this.Ris1_2);
			this.Controls.Add(this.Ris1_1);
			this.Controls.Add(this.Ris14);
			this.Controls.Add(this.Ris13);
			this.Controls.Add(this.Ris12);
			this.Controls.Add(this.Ris11);
			this.Controls.Add(this.Ris10);
			this.Controls.Add(this.Ris9);
			this.Controls.Add(this.Ris8);
			this.Controls.Add(this.Ris7);
			this.Controls.Add(this.Ris6);
			this.Controls.Add(this.Ris5);
			this.Controls.Add(this.Ris4);
			this.Controls.Add(this.Ris3);
			this.Controls.Add(this.Ris2);
			this.Controls.Add(this.Ris1);
			this.Controls.Add(this.Buffer);
			this.Controls.Add(this.VZU);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Emultor";
			this.Text = "Эмулятор системы управления буферами";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label BufferNums;
        private System.Windows.Forms.Label BufferSize;
        private System.Windows.Forms.Label FileSize;
        private System.Windows.Forms.TextBox textBoxBufferNums;
        private System.Windows.Forms.TextBox textBoxBufferSize;
        private System.Windows.Forms.TextBox textBoxFileSize;
        private System.Windows.Forms.Button buttonVzuToBuffer;
        private System.Windows.Forms.Button buttonBufferToProgr;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label VZU;
        private System.Windows.Forms.Label Buffer;
		private System.Windows.Forms.Panel Ris1;
		private System.Windows.Forms.Panel Ris2;
		private System.Windows.Forms.Panel Ris3;
		private System.Windows.Forms.Panel Ris4;
		private System.Windows.Forms.Panel Ris5;
		private System.Windows.Forms.Panel Ris6;
		private System.Windows.Forms.Panel Ris7;
		private System.Windows.Forms.Panel Ris8;
		private System.Windows.Forms.Panel Ris9;
		private System.Windows.Forms.Panel Ris10;
		private System.Windows.Forms.Panel Ris11;
		private System.Windows.Forms.Panel Ris12;
		private System.Windows.Forms.Panel Ris13;
		private System.Windows.Forms.Panel Ris14;
		private System.Windows.Forms.Panel Ris1_14;
		private System.Windows.Forms.Panel Ris1_13;
		private System.Windows.Forms.Panel Ris1_12;
		private System.Windows.Forms.Panel Ris1_11;
		private System.Windows.Forms.Panel Ris1_10;
		private System.Windows.Forms.Panel Ris1_9;
		private System.Windows.Forms.Panel Ris1_8;
		private System.Windows.Forms.Panel Ris1_7;
		private System.Windows.Forms.Panel Ris1_6;
		private System.Windows.Forms.Panel Ris1_5;
		private System.Windows.Forms.Panel Ris1_4;
		private System.Windows.Forms.Panel Ris1_3;
		private System.Windows.Forms.Panel Ris1_2;
		private System.Windows.Forms.Panel Ris1_1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.Panel panelka2;
		private System.Windows.Forms.Panel panel5;
	}
}

