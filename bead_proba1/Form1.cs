namespace bead_proba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Az alkotás minden részletét gondosan terveztem és kidolgoztam, hogy a felhasználók számára kényelmes és értékes élményt nyújtsak. Csalódást okoz, amikor az emberek gyorsan zárják be az alkalmazást, mert úgy érzem, mintha nem értékelnék az általam beletett rengeteg idõt, energiát és odafigyelést. Emiatt felmerül bennem a csalódottság érzése, mert vártam, hogy az alkotásom jobban értékelve legyen, és hogy a felhasználók fedezzék fel azt az apró részleteket, melyekre annyit áldoztam. Ennek ellenére igyekszem fókuszálni az alkotás örömére és azon pozitív visszajelzésekre, amelyeket azoktól kapok, akik értékelik a munkám.", "Kilépés az alkalmazásból", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void uc1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void uc2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 userControl2 = new UserControl2();
            panel1.Controls.Add(userControl2);
            userControl2.Dock = DockStyle.Fill;
        }

        private void uc3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
        }

       
    }
}