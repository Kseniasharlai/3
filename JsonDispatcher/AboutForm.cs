namespace JsonDispatcher
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            lblAboutInfo.Text = "Про програму\nАвтор: Шарлай Ксенія \nКурс: 2\nГруппа: К-24\nРік: 2024\nОпис: Обробка файлів у форматі JSON";
            lblAboutInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblAboutInfo.Font = new Font("Arial", 12, FontStyle.Bold);
        }
    }
}