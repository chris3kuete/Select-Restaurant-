namespace Restaurant_Selector__chap_4_ass_10ec_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (VegetarianCb.Checked && !VeganCb.Checked && !GlutenCb.Checked)
            {
                restaurantsLb.Items.Add("Main Street Pizza Company");
                restaurantsLb.Items.Add("Corner Cafe");
                restaurantsLb.Items.Add("Chef's Kitchen");
                restaurantsLb.Items.Add("Mama's Fine Italian");

            }
            else if (VeganCb.Checked && !VegetarianCb.Checked && !GlutenCb.Checked)
            {
                restaurantsLb.Items.Add("Corner Cafe");
                restaurantsLb.Items.Add("The Chef's kitchen");

            }
            else if (GlutenCb.Checked && !VegetarianCb.Checked && !VeganCb.Checked)
            {
                restaurantsLb.Items.Add("Main Street Pizza Company");
                restaurantsLb.Items.Add("Corner Cafe");
                restaurantsLb.Items.Add("The Chef's Kitchen");

            }
            else if (VegetarianCb.Checked && VeganCb.Checked)
            {
                restaurantsLb.Items.Add("Corner Cafe");
                restaurantsLb.Items.Add("The Chef's Kitchen");

            }
            else if (VegetarianCb.Checked && GlutenCb.Checked)
            {
                restaurantsLb.Items.Add("Main Street Pizza Company");
                restaurantsLb.Items.Add("Corner Cafe");
                restaurantsLb.Items.Add("The Chef's Kitchen");


            }else if (VeganCb.Checked && GlutenCb.Checked)
            {
                restaurantsLb.Items.Add("Corner Cafe");
                restaurantsLb.Items.Add("The Chef's Kitchen");
            }
            else if (VegetarianCb.Checked && VeganCb.Checked && GlutenCb.Checked)
            {
                restaurantsLb.Items.Add("Corner Cafe");
                restaurantsLb.Items.Add("The Chief's Kitchen");
            }
            else
            {
                restaurantsLb.Items.Add("No Box Checked");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
