namespace Chronomètre
{
    public partial class Form1 : Form
    {
        int sec = 0; //Initialisation du comptage au démarrage de l'application

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            sec++; // Incrémentation du compteur, attention tient compte de l'intervalle de temps du timer1
            TimeSpan time = TimeSpan.FromSeconds(sec); //Conversion du nombre de secondes au format time
            label1.Text = time.ToString("hh\\:mm\\:ss"); //Conversion en string avec définition du format d'affichage
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
            {
                //Définition de l'action du bouton si le timer1 est en cours d'exécution
                timer1.Stop();
                button1.Text = "START";
            }
            else
            {
                //Définition de l'action du bouton si le timer1 est à l'arrêt
                timer1.Start();
                button1.Text = "STOP";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Initialisation du compteur à 0 et affichage de la valeur sous le bon format
            sec = 0;
            TimeSpan time = TimeSpan.FromSeconds(sec);
            label1.Text = time.ToString("hh\\:mm\\:ss");
        }
    }
}
