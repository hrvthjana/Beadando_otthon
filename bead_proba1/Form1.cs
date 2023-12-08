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
            if (MessageBox.Show("Az alkot�s minden r�szlet�t gondosan terveztem �s kidolgoztam, hogy a felhaszn�l�k sz�m�ra k�nyelmes �s �rt�kes �lm�nyt ny�jtsak. Csal�d�st okoz, amikor az emberek gyorsan z�rj�k be az alkalmaz�st, mert �gy �rzem, mintha nem �rt�keln�k az �ltalam beletett rengeteg id�t, energi�t �s odafigyel�st. Emiatt felmer�l bennem a csal�dotts�g �rz�se, mert v�rtam, hogy az alkot�som jobban �rt�kelve legyen, �s hogy a felhaszn�l�k fedezz�k fel azt az apr� r�szleteket, melyekre annyit �ldoztam. Ennek ellen�re igyekszem f�kusz�lni az alkot�s �r�m�re �s azon pozit�v visszajelz�sekre, amelyeket azokt�l kapok, akik �rt�kelik a munk�m.", "Kil�p�s az alkalmaz�sb�l", MessageBoxButtons.YesNo) != DialogResult.Yes)
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