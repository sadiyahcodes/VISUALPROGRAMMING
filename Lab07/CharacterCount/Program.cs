using System;
using System.Windows.Forms;

namespace CharacterLimitApp
{
    public class CharacterLimitForm : Form
    {
        private TextBox textBox;
        private Label lblCharactersLeft;
        private const int MaxCharacters = 160;

        public CharacterLimitForm()
        {
            // Initialize components
            textBox = new TextBox();
            lblCharactersLeft = new Label();

            // Form settings
            this.Text = "Character Limit";
            this.Size = new System.Drawing.Size(400, 200);

            // TextBox settings
            textBox.Multiline = true;
            textBox.Location = new System.Drawing.Point(20, 20);
            textBox.Size = new System.Drawing.Size(340, 80);
            textBox.MaxLength = MaxCharacters;
            textBox.TextChanged += new EventHandler(TextBox_TextChanged);
            this.Controls.Add(textBox);

            // Characters Left Label
            lblCharactersLeft.Text = $"Characters Left: {MaxCharacters}";
            lblCharactersLeft.Location = new System.Drawing.Point(20, 120);
            lblCharactersLeft.AutoSize = true;
            this.Controls.Add(lblCharactersLeft);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            int charactersLeft = MaxCharacters - textBox.Text.Length;
            lblCharactersLeft.Text = $"Characters Left: {charactersLeft}";
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CharacterLimitForm());
        }
    }
}
