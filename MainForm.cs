namespace WFA230130
{
    public partial class MainForm : Form
    {
        public ApplicationUserControl ApplicationUserControl { get; set; }
        public LogInUserControl LogInUserControl { get; set; }
        public RegistrationUserControl RegistrationUserControl { get; set; }

        public MainForm() => InitializeComponent();

        private void OnMainFormLoad(object sender, EventArgs e)
        {
            LogInUserControl = new();
            UserControlCenterAlignment(LogInUserControl);
            mainPanel.Controls.Add(LogInUserControl);
        }

        private void UserControlCenterAlignment(UserControl uc) => uc.Location = new()
        {
            X = (mainPanel.Width - uc.Width) / 2,
            Y = (mainPanel.Height - uc.Height) / 2,
        };
    }
}