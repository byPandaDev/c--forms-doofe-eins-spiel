///////////////////////////////////
//
//
//
// gameName: Doofe Eins
// version: 1.0.0
// developer: byPandaDev
//
// https://github.com/byPandaDev/csharp-forms-doofe-eins-spiel
//
//
//
///////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace DoofeEins
{
    public partial class gameScreen : Form
    {
        // Not important Variable
        string gameName = "Doofe Eins";
        int _ticks = 0;
        int delayTime = 2; // in Sekunden
        int timerInterval = 1000; // Sekunden

        // Settings
        bool isMusicPlaying = true;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer(); // Musik player

        /// <summary>
        /// Ändere den Titel des Form Fensters
        /// </summary>
        /// <param name="title">Titel der eingesetzt werden soll</param>
        private void changeTitle(string title)
        {
            this.Text = title + " - " + gameName; // Titel des Forms ändern
        }
        /// <summary>
        /// Ändere den aktuellen Spieler
        /// </summary>
        /// <param name="toPlayer">Der Spieler zu dem gewechselt werden soll</param>
        private void changePlayer(int toPlayer)
        {
            // Spieler wechseln
            if (toPlayer == 1)
            {
                playerOnePanel.Visible = true;
                playerTwoPanel.Visible = false;
                currentPlayer = 1;
            }
            else
            {
                playerOnePanel.Visible = false;
                playerTwoPanel.Visible = true;
                currentPlayer = 2;
            }
        }

        private void endGame()
        {
            // Timer starten, Punktzahl überprüfen
            timer1.Enabled = true;
            timer1.Interval = timerInterval;
            timer1.Start();
            if (currentPlayerMode == 1)
            {
                label2.Font = new Font("Alagard", 14);
                label2.Text = "Highscore: " + spielerEinsPunkte;
            }
            else
            {
                if (spielerEinsPunkte > spielerZweiPunkte)
                {
                    label2.Font = new Font("Alagard", 14);
                    label2.Text = "Spieler 1 hat gewonnen";
                }
                else if (spielerEinsPunkte < spielerZweiPunkte)
                {
                    label2.Font = new Font("Alagard", 14);
                    label2.Text = "Spieler 2 hat gewonnen";
                }
                else
                {
                    label2.Font = new Font("Alagard", 14);
                    label2.Text = "Unentschieden";
                }
            }
        }


        // Spiel Variablen
        int currentPlayerMode = 1;
        int currentPlayer = 1;
        int runden = 0;
        int currentRound = 0;
        int spielerEinsPunkte = 0;
        int rundenEinsPunkte = 0;
        int spielerZweiPunkte = 0;
        int rundenZweiPunkte = 0;
        Random dice = new Random();

        public gameScreen()
        {
            InitializeComponent();
            // Musik starten
            player.SoundLocation = @".\Minecraft.wav";  
            player.PlayLooping();
        }
        
        private void gameScreen_Load(object sender, EventArgs e)
        {
         
        }
        //////////////
        /////// Menü Knöpfe
        //////////////
        private void onePlayerButton_Click(object sender, EventArgs e)
        {
            currentPlayerMode = 1; // Anzahl Spieler setzen
            allScreens.SelectedTab = runningGameScreen; // 1 Spieler Screen auswählen
            changeTitle("1 Spieler"); // Form Titel ändern
        }
        private void twoPlayerButton_Click(object sender, EventArgs e)
        {
            currentPlayerMode = 2; // Anzahl Spieler setzen
            allScreens.SelectedTab = runningGameScreen; // 1 Spieler Screen auswählen
            changeTitle("2 Spieler"); // Form Titel ändern
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            allScreens.SelectedTab = settingsScreen;
        }
        private void tutorialButton_Click(object sender, EventArgs e)
        {
            allScreens.SelectedTab = tutorialScreen;
        }

        //////////////
        /////// Runden Auswählen
        //////////////
        private void roundInput_TextChanged(object sender, EventArgs e)
        {
            // Überprüfe ob eingabe eine Zahl ist
            if (!int.TryParse(roundInput.Text, out runden))
            {
                roundInput.Text = runden.ToString();
                return;
            }
            // Runden in Variable speichern
            runden = Convert.ToInt32(roundInput.Text);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Wenn Rundeneingabe zwischen 1 und 100 liegt, spiel Starten
            if (runden > 0 && runden <= 100)
            {
                roundGroup.Visible = false;
                gamePanel.Visible = true;
            }
        }

        //////////////
        /////// Spiel Screen
        //////////////
        private void gamePanel_VisibileChange(object sender, EventArgs e)
        {
            if (gamePanel.Visible)
            {
                // Rundenanzeige festlegen
                allRounds.Text = currentRound + "/" + runden;
                playerOnePanel.Visible = true;
                // Punkte zurücksetzen
                spielerEinsPunkte = 0;
                spielerZweiPunkte = 0;
            }
            else
            {
                label2.Font = new Font("Alagard", 20);
                label2.Text = "Runden";
            }
            
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            int numb = dice.Next(1, 7); // Würfel eine Zahl
            if (currentRound <= runden)
            {
                if (currentPlayerMode == 1)
                {
                    if (numb == 1)
                    {
                        // Wenn 1 dann normale Punkte zurücksetzen und runde erhöhen
                        spielerEinsPunkte = 0;
                        playerOnePoints.Text = "RP: " + spielerEinsPunkte.ToString();
                        currentRound++;
                        allRounds.Text = currentRound + "/" + runden;
                        if (currentRound == runden)
                        {
                            label2.Font = new Font("Alagard", 14);
                            label2.Text = "Highscore: " + rundenEinsPunkte;
                            rollDiceButton.Visible = false;
                            exposeButton.Visible = false;
                            timer1.Enabled = true;
                            timer1.Interval = timerInterval;
                            timer1.Start();
                        }
                        return;
                    }
                    spielerEinsPunkte += numb;
                    playerOnePoints.Text = "RP: " + spielerEinsPunkte.ToString();
                }
                else
                {
                    if (currentPlayer == 1)
                    {
                        if (numb == 1)
                        {
                            // Wenn 1 dann normale Punkte zurücksetzen und anderer Spieler
                            rollDiceButton.Visible = false;
                            exposeButton.Visible = false;
                            spielerEinsPunkte = 0;
                            playerOnePoints.Text = "RP: " + spielerEinsPunkte.ToString();
                            timer1.Enabled = true;
                            timer1.Interval = timerInterval;
                            timer1.Start();
                            return;
                        }
                        // Punkte Spieler 1 anzeigen
                        spielerEinsPunkte += numb;
                        playerOnePoints.Text = "RP: " + spielerEinsPunkte.ToString();
                    }
                    else
                    {
                        if (numb == 1)
                        {
                            // Wenn 1 dann normale Punkte zurücksetzen und runde erhöhen und anderer Spieler
                            rollDiceButton.Visible = false;
                            exposeButton.Visible = false;
                            spielerZweiPunkte = 0;
                            playerTwoPoints.Text = "RP: " + spielerZweiPunkte.ToString();
                            timer1.Enabled = true;
                            timer1.Interval = timerInterval;
                            timer1.Start();
                            currentRound++;
                            allRounds.Text = currentRound + "/" + runden;
                            if (currentRound == runden)
                            {
                                // Anzeigen wer gewonnen hat
                                label2.Font = new Font("Alagard", 14);
                                if (spielerEinsPunkte > spielerZweiPunkte) label2.Text = "Spieler 1 gewinnt mit: " + rundenEinsPunkte;
                                else if (spielerEinsPunkte < spielerZweiPunkte) label2.Text = "Spieler 2 gewinnt mit: " + rundenZweiPunkte;
                                else label2.Text = "Unentschieden";
                            }
                            return;
                        }
                        // Punkte Spieler 2 anzeigen
                        spielerZweiPunkte += numb;
                        playerTwoPoints.Text = "RP: " + spielerZweiPunkte.ToString();
                        
                    }
                }
                return;
            }
            // Spiel beenden
            rollDiceButton.Visible = false;
            exposeButton.Visible = false;
            label2.Font = new Font("Alagard", 14);
            if (spielerEinsPunkte > spielerZweiPunkte) label2.Text = "Spieler 1 gewinnt mit: " + spielerEinsPunkte;
            else if (spielerEinsPunkte < spielerZweiPunkte) label2.Text = "Spieler 2 gewinnt mit: " + spielerZweiPunkte;
            else label2.Text = "Unentschieden";
            
            
             
        }

        private void exposeButton_Click(object sender, EventArgs e)
        {
            // +0 zu den Punkten des derzeitigen Spielers und Spieler wechseln
            if (currentRound <= runden)
            {
                if (currentPlayerMode == 1)
                {
                    rundenEinsPunkte += spielerEinsPunkte;
                    spielerEinsPunkte = 0;
                    playerOnePoints.Text = "RP: " + spielerEinsPunkte.ToString();
                    onePlayerAllPoints.Text = "AP: " + rundenEinsPunkte.ToString();
                    currentRound++;
                    allRounds.Text = currentRound + "/" + runden;
                }
                else
                {
                    if (currentPlayer == 1)
                    {
                        rundenEinsPunkte += spielerEinsPunkte;
                        spielerEinsPunkte = 0;
                        playerOnePoints.Text = "RP: " + spielerEinsPunkte.ToString();
                        onePlayerAllPoints.Text = "AP: " + rundenEinsPunkte.ToString();
                        timer1.Enabled = true;
                        timer1.Interval = timerInterval;
                        timer1.Start();
                        rollDiceButton.Visible = false;
                        exposeButton.Visible = false;
                    }
                    else
                    {
                        rundenZweiPunkte += spielerZweiPunkte;
                        spielerZweiPunkte = 0;
                        playerTwoPoints.Text = "RP: " + spielerZweiPunkte.ToString();
                        twoPlayerAllPoints.Text = "AP: " + rundenZweiPunkte.ToString();
                        currentRound++;
                        allRounds.Text = currentRound + "/" + runden;
                        timer1.Enabled = true;
                        timer1.Interval = timerInterval;
                        timer1.Start();
                        rollDiceButton.Visible = false;
                        exposeButton.Visible = false;
                    }
                }

            }
            else
            {
                // Spiel beenden
                endGame();
            }
        }

        

        private void cancelButton_Click(object sender, EventArgs e)
        {
            allScreens.SelectedTab = menuScreen; // Wechsel zu menu
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            allScreens.SelectedTab = menuScreen; // Wechsel zu menu
        }

        private void playMuteMusic_Click(object sender, EventArgs e)
        {
            // Überprüfe ob Musik spielt
            if (isMusicPlaying)
            {
                player.Stop();
                playMuteMusic.Text = "Aus";
            }
            else
            {
                player.PlayLooping();
                playMuteMusic.Text = "An";
            }
            isMusicPlaying = !isMusicPlaying;
        }

        // Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks >= delayTime)
            {
                if (currentRound < runden)
                {
                    if (currentPlayerMode == 1)
                    {
                    }
                    else
                    {
                        if (currentPlayer == 1) changePlayer(2);
                        else changePlayer(1);
                        rollDiceButton.Visible = true;
                        exposeButton.Visible = true;
                    }
                }
                else
                {
                    
                    // ALLES ZURÜCKSETZTEN
                    allScreens.SelectedTab = menuScreen;
                    label2.Font = new Font("Alagard", 20);
                    label2.Text = "Runden";
                    rollDiceButton.Visible = true;
                    exposeButton.Visible = true;
                    currentRound = 1;
                    runden = 1;
                    roundGroup.Visible = true;
                    gamePanel.Visible = false;
                    spielerEinsPunkte = 0;
                    spielerZweiPunkte = 0;
                    playerOnePoints.Text = "RP: 0";
                    onePlayerAllPoints.Text = "AP: 0";
                    playerTwoPoints.Text = "RP: 0";
                    twoPlayerAllPoints.Text = "AP: 0";
                }
                // Timer stoppen
                timer1.Stop();
                timer1.Enabled = false;
            }
        }
        
    }
}
