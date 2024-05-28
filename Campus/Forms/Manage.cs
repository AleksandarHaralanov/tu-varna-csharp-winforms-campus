namespace Campus
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void Options(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Tag)
            {
                case "create":
                    Hide();
                    new Create().Show();
                    break;
                case "view":
                    Hide();
                    new View().Show();
                    break;
                case "end":
                    Hide();
                    new Archive().Show();
                    break;
                case "change":
                    Hide();
                    new Update().Show();
                    break;
                case "pay":
                    Hide();
                    new Payment().Show();
                    break;
                default:
                    break;
            }
        }

        private void GoBack(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new Access().Show();
        }

        private void ExitApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
