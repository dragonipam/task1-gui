namespace task1_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int penny;
            try
            {
                penny = int.Parse(this.txtPenny.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("������������ ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(Logic.�alculation(penny));
        }
    }
    public class Logic
    {
        public static string �ompletionRuble(int ruble)
        {
            String endRuble = "";
            if (ruble % 10 == 1)
            {
                endRuble = " ����� ";
            }
            else if (ruble % 10 <= 4)
            {
                endRuble = " ����� ";
            }
            else
            {
                endRuble = " ������ ";
            }
            return endRuble;
        }
        public static string �ompletionPenny(int penny)
        {
            String endPenny = "";
            if (penny % 10 == 1)
            {
                endPenny = " �������";
            }
            else if (penny % 10 <= 4)
            {
                endPenny = " �������";
            }
            else
            {
                endPenny = " ������";
            }
            return endPenny;
        }
        public static string �alculation(int ruble)
        {
            string outMessage = "";
            int penny = ruble % 100;
            ruble /= 100;
            if (penny == 0)
            {
                outMessage = ruble + �ompletionRuble(ruble);
            }
            else if (ruble < 1)
            {
                outMessage = penny + �ompletionPenny(penny);
            }
            else
            {
                outMessage = ruble + �ompletionRuble(ruble) + penny + �ompletionPenny(penny);
            }
            return outMessage;
        }
    }
}