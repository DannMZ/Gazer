namespace Gazer
{
    public partial class Form1 : Form
    {
        gazer gaz;
        building building1;
        building building2;
        building building3;
        public Form1()
        {
            building1 = new building("Котеж");
            building2 = new building("Чотириповерхівка");
            building3 = new building("Будівля");
            gaz = new gazer();
            InitializeComponent();
            label1.Text = "Все ще нічого немає";
            label2.Text = "Все ще нічого немає";
            label3.Text = "Все ще нічого немає";
            timer1.Enabled = true;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            gaz.build();
            label1.Text = building1.whts_up();
            label2.Text = building2.whts_up();
            label3.Text = building3.whts_up();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gaz.add_if_not_exist(building1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gaz.add_if_not_exist(building2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gaz.add_if_not_exist(building3);
        }
    }
}