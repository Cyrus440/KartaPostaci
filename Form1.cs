namespace KartaPostaci
{
    public partial class Form1 : Form
    {
        List<KartaPostaci> playerList;
        int currentSheet;
        public Form1()
        {
            InitializeComponent();
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
            string updateName; // = UpdateNameTextBox.Text;
            if(UpdateNameTextBox.Text.Equals(""))
            {
                updateName = playerList[currentSheet].name;
            }
            else
            {
                updateName = UpdateNameTextBox.Text;
            }
            string updateRace; // = UpdateRaceTextBox.Text;
            if (UpdateRaceTextBox.Text.Equals(""))
            {
                updateRace = playerList[currentSheet].race;
            }
            else
            {
                updateRace=UpdateRaceTextBox.Text;
            }
            string updateProffesion;// = UpdateProfessionTextBox.Text;
            if(UpdateProfessionTextBox.Text.Equals(""))
            {
                updateProffesion = playerList[currentSheet].profession;
            }
            else
            {
                updateProffesion = UpdateProfessionTextBox.Text;
            }
            int updateStrength; // = Convert.ToInt32(UpdatedStrengthTextBox.Text);
            if(UpdatedStrengthTextBox.Text.Equals(""))
            {
                updateStrength = playerList[currentSheet].strength;

            }
            else
            {
                updateStrength = Convert.ToInt32(UpdatedStrengthTextBox.Text);
            }
            int updateAgility; // = Convert.ToInt32(UpdatedAgilityTextBox.Text);
            if (UpdatedAgilityTextBox.Text.Equals(""))
            {
                updateAgility = playerList[currentSheet].agility;

            }
            else
            {
                updateAgility = Convert.ToInt32(UpdatedAgilityTextBox.Text);
            }
            int updatePerception; // = Convert.ToInt32(UpdatedPerceptionTextBox.Text);
            if (UpdatedPerceptionTextBox.Text.Equals(""))
            {
                updatePerception = playerList[currentSheet].perception;

            }
            else
            {
                updatePerception = Convert.ToInt32(UpdatedPerceptionTextBox.Text);
            }
            int updateStealth; // = Convert.ToInt32(UpdatedStealthTextBox.Text);
            if (UpdatedStealthTextBox.Text.Equals(""))
            {
                updateStealth = playerList[currentSheet].stealth;

            }
            else
            {
                updateStealth = Convert.ToInt32(UpdatedStealthTextBox.Text);
            }
            playerList[currentSheet].name = updateName;
            playerList[currentSheet].race = updateRace;
            playerList[currentSheet].profession = updateProffesion;
            playerList[currentSheet].strength = updateStrength;
            playerList[currentSheet].agility = updateAgility;
            playerList[currentSheet].perception = updatePerception;
            playerList[currentSheet].stealth = updateStealth;
            displayCurrentCharacterSheet();
            CharacterList.Items.Add(playerList[currentSheet].name);
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            if (currentSheet== 0)
            {
                currentSheet = playerList.Count;
            }
            currentSheet--;
            displayCurrentCharacterSheet();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {  
            currentSheet = (currentSheet+1)% playerList.Count;
            displayCurrentCharacterSheet();
        }

        private void AddSheetButton_Click(object sender, EventArgs e)
        {
            currentSheet = playerList.Count;
            playerList.Add(new KartaPostaci());
            playerList[currentSheet].id = playerList.Count;
            displayCurrentCharacterSheet();
        }

        private void DeleteSheetButton_Click(object sender, EventArgs e)
        {
            if(playerList.Count > 1 && currentSheet != 0)
            {
                playerList.RemoveAt(currentSheet);
                currentSheet--;
            }
            else if(playerList.Count > 1 && currentSheet ==0)
            {
                playerList.RemoveAt(currentSheet);
            }
            displayCurrentCharacterSheet();
        }

        public void displayCurrentCharacterSheet()
        {
            if (currentSheet >= 0 && currentSheet < playerList.Count)
            {
                CurrentNameTextBox.Text = playerList[currentSheet].name;
                CurrentRaceTextBox.Text = playerList[currentSheet].race;
                CurrentProfessionTextBox.Text = playerList[currentSheet].profession;
                CurrentStrengthTextBox.Text = playerList[currentSheet].strength.ToString();
                CurrentAgilityTextBox.Text = playerList[currentSheet].agility.ToString();
                CurrentPerceptionTextBox.Text = playerList[currentSheet].perception.ToString();
                CurrentStealthTextBox.Text = playerList[currentSheet].stealth.ToString();
                displayInformationLabel.Text = "Karta " + (currentSheet + 1).ToString() + " z " + playerList.Count;
                clearForm();
            }
            
        }
        public void clearForm()
        {
            UpdateNameTextBox.Text = "";
            UpdateRaceTextBox.Text = "";
            UpdateProfessionTextBox.Text = "";
            UpdatedStrengthTextBox.Text = "";
            UpdatedAgilityTextBox.Text = "";
            UpdatedPerceptionTextBox.Text = "";
            UpdatedStealthTextBox.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StrengthRollButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int wynik = rnd.Next(1, 101);
            if (wynik <= playerList[currentSheet].strength)
            {
                ResultTextBox.Text = "Wyrzucono " + wynik.ToString() + " na " + playerList[currentSheet].strength.ToString() + ". Sukces";
            }
            else
            {
                ResultTextBox.Text = "Wyrzucono " + wynik.ToString() + " na " + playerList[currentSheet].strength.ToString() + ". Pora¿ka";
            }
        }

        private void AgilityRollButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int wynik = rnd.Next(1, 101);
            if (wynik <= playerList[currentSheet].agility)
            {
                ResultTextBox.Text = "Wyrzucono " + wynik.ToString() + " na " + playerList[currentSheet].agility.ToString() + ". Sukces";
            }
            else
            {
                ResultTextBox.Text = "Wyrzucono " + wynik.ToString() + " na " + playerList[currentSheet].agility.ToString() + ". Pora¿ka";
            }
        }

        private void PerceptionRollButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int wynik = rnd.Next(1, 11);
            if (wynik <= playerList[currentSheet].perception)
            {
                ResultTextBox.Text = "Wyrzucono " + wynik.ToString() + " na " + playerList[currentSheet].perception.ToString() + ". Sukces";
            }
            else
            {
                ResultTextBox.Text = "Wyrzucono " + wynik.ToString() + " na " + playerList[currentSheet].perception.ToString() + ". Pora¿ka";
            }
        }

        private void StealthRollButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int wynik = rnd.Next(1, 11);
            if (wynik <= playerList[currentSheet].stealth)
            {
                ResultTextBox.Text = "Wyrzucono " + wynik.ToString() + " na " + playerList[currentSheet].stealth.ToString() + ". Sukces";
            }
            else
            {
                ResultTextBox.Text = "Wyrzucono " + wynik.ToString() + " na " + playerList[currentSheet].stealth.ToString() + ". Pora¿ka";
            }
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int nowasila = rnd.Next(22, 41);
            int nowazwinnosc = rnd.Next(22, 41);
            int nowapercepcja = rnd.Next(2, 6);
            int noweskradanie = rnd.Next(2, 6);
            playerList[currentSheet].strength = nowasila;
            playerList[currentSheet].agility = nowazwinnosc;
            playerList[currentSheet].perception = nowapercepcja;
            playerList[currentSheet].stealth = noweskradanie;
            displayCurrentCharacterSheet();
        }

        private void MailButton_Click(object sender, EventArgs e)
        {

        }
        public static void CreateMessage(string serwer)
        {
     
        }

        private void StrengthSortButton_Click(object sender, EventArgs e)
        {
            playerList.Sort((x, y) => y.strength.CompareTo(x.strength));
            displayCurrentCharacterSheet();
        }

        private void AgilitySortButton_Click(object sender, EventArgs e)
        {
            playerList.Sort((x, y) => y.agility.CompareTo(x.agility));
            displayCurrentCharacterSheet();
        }

        private void PerceptionSortButton_Click(object sender, EventArgs e)
        {
            playerList.Sort((x, y) => y.perception.CompareTo(x.perception));
            displayCurrentCharacterSheet();
        }

        private void StealthSortButton_Click(object sender, EventArgs e)
        {
            playerList.Sort((x, y) => y.stealth.CompareTo(x.stealth));
            displayCurrentCharacterSheet();
        }

        private void OpposedStrengthButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int wynik1 = rnd.Next(1, 101);
            int wynik2 = rnd.Next(1, 101);
            var othercharacter = playerList.FindIndex(i =>i.name == CharacterList.SelectedItem.ToString());
            int stopniesukcesu1;
            int stopniesukcesu2;
            stopniesukcesu1 = (playerList[currentSheet].strength - wynik1)/10;
            stopniesukcesu2 = (playerList[othercharacter].strength - wynik2) / 10;
            if (stopniesukcesu1 > stopniesukcesu2)
            {
                int difference = stopniesukcesu1 - stopniesukcesu2;
                ResultTextBox.Text = "Wygra³/a " + playerList[currentSheet].name + " o " + difference + " stopieñ/stopnie";
            }
            else if(stopniesukcesu2 > stopniesukcesu1)
            {
                int difference = stopniesukcesu2 - stopniesukcesu1;
                ResultTextBox.Text = "Wygra³/a " + playerList[othercharacter].name + " o " + difference + " stopieñ/stopnie";
            }
            else if(stopniesukcesu1 == stopniesukcesu2)
            {
                ResultTextBox.Text = playerList[currentSheet].name + " zremisowa³/a z " + playerList[othercharacter].name;
            }
        }

        private void OpposedAgilityButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int wynik1 = rnd.Next(1, 101);
            int wynik2 = rnd.Next(1, 101);
            var othercharacter = playerList.FindIndex(i => i.name == CharacterList.SelectedItem.ToString());
            int stopniesukcesu1;
            int stopniesukcesu2;
            stopniesukcesu1 = (playerList[currentSheet].agility - wynik1) / 10;
            stopniesukcesu2 = (playerList[othercharacter].agility - wynik2) / 10;
            if (stopniesukcesu1 > stopniesukcesu2)
            {
                int difference = stopniesukcesu1 - stopniesukcesu2;
                ResultTextBox.Text = "Wygra³/a " + playerList[currentSheet].name + " o " + difference + " stopieñ/stopnie";
            }
            else if (stopniesukcesu2 > stopniesukcesu1)
            {
                int difference = stopniesukcesu2 - stopniesukcesu1;
                ResultTextBox.Text = "Wygra³/a " + playerList[othercharacter].name + " o " + difference + " stopieñ/stopnie";
            }
            else if (stopniesukcesu1 == stopniesukcesu2)
            {
                ResultTextBox.Text = playerList[currentSheet].name + " zremisowa³/a z " + playerList[othercharacter].name;
            }
        }

        private void OpposedPerceptionButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int wynik1 = rnd.Next(1, 11);
            int wynik2 = rnd.Next(1, 11);
            var othercharacter = playerList.FindIndex(i => i.name == CharacterList.SelectedItem.ToString());
            int stopniesukcesu1;
            int stopniesukcesu2;
            stopniesukcesu1 = (playerList[currentSheet].perception - wynik1);
            stopniesukcesu2 = (playerList[othercharacter].perception - wynik2);
            if (stopniesukcesu1 > stopniesukcesu2)
            {
                int difference = stopniesukcesu1 - stopniesukcesu2;
                ResultTextBox.Text = "Wygra³/a " + playerList[currentSheet].name + " o " + difference + " stopieñ/stopnie";
            }
            else if (stopniesukcesu2 > stopniesukcesu1)
            {
                int difference = stopniesukcesu2 - stopniesukcesu1;
                ResultTextBox.Text = "Wygra³/a " + playerList[othercharacter].name + " o " + difference + " stopieñ/stopnie";
            }
            else if (stopniesukcesu1 == stopniesukcesu2)
            {
                ResultTextBox.Text = playerList[currentSheet].name + " zremisowa³/a z " + playerList[othercharacter].name;
            }
        }

        private void OpposedStealthButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int wynik1 = rnd.Next(1, 11);
            int wynik2 = rnd.Next(1, 11);
            var othercharacter = playerList.FindIndex(i => i.name == CharacterList.SelectedItem.ToString());
            int stopniesukcesu1;
            int stopniesukcesu2;
            stopniesukcesu1 = (playerList[currentSheet].stealth - wynik1);
            stopniesukcesu2 = (playerList[othercharacter].stealth - wynik2);
            if (stopniesukcesu1 > stopniesukcesu2)
            {
                int difference = stopniesukcesu1 - stopniesukcesu2;
                ResultTextBox.Text = "Wygra³/a " + playerList[currentSheet].name + " o " + difference + " stopieñ/stopnie";
            }
            else if (stopniesukcesu2 > stopniesukcesu1)
            {
                int difference = stopniesukcesu2 - stopniesukcesu1;
                ResultTextBox.Text = "Wygra³/a " + playerList[othercharacter].name + " o " + difference + " stopieñ/stopnie";
            }
            else if (stopniesukcesu1 == stopniesukcesu2)
            {
                ResultTextBox.Text = playerList[currentSheet].name + " zremisowa³/a z " + playerList[othercharacter].name;
            }
        }
    }
}