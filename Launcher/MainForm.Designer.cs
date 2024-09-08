using Sunny.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Launcher
{
    public partial class MainForm : global::System.Windows.Forms.Form
    {

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            MainTab = new UITabControl();
            AccountLoginTab = new TabPage();
            AccountAvatar = new UIAvatar();
            LoginAccountLabel = new UISymbolButton();
            ForgotPasswordLabel = new UILinkLabel();
            AccountPasswordTextBox = new UITextBox();
            RegisterAccountLabel = new UISymbolButton();
            login_error_label = new UILabel();
            AccountTextBox = new UITextBox();
            RegistrationTab = new TabPage();
            Register_Back_To_LoginBtn = new UISymbolButton();
            RegistrationErrorLabel = new UILabel();
            Register_AccountBtn = new UISymbolButton();
            Register_SecretAnswerTextBox = new UITextBox();
            Register_PasswordTextBox = new UITextBox();
            Register_QuestionTextBox = new UITextBox();
            Register_AccountNameTextBox = new UITextBox();
            ChangePasswordTab = new TabPage();
            Modify_Back_To_LoginBtn = new UISymbolButton();
            Modify_ErrorLabel = new UILabel();
            Modify_PasswordBtn = new UISymbolButton();
            Modify_AnswerTextBox = new UITextBox();
            Modify_PasswordTextBox = new UITextBox();
            Modify_QuestionTextBox = new UITextBox();
            Modify_AccountNameTextBox = new UITextBox();
            StartGameTab = new TabPage();
            uiCheckBox2 = new UICheckBox();
            uiCheckBox1 = new UICheckBox();
            StartTheCurrentServerLabel = new Label();
            activate_account = new UISymbolButton();
            start_selected_zone = new UILinkLabel();
            GameServerList = new ListBox();
            Launcher_enterGameBtn = new UIButton();
            InterfaceUpdateTimer = new Timer(components);
            DataProcessTimer = new Timer(components);
            minimizeToTray = new NotifyIcon(components);
            TrayRightClickMenu = new ContextMenuStrip(components);
            OpenToolStripMenuItem = new ToolStripMenuItem();
            QuitToolStripMenuItem = new ToolStripMenuItem();
            GameProcessTimer = new Timer(components);
            MainTab.SuspendLayout();
            AccountLoginTab.SuspendLayout();
            RegistrationTab.SuspendLayout();
            ChangePasswordTab.SuspendLayout();
            StartGameTab.SuspendLayout();
            TrayRightClickMenu.SuspendLayout();
            SuspendLayout();
            // 
            // MainTab
            // 
            MainTab.Controls.Add(AccountLoginTab);
            MainTab.Controls.Add(RegistrationTab);
            MainTab.Controls.Add(ChangePasswordTab);
            MainTab.Controls.Add(StartGameTab);
            MainTab.DrawMode = TabDrawMode.OwnerDrawFixed;
            MainTab.FillColor = Color.FromArgb(255, 244, 240);
            MainTab.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainTab.ItemSize = new Size(260, 28);
            MainTab.Location = new Point(376, 0);
            MainTab.MainPage = "";
            MainTab.Margin = new Padding(3, 2, 3, 2);
            MainTab.MenuStyle = UIMenuStyle.Custom;
            MainTab.Name = "MainTab";
            MainTab.Padding = new Point(0, 0);
            MainTab.SelectedIndex = 0;
            MainTab.Size = new Size(331, 363);
            MainTab.SizeMode = TabSizeMode.Fixed;
            MainTab.Style = UIStyle.LayuiRed;
            MainTab.StyleCustomMode = true;
            MainTab.TabIndex = 9;
            MainTab.TabSelectedColor = Color.FromArgb(56, 56, 56);
            MainTab.TabSelectedForeColor = Color.FromArgb(255, 87, 34);
            MainTab.TabSelectedHighColor = Color.FromArgb(255, 87, 34);
            MainTab.TabSelectedHighColorSize = 0;
            MainTab.TabStop = false;
            MainTab.TabUnSelectedForeColor = Color.FromArgb(255, 87, 34);
            MainTab.TipsFont = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainTab.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // AccountLoginTab
            // 
            AccountLoginTab.BackColor = Color.FromArgb(255, 244, 240);
            AccountLoginTab.BorderStyle = BorderStyle.FixedSingle;
            AccountLoginTab.Controls.Add(AccountAvatar);
            AccountLoginTab.Controls.Add(LoginAccountLabel);
            AccountLoginTab.Controls.Add(ForgotPasswordLabel);
            AccountLoginTab.Controls.Add(AccountPasswordTextBox);
            AccountLoginTab.Controls.Add(RegisterAccountLabel);
            AccountLoginTab.Controls.Add(login_error_label);
            AccountLoginTab.Controls.Add(AccountTextBox);
            AccountLoginTab.Location = new Point(0, 28);
            AccountLoginTab.Margin = new Padding(3, 2, 3, 2);
            AccountLoginTab.Name = "AccountLoginTab";
            AccountLoginTab.Size = new Size(331, 335);
            AccountLoginTab.TabIndex = 0;
            AccountLoginTab.Text = "账号登录";
            AccountLoginTab.Click += AccountLoginTab_Click;
            // 
            // AccountAvatar
            // 
            AccountAvatar.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AccountAvatar.ForeColor = Color.FromArgb(230, 80, 80);
            AccountAvatar.Location = new Point(104, 13);
            AccountAvatar.Margin = new Padding(3, 2, 3, 2);
            AccountAvatar.MinimumSize = new Size(1, 1);
            AccountAvatar.Name = "AccountAvatar";
            AccountAvatar.Size = new Size(45, 45);
            AccountAvatar.Style = UIStyle.Custom;
            AccountAvatar.TabIndex = 17;
            AccountAvatar.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // LoginAccountLabel
            // 
            LoginAccountLabel.Cursor = Cursors.Hand;
            LoginAccountLabel.FillColor = Color.FromArgb(230, 80, 80);
            LoginAccountLabel.FillColor2 = Color.FromArgb(230, 80, 80);
            LoginAccountLabel.FillHoverColor = Color.FromArgb(235, 115, 115);
            LoginAccountLabel.FillPressColor = Color.FromArgb(184, 64, 64);
            LoginAccountLabel.FillSelectedColor = Color.FromArgb(184, 64, 64);
            LoginAccountLabel.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginAccountLabel.Location = new Point(21, 212);
            LoginAccountLabel.Margin = new Padding(3, 2, 3, 2);
            LoginAccountLabel.MinimumSize = new Size(1, 1);
            LoginAccountLabel.Name = "LoginAccountLabel";
            LoginAccountLabel.RectColor = Color.FromArgb(230, 80, 80);
            LoginAccountLabel.RectHoverColor = Color.FromArgb(235, 115, 115);
            LoginAccountLabel.RectPressColor = Color.FromArgb(184, 64, 64);
            LoginAccountLabel.RectSelectedColor = Color.FromArgb(184, 64, 64);
            LoginAccountLabel.Size = new Size(217, 29);
            LoginAccountLabel.Style = UIStyle.Red;
            LoginAccountLabel.TabIndex = 2;
            LoginAccountLabel.TabStop = false;
            LoginAccountLabel.Text = "登录";
            LoginAccountLabel.TipsFont = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LoginAccountLabel.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            LoginAccountLabel.Click += LoginAccountLabel_Click;
            // 
            // ForgotPasswordLabel
            // 
            ForgotPasswordLabel.ActiveLinkColor = Color.FromArgb(220, 155, 40);
            ForgotPasswordLabel.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForgotPasswordLabel.LinkBehavior = LinkBehavior.AlwaysUnderline;
            ForgotPasswordLabel.LinkColor = Color.FromArgb(230, 80, 80);
            ForgotPasswordLabel.Location = new Point(47, 155);
            ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            ForgotPasswordLabel.Size = new Size(134, 26);
            ForgotPasswordLabel.Style = UIStyle.Red;
            ForgotPasswordLabel.TabIndex = 16;
            ForgotPasswordLabel.TabStop = true;
            ForgotPasswordLabel.Text = "忘记密码?";
            ForgotPasswordLabel.TextAlign = ContentAlignment.MiddleCenter;
            ForgotPasswordLabel.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            ForgotPasswordLabel.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            ForgotPasswordLabel.Click += Login_ForgotPassword_Click;
            // 
            // AccountPasswordTextBox
            // 
            AccountPasswordTextBox.ButtonFillColor = Color.FromArgb(230, 80, 80);
            AccountPasswordTextBox.ButtonFillHoverColor = Color.FromArgb(235, 115, 115);
            AccountPasswordTextBox.ButtonFillPressColor = Color.FromArgb(184, 64, 64);
            AccountPasswordTextBox.ButtonRectColor = Color.FromArgb(230, 80, 80);
            AccountPasswordTextBox.ButtonRectHoverColor = Color.FromArgb(235, 115, 115);
            AccountPasswordTextBox.ButtonRectPressColor = Color.FromArgb(184, 64, 64);
            AccountPasswordTextBox.Cursor = Cursors.IBeam;
            AccountPasswordTextBox.FillColor2 = Color.FromArgb(253, 243, 243);
            AccountPasswordTextBox.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AccountPasswordTextBox.Location = new Point(21, 116);
            AccountPasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            AccountPasswordTextBox.MinimumSize = new Size(1, 11);
            AccountPasswordTextBox.Name = "AccountPasswordTextBox";
            AccountPasswordTextBox.PasswordChar = '*';
            AccountPasswordTextBox.RectColor = Color.FromArgb(230, 80, 80);
            AccountPasswordTextBox.ScrollBarColor = Color.FromArgb(230, 80, 80);
            AccountPasswordTextBox.ShowText = false;
            AccountPasswordTextBox.Size = new Size(217, 29);
            AccountPasswordTextBox.Style = UIStyle.Custom;
            AccountPasswordTextBox.Symbol = 61475;
            AccountPasswordTextBox.SymbolSize = 22;
            AccountPasswordTextBox.TabIndex = 1;
            AccountPasswordTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            AccountPasswordTextBox.Watermark = "密码";
            AccountPasswordTextBox.WatermarkActiveColor = Color.DarkGray;
            AccountPasswordTextBox.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            AccountPasswordTextBox.KeyPress += Login_PasswordKeyPress;
            // 
            // RegisterAccountLabel
            // 
            RegisterAccountLabel.BackgroundImage = (Image)resources.GetObject("RegisterAccountLabel.BackgroundImage");
            RegisterAccountLabel.Cursor = Cursors.Hand;
            RegisterAccountLabel.FillColor = Color.FromArgb(230, 80, 80);
            RegisterAccountLabel.FillColor2 = Color.FromArgb(230, 80, 80);
            RegisterAccountLabel.FillHoverColor = Color.FromArgb(235, 115, 115);
            RegisterAccountLabel.FillPressColor = Color.FromArgb(184, 64, 64);
            RegisterAccountLabel.FillSelectedColor = Color.FromArgb(184, 64, 64);
            RegisterAccountLabel.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterAccountLabel.Location = new Point(21, 256);
            RegisterAccountLabel.Margin = new Padding(3, 2, 3, 2);
            RegisterAccountLabel.MinimumSize = new Size(1, 1);
            RegisterAccountLabel.Name = "RegisterAccountLabel";
            RegisterAccountLabel.RectColor = Color.FromArgb(230, 80, 80);
            RegisterAccountLabel.RectHoverColor = Color.FromArgb(235, 115, 115);
            RegisterAccountLabel.RectPressColor = Color.FromArgb(184, 64, 64);
            RegisterAccountLabel.RectSelectedColor = Color.FromArgb(184, 64, 64);
            RegisterAccountLabel.Size = new Size(217, 29);
            RegisterAccountLabel.Style = UIStyle.Red;
            RegisterAccountLabel.Symbol = 62004;
            RegisterAccountLabel.TabIndex = 3;
            RegisterAccountLabel.TabStop = false;
            RegisterAccountLabel.Text = "注册";
            RegisterAccountLabel.TipsColor = Color.FromArgb(128, 255, 128);
            RegisterAccountLabel.TipsFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterAccountLabel.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            RegisterAccountLabel.Click += Login_Registertab_Click;
            // 
            // login_error_label
            // 
            login_error_label.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            login_error_label.ForeColor = Color.Red;
            login_error_label.Location = new Point(24, 191);
            login_error_label.Name = "login_error_label";
            login_error_label.Size = new Size(214, 16);
            login_error_label.Style = UIStyle.Custom;
            login_error_label.TabIndex = 15;
            login_error_label.Text = "错误提示";
            login_error_label.TextAlign = ContentAlignment.MiddleCenter;
            login_error_label.Visible = false;
            login_error_label.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // AccountTextBox
            // 
            AccountTextBox.ButtonFillColor = Color.FromArgb(230, 80, 80);
            AccountTextBox.ButtonFillHoverColor = Color.FromArgb(235, 115, 115);
            AccountTextBox.ButtonFillPressColor = Color.FromArgb(184, 64, 64);
            AccountTextBox.ButtonRectColor = Color.FromArgb(230, 80, 80);
            AccountTextBox.ButtonRectHoverColor = Color.FromArgb(235, 115, 115);
            AccountTextBox.ButtonRectPressColor = Color.FromArgb(184, 64, 64);
            AccountTextBox.Cursor = Cursors.IBeam;
            AccountTextBox.FillColor2 = Color.FromArgb(253, 243, 243);
            AccountTextBox.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AccountTextBox.Location = new Point(21, 73);
            AccountTextBox.Margin = new Padding(3, 4, 3, 4);
            AccountTextBox.MinimumSize = new Size(1, 11);
            AccountTextBox.Name = "AccountTextBox";
            AccountTextBox.RectColor = Color.FromArgb(230, 80, 80);
            AccountTextBox.ScrollBarColor = Color.FromArgb(230, 80, 80);
            AccountTextBox.ShowText = false;
            AccountTextBox.Size = new Size(217, 29);
            AccountTextBox.Style = UIStyle.Red;
            AccountTextBox.Symbol = 61447;
            AccountTextBox.SymbolSize = 22;
            AccountTextBox.TabIndex = 0;
            AccountTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            AccountTextBox.Watermark = "账号";
            AccountTextBox.WatermarkActiveColor = Color.DarkGray;
            AccountTextBox.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // RegistrationTab
            // 
            RegistrationTab.BackColor = Color.FromArgb(255, 244, 240);
            RegistrationTab.BackgroundImageLayout = ImageLayout.Zoom;
            RegistrationTab.Controls.Add(Register_Back_To_LoginBtn);
            RegistrationTab.Controls.Add(RegistrationErrorLabel);
            RegistrationTab.Controls.Add(Register_AccountBtn);
            RegistrationTab.Controls.Add(Register_SecretAnswerTextBox);
            RegistrationTab.Controls.Add(Register_PasswordTextBox);
            RegistrationTab.Controls.Add(Register_QuestionTextBox);
            RegistrationTab.Controls.Add(Register_AccountNameTextBox);
            RegistrationTab.Location = new Point(0, 28);
            RegistrationTab.Margin = new Padding(3, 2, 3, 2);
            RegistrationTab.Name = "RegistrationTab";
            RegistrationTab.Size = new Size(200, 72);
            RegistrationTab.TabIndex = 1;
            RegistrationTab.Text = "账号注册";
            // 
            // Register_Back_To_LoginBtn
            // 
            Register_Back_To_LoginBtn.BackgroundImage = (Image)resources.GetObject("Register_Back_To_LoginBtn.BackgroundImage");
            Register_Back_To_LoginBtn.Cursor = Cursors.Hand;
            Register_Back_To_LoginBtn.FillColor = Color.FromArgb(230, 80, 80);
            Register_Back_To_LoginBtn.FillColor2 = Color.FromArgb(230, 80, 80);
            Register_Back_To_LoginBtn.FillHoverColor = Color.FromArgb(235, 115, 115);
            Register_Back_To_LoginBtn.FillPressColor = Color.FromArgb(184, 64, 64);
            Register_Back_To_LoginBtn.FillSelectedColor = Color.FromArgb(184, 64, 64);
            Register_Back_To_LoginBtn.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Register_Back_To_LoginBtn.Location = new Point(21, 263);
            Register_Back_To_LoginBtn.Margin = new Padding(3, 2, 3, 2);
            Register_Back_To_LoginBtn.MinimumSize = new Size(1, 1);
            Register_Back_To_LoginBtn.Name = "Register_Back_To_LoginBtn";
            Register_Back_To_LoginBtn.RectColor = Color.FromArgb(230, 80, 80);
            Register_Back_To_LoginBtn.RectHoverColor = Color.FromArgb(235, 115, 115);
            Register_Back_To_LoginBtn.RectPressColor = Color.FromArgb(184, 64, 64);
            Register_Back_To_LoginBtn.RectSelectedColor = Color.FromArgb(184, 64, 64);
            Register_Back_To_LoginBtn.Size = new Size(213, 30);
            Register_Back_To_LoginBtn.Style = UIStyle.Custom;
            Register_Back_To_LoginBtn.Symbol = 61730;
            Register_Back_To_LoginBtn.TabIndex = 20;
            Register_Back_To_LoginBtn.TabStop = false;
            Register_Back_To_LoginBtn.Text = "返回注册";
            Register_Back_To_LoginBtn.TipsColor = Color.FromArgb(128, 255, 128);
            Register_Back_To_LoginBtn.TipsFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Register_Back_To_LoginBtn.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            Register_Back_To_LoginBtn.Click += RegisterBackToLogin_Click;
            // 
            // RegistrationErrorLabel
            // 
            RegistrationErrorLabel.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RegistrationErrorLabel.ForeColor = Color.Red;
            RegistrationErrorLabel.Location = new Point(21, 194);
            RegistrationErrorLabel.Name = "RegistrationErrorLabel";
            RegistrationErrorLabel.Size = new Size(213, 23);
            RegistrationErrorLabel.Style = UIStyle.Custom;
            RegistrationErrorLabel.TabIndex = 17;
            RegistrationErrorLabel.Text = "错误信息";
            RegistrationErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            RegistrationErrorLabel.Visible = false;
            RegistrationErrorLabel.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // Register_AccountBtn
            // 
            Register_AccountBtn.BackgroundImage = (Image)resources.GetObject("Register_AccountBtn.BackgroundImage");
            Register_AccountBtn.Cursor = Cursors.Hand;
            Register_AccountBtn.FillColor = Color.FromArgb(230, 80, 80);
            Register_AccountBtn.FillColor2 = Color.FromArgb(230, 80, 80);
            Register_AccountBtn.FillHoverColor = Color.FromArgb(235, 115, 115);
            Register_AccountBtn.FillPressColor = Color.FromArgb(184, 64, 64);
            Register_AccountBtn.FillSelectedColor = Color.FromArgb(184, 64, 64);
            Register_AccountBtn.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Register_AccountBtn.Location = new Point(21, 219);
            Register_AccountBtn.Margin = new Padding(3, 2, 3, 2);
            Register_AccountBtn.MinimumSize = new Size(1, 1);
            Register_AccountBtn.Name = "Register_AccountBtn";
            Register_AccountBtn.RectColor = Color.FromArgb(230, 80, 80);
            Register_AccountBtn.RectHoverColor = Color.FromArgb(235, 115, 115);
            Register_AccountBtn.RectPressColor = Color.FromArgb(184, 64, 64);
            Register_AccountBtn.RectSelectedColor = Color.FromArgb(184, 64, 64);
            Register_AccountBtn.Size = new Size(213, 30);
            Register_AccountBtn.Style = UIStyle.Custom;
            Register_AccountBtn.Symbol = 62004;
            Register_AccountBtn.TabIndex = 16;
            Register_AccountBtn.TabStop = false;
            Register_AccountBtn.Text = "注册账号";
            Register_AccountBtn.TipsColor = Color.FromArgb(128, 255, 128);
            Register_AccountBtn.TipsFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Register_AccountBtn.TipsForeColor = Color.LightSkyBlue;
            Register_AccountBtn.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            Register_AccountBtn.Click += RegisterAccount_Click;
            // 
            // Register_SecretAnswerTextBox
            // 
            Register_SecretAnswerTextBox.ButtonFillColor = Color.FromArgb(230, 80, 80);
            Register_SecretAnswerTextBox.ButtonFillHoverColor = Color.FromArgb(235, 115, 115);
            Register_SecretAnswerTextBox.ButtonFillPressColor = Color.FromArgb(184, 64, 64);
            Register_SecretAnswerTextBox.ButtonRectColor = Color.FromArgb(230, 80, 80);
            Register_SecretAnswerTextBox.ButtonRectHoverColor = Color.FromArgb(235, 115, 115);
            Register_SecretAnswerTextBox.ButtonRectPressColor = Color.FromArgb(184, 64, 64);
            Register_SecretAnswerTextBox.Cursor = Cursors.IBeam;
            Register_SecretAnswerTextBox.FillColor2 = Color.FromArgb(253, 243, 243);
            Register_SecretAnswerTextBox.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Register_SecretAnswerTextBox.Location = new Point(21, 121);
            Register_SecretAnswerTextBox.Margin = new Padding(3, 4, 3, 4);
            Register_SecretAnswerTextBox.MinimumSize = new Size(1, 11);
            Register_SecretAnswerTextBox.Name = "Register_SecretAnswerTextBox";
            Register_SecretAnswerTextBox.PasswordChar = '*';
            Register_SecretAnswerTextBox.RectColor = Color.FromArgb(230, 80, 80);
            Register_SecretAnswerTextBox.ScrollBarColor = Color.FromArgb(230, 80, 80);
            Register_SecretAnswerTextBox.ShowText = false;
            Register_SecretAnswerTextBox.Size = new Size(213, 30);
            Register_SecretAnswerTextBox.Style = UIStyle.Red;
            Register_SecretAnswerTextBox.Symbol = 61530;
            Register_SecretAnswerTextBox.SymbolSize = 22;
            Register_SecretAnswerTextBox.TabIndex = 4;
            Register_SecretAnswerTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            Register_SecretAnswerTextBox.Watermark = "请输入问题答案";
            Register_SecretAnswerTextBox.WatermarkActiveColor = Color.DarkGray;
            Register_SecretAnswerTextBox.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // Register_PasswordTextBox
            // 
            Register_PasswordTextBox.ButtonFillColor = Color.FromArgb(230, 80, 80);
            Register_PasswordTextBox.ButtonFillHoverColor = Color.FromArgb(235, 115, 115);
            Register_PasswordTextBox.ButtonFillPressColor = Color.FromArgb(184, 64, 64);
            Register_PasswordTextBox.ButtonRectColor = Color.FromArgb(230, 80, 80);
            Register_PasswordTextBox.ButtonRectHoverColor = Color.FromArgb(235, 115, 115);
            Register_PasswordTextBox.ButtonRectPressColor = Color.FromArgb(184, 64, 64);
            Register_PasswordTextBox.Cursor = Cursors.IBeam;
            Register_PasswordTextBox.FillColor2 = Color.FromArgb(253, 243, 243);
            Register_PasswordTextBox.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Register_PasswordTextBox.Location = new Point(21, 47);
            Register_PasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            Register_PasswordTextBox.MinimumSize = new Size(1, 11);
            Register_PasswordTextBox.Name = "Register_PasswordTextBox";
            Register_PasswordTextBox.PasswordChar = '*';
            Register_PasswordTextBox.RectColor = Color.FromArgb(230, 80, 80);
            Register_PasswordTextBox.ScrollBarColor = Color.FromArgb(230, 80, 80);
            Register_PasswordTextBox.ShowText = false;
            Register_PasswordTextBox.Size = new Size(213, 30);
            Register_PasswordTextBox.Style = UIStyle.Red;
            Register_PasswordTextBox.Symbol = 61475;
            Register_PasswordTextBox.SymbolSize = 22;
            Register_PasswordTextBox.TabIndex = 2;
            Register_PasswordTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            Register_PasswordTextBox.Watermark = "请输入密码";
            Register_PasswordTextBox.WatermarkActiveColor = Color.DarkGray;
            Register_PasswordTextBox.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // Register_QuestionTextBox
            // 
            Register_QuestionTextBox.ButtonFillColor = Color.FromArgb(230, 80, 80);
            Register_QuestionTextBox.ButtonFillHoverColor = Color.FromArgb(235, 115, 115);
            Register_QuestionTextBox.ButtonFillPressColor = Color.FromArgb(184, 64, 64);
            Register_QuestionTextBox.ButtonRectColor = Color.FromArgb(230, 80, 80);
            Register_QuestionTextBox.ButtonRectHoverColor = Color.FromArgb(235, 115, 115);
            Register_QuestionTextBox.ButtonRectPressColor = Color.FromArgb(184, 64, 64);
            Register_QuestionTextBox.Cursor = Cursors.IBeam;
            Register_QuestionTextBox.FillColor2 = Color.FromArgb(253, 243, 243);
            Register_QuestionTextBox.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Register_QuestionTextBox.Location = new Point(21, 84);
            Register_QuestionTextBox.Margin = new Padding(3, 4, 3, 4);
            Register_QuestionTextBox.MinimumSize = new Size(1, 11);
            Register_QuestionTextBox.Name = "Register_QuestionTextBox";
            Register_QuestionTextBox.RectColor = Color.FromArgb(230, 80, 80);
            Register_QuestionTextBox.ScrollBarColor = Color.FromArgb(230, 80, 80);
            Register_QuestionTextBox.ShowText = false;
            Register_QuestionTextBox.Size = new Size(213, 30);
            Register_QuestionTextBox.Style = UIStyle.Red;
            Register_QuestionTextBox.Symbol = 61530;
            Register_QuestionTextBox.SymbolSize = 22;
            Register_QuestionTextBox.TabIndex = 3;
            Register_QuestionTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            Register_QuestionTextBox.Watermark = "请输入密保问题";
            Register_QuestionTextBox.WatermarkActiveColor = Color.DarkGray;
            Register_QuestionTextBox.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // Register_AccountNameTextBox
            // 
            Register_AccountNameTextBox.ButtonFillColor = Color.FromArgb(230, 80, 80);
            Register_AccountNameTextBox.ButtonFillHoverColor = Color.FromArgb(235, 115, 115);
            Register_AccountNameTextBox.ButtonFillPressColor = Color.FromArgb(184, 64, 64);
            Register_AccountNameTextBox.ButtonRectColor = Color.FromArgb(230, 80, 80);
            Register_AccountNameTextBox.ButtonRectHoverColor = Color.FromArgb(235, 115, 115);
            Register_AccountNameTextBox.ButtonRectPressColor = Color.FromArgb(184, 64, 64);
            Register_AccountNameTextBox.Cursor = Cursors.IBeam;
            Register_AccountNameTextBox.FillColor2 = Color.FromArgb(253, 243, 243);
            Register_AccountNameTextBox.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Register_AccountNameTextBox.Location = new Point(21, 10);
            Register_AccountNameTextBox.Margin = new Padding(3, 4, 3, 4);
            Register_AccountNameTextBox.MinimumSize = new Size(1, 11);
            Register_AccountNameTextBox.Name = "Register_AccountNameTextBox";
            Register_AccountNameTextBox.RectColor = Color.FromArgb(230, 80, 80);
            Register_AccountNameTextBox.ScrollBarColor = Color.FromArgb(230, 80, 80);
            Register_AccountNameTextBox.ShowText = false;
            Register_AccountNameTextBox.Size = new Size(213, 30);
            Register_AccountNameTextBox.Style = UIStyle.Red;
            Register_AccountNameTextBox.Symbol = 61447;
            Register_AccountNameTextBox.SymbolSize = 22;
            Register_AccountNameTextBox.TabIndex = 1;
            Register_AccountNameTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            Register_AccountNameTextBox.Watermark = "请输入账号";
            Register_AccountNameTextBox.WatermarkActiveColor = Color.DarkGray;
            Register_AccountNameTextBox.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // ChangePasswordTab
            // 
            ChangePasswordTab.BackColor = Color.FromArgb(255, 244, 240);
            ChangePasswordTab.Controls.Add(Modify_Back_To_LoginBtn);
            ChangePasswordTab.Controls.Add(Modify_ErrorLabel);
            ChangePasswordTab.Controls.Add(Modify_PasswordBtn);
            ChangePasswordTab.Controls.Add(Modify_AnswerTextBox);
            ChangePasswordTab.Controls.Add(Modify_PasswordTextBox);
            ChangePasswordTab.Controls.Add(Modify_QuestionTextBox);
            ChangePasswordTab.Controls.Add(Modify_AccountNameTextBox);
            ChangePasswordTab.Location = new Point(0, 28);
            ChangePasswordTab.Margin = new Padding(3, 2, 3, 2);
            ChangePasswordTab.Name = "ChangePasswordTab";
            ChangePasswordTab.Size = new Size(200, 72);
            ChangePasswordTab.TabIndex = 2;
            ChangePasswordTab.Text = "密码修改";
            // 
            // Modify_Back_To_LoginBtn
            // 
            Modify_Back_To_LoginBtn.BackgroundImage = (Image)resources.GetObject("Modify_Back_To_LoginBtn.BackgroundImage");
            Modify_Back_To_LoginBtn.Cursor = Cursors.Hand;
            Modify_Back_To_LoginBtn.FillColor = Color.FromArgb(230, 80, 80);
            Modify_Back_To_LoginBtn.FillColor2 = Color.FromArgb(230, 80, 80);
            Modify_Back_To_LoginBtn.FillHoverColor = Color.FromArgb(235, 115, 115);
            Modify_Back_To_LoginBtn.FillPressColor = Color.FromArgb(184, 64, 64);
            Modify_Back_To_LoginBtn.FillSelectedColor = Color.FromArgb(184, 64, 64);
            Modify_Back_To_LoginBtn.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Modify_Back_To_LoginBtn.Location = new Point(21, 262);
            Modify_Back_To_LoginBtn.Margin = new Padding(3, 2, 3, 2);
            Modify_Back_To_LoginBtn.MinimumSize = new Size(1, 1);
            Modify_Back_To_LoginBtn.Name = "Modify_Back_To_LoginBtn";
            Modify_Back_To_LoginBtn.RectColor = Color.FromArgb(230, 80, 80);
            Modify_Back_To_LoginBtn.RectHoverColor = Color.FromArgb(235, 115, 115);
            Modify_Back_To_LoginBtn.RectPressColor = Color.FromArgb(184, 64, 64);
            Modify_Back_To_LoginBtn.RectSelectedColor = Color.FromArgb(184, 64, 64);
            Modify_Back_To_LoginBtn.Size = new Size(213, 30);
            Modify_Back_To_LoginBtn.Style = UIStyle.Red;
            Modify_Back_To_LoginBtn.Symbol = 61730;
            Modify_Back_To_LoginBtn.TabIndex = 24;
            Modify_Back_To_LoginBtn.TabStop = false;
            Modify_Back_To_LoginBtn.Text = "返回登录";
            Modify_Back_To_LoginBtn.TipsColor = Color.FromArgb(128, 255, 128);
            Modify_Back_To_LoginBtn.TipsFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Modify_Back_To_LoginBtn.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            Modify_Back_To_LoginBtn.Click += Modify_BackToLogin_Click;
            // 
            // Modify_ErrorLabel
            // 
            Modify_ErrorLabel.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Modify_ErrorLabel.ForeColor = Color.Red;
            Modify_ErrorLabel.Location = new Point(18, 200);
            Modify_ErrorLabel.Name = "Modify_ErrorLabel";
            Modify_ErrorLabel.Size = new Size(216, 16);
            Modify_ErrorLabel.Style = UIStyle.Custom;
            Modify_ErrorLabel.TabIndex = 22;
            Modify_ErrorLabel.Text = "错误信息";
            Modify_ErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            Modify_ErrorLabel.Visible = false;
            Modify_ErrorLabel.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // Modify_PasswordBtn
            // 
            Modify_PasswordBtn.BackgroundImage = (Image)resources.GetObject("Modify_PasswordBtn.BackgroundImage");
            Modify_PasswordBtn.Cursor = Cursors.Hand;
            Modify_PasswordBtn.FillColor = Color.FromArgb(230, 80, 80);
            Modify_PasswordBtn.FillColor2 = Color.FromArgb(230, 80, 80);
            Modify_PasswordBtn.FillHoverColor = Color.FromArgb(235, 115, 115);
            Modify_PasswordBtn.FillPressColor = Color.FromArgb(184, 64, 64);
            Modify_PasswordBtn.FillSelectedColor = Color.FromArgb(184, 64, 64);
            Modify_PasswordBtn.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Modify_PasswordBtn.Location = new Point(21, 219);
            Modify_PasswordBtn.Margin = new Padding(3, 2, 3, 2);
            Modify_PasswordBtn.MinimumSize = new Size(1, 1);
            Modify_PasswordBtn.Name = "Modify_PasswordBtn";
            Modify_PasswordBtn.RectColor = Color.FromArgb(230, 80, 80);
            Modify_PasswordBtn.RectHoverColor = Color.FromArgb(235, 115, 115);
            Modify_PasswordBtn.RectPressColor = Color.FromArgb(184, 64, 64);
            Modify_PasswordBtn.RectSelectedColor = Color.FromArgb(184, 64, 64);
            Modify_PasswordBtn.Size = new Size(213, 30);
            Modify_PasswordBtn.Style = UIStyle.Custom;
            Modify_PasswordBtn.Symbol = 61573;
            Modify_PasswordBtn.TabIndex = 21;
            Modify_PasswordBtn.TabStop = false;
            Modify_PasswordBtn.Text = "修改密码";
            Modify_PasswordBtn.TipsColor = Color.FromArgb(128, 255, 128);
            Modify_PasswordBtn.TipsFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Modify_PasswordBtn.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            Modify_PasswordBtn.Click += Modify_ChangePassword_Click;
            // 
            // Modify_AnswerTextBox
            // 
            Modify_AnswerTextBox.ButtonFillColor = Color.FromArgb(230, 80, 80);
            Modify_AnswerTextBox.ButtonFillHoverColor = Color.FromArgb(235, 115, 115);
            Modify_AnswerTextBox.ButtonFillPressColor = Color.FromArgb(184, 64, 64);
            Modify_AnswerTextBox.ButtonRectColor = Color.FromArgb(230, 80, 80);
            Modify_AnswerTextBox.ButtonRectHoverColor = Color.FromArgb(235, 115, 115);
            Modify_AnswerTextBox.ButtonRectPressColor = Color.FromArgb(184, 64, 64);
            Modify_AnswerTextBox.Cursor = Cursors.IBeam;
            Modify_AnswerTextBox.FillColor2 = Color.FromArgb(253, 243, 243);
            Modify_AnswerTextBox.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Modify_AnswerTextBox.Location = new Point(21, 121);
            Modify_AnswerTextBox.Margin = new Padding(3, 4, 3, 4);
            Modify_AnswerTextBox.MinimumSize = new Size(1, 11);
            Modify_AnswerTextBox.Name = "Modify_AnswerTextBox";
            Modify_AnswerTextBox.PasswordChar = '*';
            Modify_AnswerTextBox.RectColor = Color.FromArgb(230, 80, 80);
            Modify_AnswerTextBox.ScrollBarColor = Color.FromArgb(230, 80, 80);
            Modify_AnswerTextBox.ShowText = false;
            Modify_AnswerTextBox.Size = new Size(213, 30);
            Modify_AnswerTextBox.Style = UIStyle.Red;
            Modify_AnswerTextBox.Symbol = 61530;
            Modify_AnswerTextBox.SymbolSize = 22;
            Modify_AnswerTextBox.TabIndex = 20;
            Modify_AnswerTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            Modify_AnswerTextBox.Watermark = "请输入问题答案";
            Modify_AnswerTextBox.WatermarkActiveColor = Color.DarkGray;
            Modify_AnswerTextBox.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // Modify_PasswordTextBox
            // 
            Modify_PasswordTextBox.ButtonFillColor = Color.FromArgb(230, 80, 80);
            Modify_PasswordTextBox.ButtonFillHoverColor = Color.FromArgb(235, 115, 115);
            Modify_PasswordTextBox.ButtonFillPressColor = Color.FromArgb(184, 64, 64);
            Modify_PasswordTextBox.ButtonRectColor = Color.FromArgb(230, 80, 80);
            Modify_PasswordTextBox.ButtonRectHoverColor = Color.FromArgb(235, 115, 115);
            Modify_PasswordTextBox.ButtonRectPressColor = Color.FromArgb(184, 64, 64);
            Modify_PasswordTextBox.Cursor = Cursors.IBeam;
            Modify_PasswordTextBox.FillColor2 = Color.FromArgb(253, 243, 243);
            Modify_PasswordTextBox.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Modify_PasswordTextBox.Location = new Point(21, 47);
            Modify_PasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            Modify_PasswordTextBox.MinimumSize = new Size(1, 11);
            Modify_PasswordTextBox.Name = "Modify_PasswordTextBox";
            Modify_PasswordTextBox.PasswordChar = '*';
            Modify_PasswordTextBox.RectColor = Color.FromArgb(230, 80, 80);
            Modify_PasswordTextBox.ScrollBarColor = Color.FromArgb(230, 80, 80);
            Modify_PasswordTextBox.ShowText = false;
            Modify_PasswordTextBox.Size = new Size(213, 30);
            Modify_PasswordTextBox.Style = UIStyle.Red;
            Modify_PasswordTextBox.Symbol = 61475;
            Modify_PasswordTextBox.SymbolSize = 22;
            Modify_PasswordTextBox.TabIndex = 18;
            Modify_PasswordTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            Modify_PasswordTextBox.Watermark = "请输入新密码";
            Modify_PasswordTextBox.WatermarkActiveColor = Color.DarkGray;
            Modify_PasswordTextBox.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // Modify_QuestionTextBox
            // 
            Modify_QuestionTextBox.ButtonFillColor = Color.FromArgb(230, 80, 80);
            Modify_QuestionTextBox.ButtonFillHoverColor = Color.FromArgb(235, 115, 115);
            Modify_QuestionTextBox.ButtonFillPressColor = Color.FromArgb(184, 64, 64);
            Modify_QuestionTextBox.ButtonRectColor = Color.FromArgb(230, 80, 80);
            Modify_QuestionTextBox.ButtonRectHoverColor = Color.FromArgb(235, 115, 115);
            Modify_QuestionTextBox.ButtonRectPressColor = Color.FromArgb(184, 64, 64);
            Modify_QuestionTextBox.Cursor = Cursors.IBeam;
            Modify_QuestionTextBox.FillColor2 = Color.FromArgb(253, 243, 243);
            Modify_QuestionTextBox.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Modify_QuestionTextBox.Location = new Point(21, 84);
            Modify_QuestionTextBox.Margin = new Padding(3, 4, 3, 4);
            Modify_QuestionTextBox.MinimumSize = new Size(1, 11);
            Modify_QuestionTextBox.Name = "Modify_QuestionTextBox";
            Modify_QuestionTextBox.RectColor = Color.FromArgb(230, 80, 80);
            Modify_QuestionTextBox.ScrollBarColor = Color.FromArgb(230, 80, 80);
            Modify_QuestionTextBox.ShowText = false;
            Modify_QuestionTextBox.Size = new Size(213, 30);
            Modify_QuestionTextBox.Style = UIStyle.Red;
            Modify_QuestionTextBox.Symbol = 61530;
            Modify_QuestionTextBox.SymbolSize = 22;
            Modify_QuestionTextBox.TabIndex = 19;
            Modify_QuestionTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            Modify_QuestionTextBox.Watermark = "请输入密保问题";
            Modify_QuestionTextBox.WatermarkActiveColor = Color.DarkGray;
            Modify_QuestionTextBox.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // Modify_AccountNameTextBox
            // 
            Modify_AccountNameTextBox.ButtonFillColor = Color.FromArgb(230, 80, 80);
            Modify_AccountNameTextBox.ButtonFillHoverColor = Color.FromArgb(235, 115, 115);
            Modify_AccountNameTextBox.ButtonFillPressColor = Color.FromArgb(184, 64, 64);
            Modify_AccountNameTextBox.ButtonRectColor = Color.FromArgb(230, 80, 80);
            Modify_AccountNameTextBox.ButtonRectHoverColor = Color.FromArgb(235, 115, 115);
            Modify_AccountNameTextBox.ButtonRectPressColor = Color.FromArgb(184, 64, 64);
            Modify_AccountNameTextBox.Cursor = Cursors.IBeam;
            Modify_AccountNameTextBox.FillColor2 = Color.FromArgb(253, 243, 243);
            Modify_AccountNameTextBox.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Modify_AccountNameTextBox.Location = new Point(21, 10);
            Modify_AccountNameTextBox.Margin = new Padding(3, 4, 3, 4);
            Modify_AccountNameTextBox.MinimumSize = new Size(1, 11);
            Modify_AccountNameTextBox.Name = "Modify_AccountNameTextBox";
            Modify_AccountNameTextBox.RectColor = Color.FromArgb(230, 80, 80);
            Modify_AccountNameTextBox.ScrollBarColor = Color.FromArgb(230, 80, 80);
            Modify_AccountNameTextBox.ShowText = false;
            Modify_AccountNameTextBox.Size = new Size(213, 30);
            Modify_AccountNameTextBox.Style = UIStyle.Red;
            Modify_AccountNameTextBox.Symbol = 61447;
            Modify_AccountNameTextBox.SymbolSize = 22;
            Modify_AccountNameTextBox.TabIndex = 17;
            Modify_AccountNameTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            Modify_AccountNameTextBox.Watermark = "请输入已有账号";
            Modify_AccountNameTextBox.WatermarkActiveColor = Color.DarkGray;
            Modify_AccountNameTextBox.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // StartGameTab
            // 
            StartGameTab.BackColor = Color.FromArgb(255, 244, 240);
            StartGameTab.BackgroundImageLayout = ImageLayout.Zoom;
            StartGameTab.Controls.Add(uiCheckBox2);
            StartGameTab.Controls.Add(uiCheckBox1);
            StartGameTab.Controls.Add(StartTheCurrentServerLabel);
            StartGameTab.Controls.Add(activate_account);
            StartGameTab.Controls.Add(start_selected_zone);
            StartGameTab.Controls.Add(GameServerList);
            StartGameTab.Controls.Add(Launcher_enterGameBtn);
            StartGameTab.Location = new Point(0, 28);
            StartGameTab.Margin = new Padding(3, 2, 3, 2);
            StartGameTab.Name = "StartGameTab";
            StartGameTab.Size = new Size(331, 335);
            StartGameTab.TabIndex = 3;
            StartGameTab.Text = "启动游戏";
            // 
            // uiCheckBox2
            // 
            uiCheckBox2.CheckBoxColor = Color.FromArgb(48, 48, 48);
            uiCheckBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiCheckBox2.Location = new Point(142, 224);
            uiCheckBox2.MinimumSize = new Size(1, 1);
            uiCheckBox2.Name = "uiCheckBox2";
            uiCheckBox2.Padding = new Padding(22, 0, 0, 0);
            uiCheckBox2.Size = new Size(150, 33);
            uiCheckBox2.Style = UIStyle.Custom;
            uiCheckBox2.TabIndex = 29;
            uiCheckBox2.Text = "64Bit";
            uiCheckBox2.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            uiCheckBox2.CheckedChanged += uiCheckBox2_CheckedChanged;
            // 
            // uiCheckBox1
            // 
            uiCheckBox1.CheckBoxColor = Color.FromArgb(48, 48, 48);
            uiCheckBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiCheckBox1.Location = new Point(46, 224);
            uiCheckBox1.MinimumSize = new Size(1, 1);
            uiCheckBox1.Name = "uiCheckBox1";
            uiCheckBox1.Padding = new Padding(22, 0, 0, 0);
            uiCheckBox1.Size = new Size(150, 33);
            uiCheckBox1.Style = UIStyle.Custom;
            uiCheckBox1.TabIndex = 28;
            uiCheckBox1.Text = "32Bit";
            uiCheckBox1.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            uiCheckBox1.CheckedChanged += uiCheckBox1_CheckedChanged;
            // 
            // StartTheCurrentServerLabel
            // 
            StartTheCurrentServerLabel.AutoSize = true;
            StartTheCurrentServerLabel.Font = new Font("黑体", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartTheCurrentServerLabel.ForeColor = Color.FromArgb(48, 48, 48);
            StartTheCurrentServerLabel.Location = new Point(7, 269);
            StartTheCurrentServerLabel.Name = "StartTheCurrentServerLabel";
            StartTheCurrentServerLabel.Size = new Size(126, 14);
            StartTheCurrentServerLabel.TabIndex = 27;
            StartTheCurrentServerLabel.Text = "当前选择的服务器:";
            StartTheCurrentServerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // activate_account
            // 
            activate_account.Cursor = Cursors.Hand;
            activate_account.Enabled = false;
            activate_account.FillColor = Color.FromArgb(110, 190, 40);
            activate_account.FillColor2 = Color.FromArgb(110, 190, 40);
            activate_account.FillHoverColor = Color.FromArgb(139, 203, 83);
            activate_account.FillPressColor = Color.FromArgb(88, 152, 32);
            activate_account.FillSelectedColor = Color.FromArgb(88, 152, 32);
            activate_account.Font = new Font("黑体", 14F, FontStyle.Regular, GraphicsUnit.Point);
            activate_account.Location = new Point(3, 2);
            activate_account.Margin = new Padding(3, 2, 3, 2);
            activate_account.MinimumSize = new Size(1, 1);
            activate_account.Name = "activate_account";
            activate_account.Radius = 15;
            activate_account.RectColor = Color.FromArgb(110, 190, 40);
            activate_account.RectHoverColor = Color.FromArgb(139, 203, 83);
            activate_account.RectPressColor = Color.FromArgb(88, 152, 32);
            activate_account.RectSelectedColor = Color.FromArgb(88, 152, 32);
            activate_account.Size = new Size(253, 30);
            activate_account.Style = UIStyle.Green;
            activate_account.Symbol = 57607;
            activate_account.SymbolSize = 30;
            activate_account.TabIndex = 9;
            activate_account.Text = "账户名";
            activate_account.TipsFont = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            activate_account.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // start_selected_zone
            // 
            start_selected_zone.ActiveLinkColor = Color.FromArgb(220, 155, 40);
            start_selected_zone.Enabled = false;
            start_selected_zone.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            start_selected_zone.ImageAlign = ContentAlignment.MiddleRight;
            start_selected_zone.LinkBehavior = LinkBehavior.NeverUnderline;
            start_selected_zone.LinkColor = Color.FromArgb(192, 64, 0);
            start_selected_zone.Location = new Point(131, 260);
            start_selected_zone.Name = "start_selected_zone";
            start_selected_zone.Size = new Size(116, 25);
            start_selected_zone.Style = UIStyle.Custom;
            start_selected_zone.TabIndex = 7;
            start_selected_zone.TextAlign = ContentAlignment.MiddleCenter;
            start_selected_zone.Visible = false;
            start_selected_zone.VisitedLinkColor = Color.FromArgb(230, 80, 80);
            start_selected_zone.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // GameServerList
            // 
            GameServerList.BackColor = Color.Wheat;
            GameServerList.DrawMode = DrawMode.OwnerDrawVariable;
            GameServerList.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            GameServerList.ForeColor = Color.Blue;
            GameServerList.FormattingEnabled = true;
            GameServerList.ItemHeight = 20;
            GameServerList.Items.AddRange(new object[] { "Dragon Server", "Phoenix Server" });
            GameServerList.Location = new Point(73, 40);
            GameServerList.Margin = new Padding(3, 2, 3, 2);
            GameServerList.Name = "GameServerList";
            GameServerList.Size = new Size(120, 171);
            GameServerList.TabIndex = 4;
            GameServerList.TabStop = false;
            GameServerList.DrawItem += StartupChoosegameServer_DrawItem;
            GameServerList.SelectedIndexChanged += StartupChooseGS_SelectedIndexChanged;
            // 
            // Launcher_enterGameBtn
            // 
            Launcher_enterGameBtn.Cursor = Cursors.Hand;
            Launcher_enterGameBtn.FillColor = Color.FromArgb(255, 87, 34);
            Launcher_enterGameBtn.FillColor2 = Color.FromArgb(255, 87, 34);
            Launcher_enterGameBtn.FillHoverColor = Color.FromArgb(255, 121, 78);
            Launcher_enterGameBtn.FillPressColor = Color.FromArgb(204, 70, 28);
            Launcher_enterGameBtn.FillSelectedColor = Color.FromArgb(204, 70, 28);
            Launcher_enterGameBtn.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Launcher_enterGameBtn.Location = new Point(3, 289);
            Launcher_enterGameBtn.Margin = new Padding(3, 2, 3, 2);
            Launcher_enterGameBtn.MinimumSize = new Size(1, 1);
            Launcher_enterGameBtn.Name = "Launcher_enterGameBtn";
            Launcher_enterGameBtn.RectColor = Color.FromArgb(255, 87, 34);
            Launcher_enterGameBtn.RectHoverColor = Color.FromArgb(255, 121, 78);
            Launcher_enterGameBtn.RectPressColor = Color.FromArgb(204, 70, 28);
            Launcher_enterGameBtn.RectSelectedColor = Color.FromArgb(204, 70, 28);
            Launcher_enterGameBtn.Size = new Size(253, 30);
            Launcher_enterGameBtn.Style = UIStyle.Custom;
            Launcher_enterGameBtn.TabIndex = 1;
            Launcher_enterGameBtn.TabStop = false;
            Launcher_enterGameBtn.Text = "进入游戏";
            Launcher_enterGameBtn.TipsFont = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Launcher_enterGameBtn.UseDoubleClick = true;
            Launcher_enterGameBtn.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            Launcher_enterGameBtn.Click += Launch_EnterGame_Click;
            // 
            // InterfaceUpdateTimer
            // 
            InterfaceUpdateTimer.Interval = 30000;
            InterfaceUpdateTimer.Tick += UIUnlock;
            // 
            // DataProcessTimer
            // 
            DataProcessTimer.Enabled = true;
            DataProcessTimer.Tick += PacketProcess;
            // 
            // minimizeToTray
            // 
            minimizeToTray.ContextMenuStrip = TrayRightClickMenu;
            minimizeToTray.Icon = (Icon)resources.GetObject("minimizeToTray.Icon");
            minimizeToTray.Text = "Mir3D Launcher";
            minimizeToTray.MouseClick += TrayRestoreFromTaskBar;
            // 
            // TrayRightClickMenu
            // 
            TrayRightClickMenu.Items.AddRange(new ToolStripItem[] { OpenToolStripMenuItem, QuitToolStripMenuItem });
            TrayRightClickMenu.Name = "TrayRightClickMenu";
            TrayRightClickMenu.Size = new Size(109, 48);
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(108, 22);
            OpenToolStripMenuItem.Text = "Open";
            OpenToolStripMenuItem.Click += Tray_Restore;
            // 
            // QuitToolStripMenuItem
            // 
            QuitToolStripMenuItem.Name = "QuitToolStripMenuItem";
            QuitToolStripMenuItem.Size = new Size(108, 22);
            QuitToolStripMenuItem.Text = "Quit";
            QuitToolStripMenuItem.Click += TrayCloseLauncher;
            // 
            // GameProcessTimer
            // 
            GameProcessTimer.Enabled = true;
            GameProcessTimer.Tick += GameProgressCheck;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(632, 361);
            Controls.Add(MainTab);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "登录器";
            TransparencyKey = Color.Black;
            FormClosing += TrayHideToTaskBar;
            Load += MainForm_Load;
            MainTab.ResumeLayout(false);
            AccountLoginTab.ResumeLayout(false);
            RegistrationTab.ResumeLayout(false);
            ChangePasswordTab.ResumeLayout(false);
            StartGameTab.ResumeLayout(false);
            StartGameTab.PerformLayout();
            TrayRightClickMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        private IContainer components;
        private global::System.Windows.Forms.TabPage AccountLoginTab;
        private UILinkLabel ForgotPasswordLabel;
        private UISymbolButton RegisterAccountLabel;
        private UISymbolButton LoginAccountLabel;
        private UITextBox AccountPasswordTextBox;
        private UITextBox AccountTextBox;
        private global::System.Windows.Forms.TabPage RegistrationTab;
        private global::System.Windows.Forms.TabPage ChangePasswordTab;
        private global::System.Windows.Forms.TabPage StartGameTab;
        private UISymbolButton Register_AccountBtn;
        private UITextBox Register_SecretAnswerTextBox;
        private UITextBox Register_PasswordTextBox;
        private UITextBox Register_QuestionTextBox;
        private UITextBox Register_AccountNameTextBox;
        private UISymbolButton Modify_PasswordBtn;
        private UITextBox Modify_AnswerTextBox;
        private UITextBox Modify_PasswordTextBox;
        private UITextBox Modify_QuestionTextBox;
        private UITextBox Modify_AccountNameTextBox;
        private UIButton Launcher_enterGameBtn;
        private UILabel RegistrationErrorLabel;
        private UILabel Modify_ErrorLabel;
        private global::System.Windows.Forms.ListBox GameServerList;
        private UISymbolButton Register_Back_To_LoginBtn;
        private UISymbolButton Modify_Back_To_LoginBtn;
        private System.Windows.Forms.Timer InterfaceUpdateTimer;
        public UITabControl MainTab;
        public UILabel login_error_label;
        private System.Windows.Forms.Timer DataProcessTimer;
        private UISymbolButton activate_account;
        private global::System.Windows.Forms.NotifyIcon minimizeToTray;
        private global::System.Windows.Forms.ContextMenuStrip TrayRightClickMenu;
        private global::System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private global::System.Windows.Forms.ToolStripMenuItem QuitToolStripMenuItem;
        private System.Windows.Forms.Timer GameProcessTimer;
        private UILinkLabel start_selected_zone;
        private Label StartTheCurrentServerLabel;
        private UICheckBox uiCheckBox2;
        private UICheckBox uiCheckBox1;
        private UIAvatar AccountAvatar;
    }
}