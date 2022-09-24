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
                MessageBox.Show("Íåêîğğåêòíûé ââîä", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(Logic.Ñalculation(penny));
        }
    }
    public class Logic
    {
        public static string ÑompletionRuble(int ruble)
        {
            String endRuble = "";
            if (ruble % 10 == 1)
            {
                endRuble = " ğóáëü ";
            }
            else if (ruble % 10 <= 4)
            {
                endRuble = " ğóáëÿ ";
            }
            else
            {
                endRuble = " ğóáëåé ";
            }
            return endRuble;
        }
        public static string ÑompletionPenny(int penny)
        {
            String endPenny = "";
            if (penny % 10 == 1)
            {
                endPenny = " êîïåéêà";
            }
            else if (penny % 10 <= 4)
            {
                endPenny = " êîïåéêè";
            }
            else
            {
                endPenny = " êîïååê";
            }
            return endPenny;
        }
        public static string Ñalculation(int ruble)
        {
            string outMessage = "";
            int penny = ruble % 100;
            ruble /= 100;
            if (penny == 0)
            {
                outMessage = ruble + ÑompletionRuble(ruble);
            }
            else if (ruble < 1)
            {
                outMessage = penny + ÑompletionPenny(penny);
            }
            else
            {
                outMessage = ruble + ÑompletionRuble(ruble) + penny + ÑompletionPenny(penny);
            }
            return outMessage;
        }
    }
}