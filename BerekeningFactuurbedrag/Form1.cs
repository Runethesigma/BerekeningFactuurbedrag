namespace BerekeningFactuurbedrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BerekenButton_Click(object sender, EventArgs e)
        {
            double Inkoopprijs = Convert.ToDouble(InkoopprijsTextBox.Text);
            double Winstmarge = Convert.ToDouble(WinstmargeTextBox.Text);
            double Resultaat = Inkoopprijs + (Inkoopprijs * Winstmarge);
            double ResultaatNaBtw = Resultaat * 1.21;
            ResultaatTextBox.Text = Convert.ToString(ResultaatNaBtw);
        }

        /*==========Analyse==========
1. Invoer: Welke invoer mag ik verwachten? Geef zowel een naam/beschrijving als een datatype.
        De Inkoopprijs en het Winstmarge deze zijn int variables
2. Bewerking: Welke formule heb je nodig om het totaal te berekenen waarbij zowel een winstmarge als een BTW percentage wordt toegevoegd?
        Resultaat = Inkoopprijs + (Inkoopprijs * Winstmarge) + resultaat * 0.21
3. Uitvoer: Welk resultaat zal je bekomen? Geef zowel een naam/beschrijving als een datatype.
        De totale prijs waarvoor hij het prosuct verkoopt dit is een int variable

==========Testdata=========

4. Testdata: Verzin en noteer testgegevens, en bereken met je rekenmachine de juiste oplossing. Zo weet je of je oefening klopt.
        Inkoopprijs 456
        Winstmarge 0,4
        Totaal 772,46
===========================*/
    }
}
