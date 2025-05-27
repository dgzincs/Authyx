
using System.Xml;

namespace Projeto_PROGVIII
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginBtn = new MaterialSkin.Controls.MaterialButton();
            RegisterBtn = new MaterialSkin.Controls.MaterialButton();
            LoginEmailInput = new MaterialSkin.Controls.MaterialTextBox2();
            LoginPasswordInput = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            LoginBtn.Depth = 0;
            LoginBtn.HighEmphasis = true;
            LoginBtn.Icon = null;
            LoginBtn.Location = new Point(176, 332);
            LoginBtn.Margin = new Padding(4, 6, 4, 6);
            LoginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            LoginBtn.Name = "LoginBtn";
            LoginBtn.NoAccentTextColor = Color.Empty;
            LoginBtn.Size = new Size(77, 36);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Entrar";
            LoginBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            LoginBtn.UseAccentColor = false;
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += materialButton1_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RegisterBtn.BackColor = SystemColors.ActiveBorder;
            RegisterBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            RegisterBtn.Depth = 0;
            RegisterBtn.HighEmphasis = true;
            RegisterBtn.Icon = null;
            RegisterBtn.Location = new Point(304, 332);
            RegisterBtn.Margin = new Padding(4, 6, 4, 6);
            RegisterBtn.MouseState = MaterialSkin.MouseState.HOVER;
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.NoAccentTextColor = Color.Empty;
            RegisterBtn.Size = new Size(120, 36);
            RegisterBtn.TabIndex = 1;
            RegisterBtn.Text = "Registrar-se";
            RegisterBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            RegisterBtn.UseAccentColor = false;
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += materialButton2_Click;
            // 
            // LoginEmailInput
            // 
            LoginEmailInput.AnimateReadOnly = false;
            LoginEmailInput.BackgroundImageLayout = ImageLayout.None;
            LoginEmailInput.CharacterCasing = CharacterCasing.Normal;
            LoginEmailInput.Depth = 0;
            LoginEmailInput.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LoginEmailInput.HideSelection = true;
            LoginEmailInput.LeadingIcon = null;
            LoginEmailInput.Location = new Point(176, 142);
            LoginEmailInput.MaxLength = 32767;
            LoginEmailInput.MouseState = MaterialSkin.MouseState.OUT;
            LoginEmailInput.Name = "LoginEmailInput";
            LoginEmailInput.PasswordChar = '\0';
            LoginEmailInput.PrefixSuffixText = null;
            LoginEmailInput.ReadOnly = false;
            LoginEmailInput.RightToLeft = RightToLeft.No;
            LoginEmailInput.SelectedText = "";
            LoginEmailInput.SelectionLength = 0;
            LoginEmailInput.SelectionStart = 0;
            LoginEmailInput.ShortcutsEnabled = true;
            LoginEmailInput.Size = new Size(248, 48);
            LoginEmailInput.TabIndex = 2;
            LoginEmailInput.TabStop = false;
            LoginEmailInput.TextAlign = HorizontalAlignment.Left;
            LoginEmailInput.TrailingIcon = null;
            LoginEmailInput.UseSystemPasswordChar = false;
            LoginEmailInput.Click += materialTextBox21_Click;
            // 
            // LoginPasswordInput
            // 
            LoginPasswordInput.AnimateReadOnly = false;
            LoginPasswordInput.BackgroundImageLayout = ImageLayout.None;
            LoginPasswordInput.CharacterCasing = CharacterCasing.Normal;
            LoginPasswordInput.Depth = 0;
            LoginPasswordInput.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LoginPasswordInput.HideSelection = true;
            LoginPasswordInput.LeadingIcon = null;
            LoginPasswordInput.Location = new Point(176, 216);
            LoginPasswordInput.MaxLength = 32767;
            LoginPasswordInput.MouseState = MaterialSkin.MouseState.OUT;
            LoginPasswordInput.Name = "LoginPasswordInput";
            LoginPasswordInput.PasswordChar = '\0';
            LoginPasswordInput.PrefixSuffixText = null;
            LoginPasswordInput.ReadOnly = false;
            LoginPasswordInput.RightToLeft = RightToLeft.No;
            LoginPasswordInput.SelectedText = "";
            LoginPasswordInput.SelectionLength = 0;
            LoginPasswordInput.SelectionStart = 0;
            LoginPasswordInput.ShortcutsEnabled = true;
            LoginPasswordInput.Size = new Size(248, 48);
            LoginPasswordInput.TabIndex = 3;
            LoginPasswordInput.TabStop = false;
            LoginPasswordInput.TextAlign = HorizontalAlignment.Left;
            LoginPasswordInput.TrailingIcon = null;
            LoginPasswordInput.UseSystemPasswordChar = false;
            LoginPasswordInput.Click += LoginPasswordInput_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(176, 120);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(41, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Email";
            materialLabel1.Click += materialLabel1_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(176, 193);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(46, 19);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Senha";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(LoginPasswordInput);
            Controls.Add(LoginEmailInput);
            Controls.Add(RegisterBtn);
            Controls.Add(LoginBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrar";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string email = LoginEmailInput.Text;
            string password = LoginPasswordInput.Text;

            Cliente newClienteInstance = new Cliente();
            newClienteInstance.email = email;
            newClienteInstance.password = password;
            newClienteInstance.AcessarCliente();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton LoginBtn;
        private MaterialSkin.Controls.MaterialButton RegisterBtn;
        private MaterialSkin.Controls.MaterialTextBox2 LoginEmailInput;
        private MaterialSkin.Controls.MaterialTextBox2 LoginPasswordInput;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
