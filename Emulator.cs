namespace WinRGZOSI
{
    public partial class Emulator : Form
    {
        // создаем обьект модели, чтобы инициализировать свойства естественно
        Model model;
        public Emulator()
        {
            model = new Model().Init();
            InitializeComponent();
        }

        // это всякий мусор в виде ховер эффектов, кнопок и тд
        private void ExitHover(object sender, EventArgs e) => this.ExitPanel.BackColor = System.Drawing.Color.Tomato;
        private void ExitHoverLeave(object sender, EventArgs e) => this.ExitPanel.BackColor = System.Drawing.Color.LightCoral;
        private void ExitClick(object sender, EventArgs e) => Application.Exit();
        private void CollapsePanel_Hover(object sender, EventArgs e) => this.CollapsePanel.BackColor = System.Drawing.Color.Gray;
        private void CollapsePanel_Leave(object sender, EventArgs e) => this.CollapsePanel.BackColor = System.Drawing.Color.DarkGray;
        private void CollapsePanel_MouseClick(object sender, MouseEventArgs e) => this.WindowState = FormWindowState.Minimized;



        private void CheckButtonClicked(object sender, EventArgs e)
        {
            if (Check())
            {
                ExceptionLabel.Visible = false;
                model.BufferAmount = (Convert.ToInt16(BuffersAmount.Text) <= model.MaxSize) ?
                    Convert.ToInt16(BuffersAmount.Text) : model.MaxSize;
                model.BufferSize = Convert.ToInt16(this.BufferSize.Text);
                model.FileSize = Convert.ToInt16(this.FileSize.Text);
                Update();
            }
            else
                ExceptionLabel.Visible = true;
        }

        // Это чудо-юдо кидает эксепшн, если происходит полный хаос при конвертации в целчисл
        private bool isConverted(TextBox textBox)
        {
            try
            {
                var typed = Convert.ToBoolean(Convert.ToInt16(textBox.Text));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        // если все входные параметры валидны(цеслчисл и не пустые), то тру
        private bool Check()
        {
            if (BuffersAmount.Text.Length != 0 && BufferSize.Text.Length != 0 && FileSize.Text.Length != 0 &&
                    isConverted(BuffersAmount) && isConverted(BufferSize) && isConverted(FileSize))
                return true;
            else
                return false;
        }

        // обновляет панельки 
        private void Update()
        {
            // здесь крч апкаст всех панелек к *flowpanel.Controls. 
            foreach (Panel Panel in bufferflowpanel.Controls)
                Panel.Hide();
            foreach (Panel Panel in vzuflowpanel.Controls)
                Panel.Hide();

            // скрыли старые - обновили новые
            for (int i = 0; i != model.CountOfVZU; ++i)
                vzuflowpanel.Controls[i].Visible = true;
            for (int i = 0; i != model.BufferAmount; ++i)
                bufferflowpanel.Controls[i].Visible = true;
        }
    }
}