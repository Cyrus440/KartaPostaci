namespace KartaPostaci
{
    public partial class Form1 : Form
    {
        KartaPostaci someCharacter;
        List<KartaPostaci> playerList;
        int currentSheet;
        public Form1()
        {
            InitializeComponent();
            someCharacter = new KartaPostaci();
            playerList = new List<KartaPostaci>();
            playerList.Add(new KartaPostaci());
            currentSheet = 0;
            displayCurrentCharacterSheet();
        }

        private void CharacterRace_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            displayCurrentCharacterSheet();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            displayCurrentCharacterSheet();

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            displayCurrentCharacterSheet();
        }

        private void AddSheetButton_Click(object sender, EventArgs e)
        {
            displayCurrentCharacterSheet();
        }

        private void DeleteSheetButton_Click(object sender, EventArgs e)
        {
            displayCurrentCharacterSheet();
        }

        public void displayCurrentCharacterSheet()
        {
            CurrentNameTextBox.Text = playerList[currentSheet].name;
            CurrentRaceTextBox.Text = playerList[currentSheet].race;
            CurrentProfessionTextBox.Text = playerList[currentSheet].profession;
            displayInformationLabel.Text = "Karta " + (currentSheet+1).ToString() + " z " + playerList.Count;
        }
    }
}