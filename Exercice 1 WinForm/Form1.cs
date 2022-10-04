namespace Exercice_1_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

            if ((comboBox1.Text == "") || (txtbox_Nom.Text == "") || (txtbox_Prenom.Text == "") || (txtbox_Age.Text == ""))
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

            else
            {
                int AgeEntier = Convert.ToInt32(txtbox_Age.Text.Trim());

                MessageBox.Show("Bonjour Monsieur le Professeur, je m'appelle " + comboBox1.Text + " " + txtbox_Nom.Text + " " + txtbox_Prenom.Text + ", j'ai " + AgeEntier + " ans", "Titre", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtbox_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*try
            {
                int temp = Convert.ToInt32(txtbox_Age.Text);
            }
            catch (Exception h)
            {
                MessageBox.Show("Please provide number only");
            }
            */
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
            if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}