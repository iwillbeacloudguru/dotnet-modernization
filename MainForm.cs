using System;
using System.Windows.Forms;

namespace DotNet6App
{
    public class MainForm : Form
    {
        private Button button;
        private TextBox textBox;
        private Label label;

        public MainForm()
        {
            button = new Button();
            textBox = new TextBox();
            label = new Label();

            button.Text = "Click Me";
            button.Location = new System.Drawing.Point(100, 50);
            button.Click += new EventHandler(Button_Click);

            textBox.Location = new System.Drawing.Point(100, 100);
            textBox.Width = 200;

            label.Location = new System.Drawing.Point(100, 150);
            label.Width = 200;

            Controls.Add(button);
            Controls.Add(textBox);
            Controls.Add(label);

            Text = "DotNet 6 Application";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            label.Text = "Hello, " + textBox.Text + "!";
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}