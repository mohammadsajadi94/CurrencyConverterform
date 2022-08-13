using System.ComponentModel.DataAnnotations;

namespace CurrencyConverterform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum Currency
        {
            [Display(Name = "دلار آمریکا")]
            USD = 1,
            [Display(Name = "دلار کانادا")]
            CAD = 2,
            [Display(Name = "پوند")]
            GBP = 3,
            [Display(Name = "یورو")]
            EUR = 4
        }
        ICurrencyConverter convert = CurrencyConverter.GetInstance;
        private void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<Tuple<string, string, double>> tuplesCurrency = new List<Tuple<string, string, double>>()
            { new Tuple<string, string, double>("USD", "CAD", 1.34) ,new Tuple<string, string, double>("CAD", "GBP", 0.58),
                new Tuple<string, string, double>("USD", "EUR", 0.86)};
            convert.UpdateConfiguration(tuplesCurrency);
            textBox3.ReadOnly=true;
            foreach (var item in Enum.GetValues(typeof(Currency)))
            {
                comboBoxfrom.Items.Add(item);
                comboBoxto.Items.Add(item);
            }
        }

        private void Btnexchange_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=null&&comboBoxfrom.SelectedItem!=null&& comboBoxto.SelectedItem != null && 
                System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[0-9.]"))
            {
              textBox3.Text=convert.Convert(comboBoxfrom.Text, comboBoxto.Text, Convert.ToDouble(textBox1.Text)).ToString();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            convert.ClearConfiguration();
        }
    }
}