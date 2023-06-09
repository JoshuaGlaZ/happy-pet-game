namespace testProject
{
    public partial class Form1 : Form
    {
        cat kochengBaik, kochengJahat;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            cat kocheng = new cat(textBoxName.Text);
            kochengBaik = kocheng;
            listBox1.Items.Add(kocheng.Name + " telah join battle");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            listBox1.Items.Add("ready ? GO !");
            listBox1.Items.Add("new enemy approaching");
            cat oren = new cat("Orenz");
            for (int i = 0; i < 10; i++) { oren.levelUp(); }
            kochengJahat = oren;
            listBox1.Items.AddRange(oren.display().Split('\n'));
            listBox1.Items.Add("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kochengBaik.basic(kochengJahat);
            listBox1.Items.Add(kochengBaik.Name + " memberi "+ (kochengBaik.Attack-kochengJahat.Defense) + " damage");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kochengBaik.skill();
            listBox1.Items.Add("attack " + kochengBaik.Name + " meningkat");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                kochengBaik.ulti(kochengJahat);
            }
            catch(Exception ex) { listBox1.Items.Add(ex.Message); }
        }
    }
}