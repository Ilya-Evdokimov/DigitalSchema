namespace DigitalSchema.Chips
{
    public partial class NewPage1 : ContentView
    {
        bool isEllipsePressed = false;
        public NewPage1()
        {
            InitializeComponent();
        }
        public void OnEllipseTapped(object sender, EventArgs e)
        {
            isEllipsePressed = !isEllipsePressed;
            In_1.Fill = isEllipsePressed ? Colors.Blue : Colors.Red;
        }

    }
}