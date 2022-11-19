using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using PlayingCards;

namespace _21Points
{
    public partial class MainForm : Form
    {
        Image backgroundFon;
        Image backCard;

        SoundPlayer SoundCard = new SoundPlayer("Sound1.wav");
        SoundPlayer SoundWin = new SoundPlayer("win.wav");
        SoundPlayer SoundGameOver = new SoundPlayer("go.wav");
        SoundPlayer SoundClick = new SoundPlayer("clk.wav");


        struct PlayerCard
        {
            public PictureBox pictureBox;
            public Card card;

            public void View()
            {
                this.pictureBox.Image = card.image;
            }

            public void Clear()
            {
                this.pictureBox.Image = null;
            }

            public PlayerCard(ref PictureBox pictureBox, Card card)
            {
                this.pictureBox = pictureBox;
                this.pictureBox.Image = null;
                this.card = card;
            }
        };

        PlayerCard[] playerCards = new PlayerCard[8];
        PlayerCard[] rivalCards = new PlayerCard[8];
        private int indexViewCard = -1;
        private int indexViewCardRival = -1;

        List<Card> DeckCards = new List<Card>();

        public int Money = 1000;
        public int bet = 100;

        private int LocalScore = 0;
        private int rivalScore = 0;
        
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void Load_()
        {
            // load card image
            {
                switch (Properties.Settings.Default.card_cover_number)
                {
                    case 0:

                        Card.C_Ace.image = Properties.Resources.Club01;
                        Card.C_2.image = Properties.Resources.Club02;
                        Card.C_3.image = Properties.Resources.Club03;
                        Card.C_4.image = Properties.Resources.Club04;
                        Card.C_5.image = Properties.Resources.Club05;
                        Card.C_6.image = Properties.Resources.Club06;
                        Card.C_7.image = Properties.Resources.Club07;
                        Card.C_8.image = Properties.Resources.Club08;
                        Card.C_9.image = Properties.Resources.Club09;
                        Card.C_10.image = Properties.Resources.Club10;
                        Card.C_Jack.image = Properties.Resources.Club11;
                        Card.C_Queen.image = Properties.Resources.Club12;
                        Card.C_King.image = Properties.Resources.Club13;

                        Card.S_Ace.image = Properties.Resources.Spade01;
                        Card.S_2.image = Properties.Resources.Spade02;
                        Card.S_3.image = Properties.Resources.Spade03;
                        Card.S_4.image = Properties.Resources.Spade04;
                        Card.S_5.image = Properties.Resources.Spade05;
                        Card.S_6.image = Properties.Resources.Spade06;
                        Card.S_7.image = Properties.Resources.Spade07;
                        Card.S_8.image = Properties.Resources.Spade08;
                        Card.S_9.image = Properties.Resources.Spade09;
                        Card.S_10.image = Properties.Resources.Spade10;
                        Card.S_Jack.image = Properties.Resources.Spade11;
                        Card.S_Queen.image = Properties.Resources.Spade12;
                        Card.S_King.image = Properties.Resources.Spade13;

                        Card.H_Ace.image = Properties.Resources.Heart01;
                        Card.H_2.image = Properties.Resources.Heart02;
                        Card.H_3.image = Properties.Resources.Heart03;
                        Card.H_4.image = Properties.Resources.Heart04;
                        Card.H_5.image = Properties.Resources.Heart05;
                        Card.H_6.image = Properties.Resources.Heart06;
                        Card.H_7.image = Properties.Resources.Heart07;
                        Card.H_8.image = Properties.Resources.Heart08;
                        Card.H_9.image = Properties.Resources.Heart09;
                        Card.H_10.image = Properties.Resources.Heart10;
                        Card.H_Jack.image = Properties.Resources.Heart11;
                        Card.H_Queen.image = Properties.Resources.Heart12;
                        Card.H_King.image = Properties.Resources.Heart13;

                        Card.B_Ace.image = Properties.Resources.Diamond01;
                        Card.B_2.image = Properties.Resources.Diamond02;
                        Card.B_3.image = Properties.Resources.Diamond03;
                        Card.B_4.image = Properties.Resources.Diamond04;
                        Card.B_5.image = Properties.Resources.Diamond05;
                        Card.B_6.image = Properties.Resources.Diamond06;
                        Card.B_7.image = Properties.Resources.Diamond07;
                        Card.B_8.image = Properties.Resources.Diamond08;
                        Card.B_9.image = Properties.Resources.Diamond09;
                        Card.B_10.image = Properties.Resources.Diamond10;
                        Card.B_Jack.image = Properties.Resources.Diamond11;
                        Card.B_Queen.image = Properties.Resources.Diamond12;
                        Card.B_King.image = Properties.Resources.Diamond13;

                        break;

                    case 1:

                        Card.C_Ace.image = Properties.Resources.Club01;
                        Card.C_2.image = Properties.Resources.Club02;
                        Card.C_3.image = Properties.Resources.Club03;
                        Card.C_4.image = Properties.Resources.Club04;
                        Card.C_5.image = Properties.Resources.Club05;
                        Card.C_6.image = Properties.Resources.Club06;
                        Card.C_7.image = Properties.Resources.Club07;
                        Card.C_8.image = Properties.Resources.Club08;
                        Card.C_9.image = Properties.Resources.Club09;
                        Card.C_10.image = Properties.Resources.Club10;
                        Card.C_Jack.image = Properties.Resources.Club11;
                        Card.C_Queen.image = Properties.Resources.Club12;
                        Card.C_King.image = Properties.Resources.Club13;

                        Card.S_Ace.image = Properties.Resources.Spade01;
                        Card.S_2.image = Properties.Resources.Spade02;
                        Card.S_3.image = Properties.Resources.Spade03;
                        Card.S_4.image = Properties.Resources.Spade04;
                        Card.S_5.image = Properties.Resources.Spade05;
                        Card.S_6.image = Properties.Resources.Spade06;
                        Card.S_7.image = Properties.Resources.Spade07;
                        Card.S_8.image = Properties.Resources.Spade08;
                        Card.S_9.image = Properties.Resources.Spade09;
                        Card.S_10.image = Properties.Resources.Spade10;
                        Card.S_Jack.image = Properties.Resources.Spade11;
                        Card.S_Queen.image = Properties.Resources.Spade12;
                        Card.S_King.image = Properties.Resources.Spade13;

                        Card.H_Ace.image = Properties.Resources.Heart01;
                        Card.H_2.image = Properties.Resources.Heart02;
                        Card.H_3.image = Properties.Resources.Heart03;
                        Card.H_4.image = Properties.Resources.Heart04;
                        Card.H_5.image = Properties.Resources.Heart05;
                        Card.H_6.image = Properties.Resources.Heart06;
                        Card.H_7.image = Properties.Resources.Heart07;
                        Card.H_8.image = Properties.Resources.Heart08;
                        Card.H_9.image = Properties.Resources.Heart09;
                        Card.H_10.image = Properties.Resources.Heart10;
                        Card.H_Jack.image = Properties.Resources.Heart11;
                        Card.H_Queen.image = Properties.Resources.Heart12;
                        Card.H_King.image = Properties.Resources.Heart13;

                        Card.B_Ace.image = Properties.Resources.Diamond01;
                        Card.B_2.image = Properties.Resources.Diamond02;
                        Card.B_3.image = Properties.Resources.Diamond03;
                        Card.B_4.image = Properties.Resources.Diamond04;
                        Card.B_5.image = Properties.Resources.Diamond05;
                        Card.B_6.image = Properties.Resources.Diamond06;
                        Card.B_7.image = Properties.Resources.Diamond07;
                        Card.B_8.image = Properties.Resources.Diamond08;
                        Card.B_9.image = Properties.Resources.Diamond09;
                        Card.B_10.image = Properties.Resources.Diamond10;
                        Card.B_Jack.image = Properties.Resources.Diamond11;
                        Card.B_Queen.image = Properties.Resources.Diamond12;
                        Card.B_King.image = Properties.Resources.Diamond13;

                        break;
                }
                
            }

            Draw_();


            pictureBox1.Image = backCard;
            pictureBox2.Image = backCard;
            pictureBox3.Image = backCard;
            pictureBox4.Image = backCard;
            pictureBox5.Image = backCard;
            pictureBox6.Image = backCard;
            pictureBox7.Image = backCard;
            pictureBox8.Image = backCard;

            pictureBox10.Image = backCard;
            pictureBox12.Image = backCard;
            pictureBox13.Image = backCard;
            pictureBox14.Image = backCard;
            pictureBox15.Image = backCard;
            pictureBox16.Image = backCard;
            pictureBox17.Image = backCard;
            pictureBox11.Image = backCard;

            if (Properties.Settings.Default.isSave)
            {
                Money = Properties.Settings.Default.Money;
                bet = Properties.Settings.Default.bet;
                InitGame();
            }
            else
            {
                NewGame();
            }
        }

        public void Draw_()
        {
            switch (Properties.Settings.Default.background_number)
            {
                case 0: backgroundFon = Properties.Resources.fon1; break;
                case 1: backgroundFon = Properties.Resources.fon2; break;
                case 2: backgroundFon = Properties.Resources.fon3; break;
                case 3: backgroundFon = Properties.Resources.fon4; break;
                case 4: backgroundFon = Properties.Resources.fon5; break;
                case 5: backgroundFon = Properties.Resources.fon6; break;
            }
            switch (Properties.Settings.Default.card_back_number)
            {
                case 0: backCard = Properties.Resources.s3; break;
                case 1: backCard = Properties.Resources.s4; break;
                case 2: backCard = Properties.Resources.s5; break;
                case 3: backCard = Properties.Resources.s1; break;
            }

            BackgroundImage = backgroundFon;
            pictureBox9.Image = backCard;

        }

        public void Draw()
        {

            BackgroundImage = backgroundFon;
            pictureBox9.Image = backCard;

            label1.Text = "Счёт: " + LocalScore.ToString();
            label2.Text = "Счёт: " + rivalScore.ToString();

            label3.Text = "Монеты: " + Money.ToString();
            label4.Text = "Ставка: " + bet.ToString();
        }

        private void Save()
        {
            Properties.Settings.Default.isSave = true;
            Properties.Settings.Default.Money = Money;
            Properties.Settings.Default.bet = bet;
            Properties.Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Load_();
            Draw();
        }

        private Card GetCard()
        {
            if (DeckCards.Count <= 0) throw new Exception("Not card in Deck card");
            else
            {
                Card card = DeckCards[new Random().Next(0, DeckCards.Count - 1)];
                DeckCards.Remove(card);
                return card;
            }
        }


        public void InitGame()
        {
            button1.Enabled = true;
            button2.Enabled = true;

            plas.Visible = true;
            min.Visible = true;

            indexViewCard = 0;
            indexViewCardRival = -1;
            LocalScore = 0;
            rivalScore = 0;

            DeckCards.Clear();
            switch (Properties.Settings.Default.DeckCards)
            {
                case 0: foreach (Card i in Card.DeckCards24) DeckCards.Add(i); break;
                case 1: foreach (Card i in Card.DeckCards36) DeckCards.Add(i); break;
                case 2: foreach (Card i in Card.DeckCards52) DeckCards.Add(i); break;               
            }

            ShuffleCards();

            playerCards[0] = new PlayerCard(ref pictureBox1, GetCard());
            playerCards[1] = new PlayerCard(ref pictureBox2, GetCard());
            playerCards[2] = new PlayerCard(ref pictureBox3, GetCard());
            playerCards[3] = new PlayerCard(ref pictureBox4, GetCard());
            playerCards[4] = new PlayerCard(ref pictureBox5, GetCard());
            playerCards[5] = new PlayerCard(ref pictureBox6, GetCard());
            playerCards[6] = new PlayerCard(ref pictureBox7, GetCard());
            playerCards[7] = new PlayerCard(ref pictureBox8, GetCard());

            rivalCards[0] = new PlayerCard(ref pictureBox10, GetCard());
            rivalCards[1] = new PlayerCard(ref pictureBox11, GetCard());
            rivalCards[2] = new PlayerCard(ref pictureBox12, GetCard());
            rivalCards[3] = new PlayerCard(ref pictureBox13, GetCard());
            rivalCards[4] = new PlayerCard(ref pictureBox14, GetCard());
            rivalCards[5] = new PlayerCard(ref pictureBox15, GetCard());
            rivalCards[6] = new PlayerCard(ref pictureBox16, GetCard());
            rivalCards[7] = new PlayerCard(ref pictureBox17, GetCard());

            playerCards[indexViewCard].View();
            LocalScore += playerCards[indexViewCard].card.price;

            Draw();
        }

        private void NewGame()
        {
            timer1.Stop();
            Money = 1000;
            InitGame();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plas.Visible = false;
            min.Visible = false;

            if (bet > Money) bet = Money;
            Draw();

            if (indexViewCard < 7)
            {

                indexViewCard++;
                playerCards[indexViewCard].View();
                LocalScore += playerCards[indexViewCard].card.price;
                try
                {
                    SoundCard.Play();
                }
                catch(Exception ex)
                {

                }
                Draw();
            }
            else
            {
                MessageBox.Show("Вы не можете взять карт больше 8!", "Ой...");
            }

            if (playerCards[0].card.name == Card.Name._A || playerCards[0].card.name == Card.Name._K || playerCards[0].card.name == Card.Name._Q || playerCards[0].card.name == Card.Name._J)
                if (playerCards[1].card.name == Card.Name._A || playerCards[1].card.name == Card.Name._K || playerCards[1].card.name == Card.Name._Q || playerCards[1].card.name == Card.Name._J)
                    if (playerCards[2].card.name == Card.Name._A || playerCards[2].card.name == Card.Name._K || playerCards[2].card.name == Card.Name._Q || playerCards[2].card.name == Card.Name._J)
                        if (playerCards[3].card.name == Card.Name._A || playerCards[3].card.name == Card.Name._K || playerCards[3].card.name == Card.Name._Q || playerCards[3].card.name == Card.Name._J)
                            if (playerCards[4].card.name == Card.Name._A || playerCards[4].card.name == Card.Name._K || playerCards[4].card.name == Card.Name._Q || playerCards[4].card.name == Card.Name._J)
                                if (indexViewCard == 4)
                                    Win();

            if (LocalScore > 21)
            {
                GameOver();
            }

            if (LocalScore == 21)
            {
                Win();
            }

            if (playerCards[0].card.name == Card.Name.Ace && playerCards[1].card.name == Card.Name.Ace && indexViewCard == 1)
            {
                Win();
            }

      
        }

        private void GameOver()
        {
            SoundGameOver.Play();
            Money -= bet;
            MessageBox.Show(
                "\tВы проиграли!\t\n" +
                "  -" + bet.ToString() +
                "\n  Итог: " + Money.ToString(),
                "Поражение"
                );

            Draw();
            InitGame();
            
            SetRecord();
        }

        private void Win()
        {
            SoundWin.Play();
            Money += bet;
            MessageBox.Show(
                "\tВы выиграли!\t\n" +
                "  +" + bet.ToString() +
                "\n  Итог: " + Money.ToString(),
                "Победа"
                );

            Draw();
            InitGame();
            

            SetRecord();
        }

        private void SetRecord()
        {
            if (Properties.Settings.Default.record < Money)
                Properties.Settings.Default.record = Money;

            Properties.Settings.Default.Save();

            if (Money <= 0) IsGlobalGameOver();
        }

        private void IsGlobalGameOver()
        {
            
            DialogResult dialogResult = MessageBox.Show("\tУ вас нет монет!\t\t\n\tНачать заново?\t\t", "Поражение", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                NewGame();
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            SoundClick.Play();
            button1.Enabled = false;
            button2.Enabled = false;

            if (bet > Money) bet = Money;
            Draw();

            timer1.Interval = Properties.Settings.Default.rivalSpeed;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rivalScore < 15 + Properties.Settings.Default.DeckCards)
            {
                if (indexViewCardRival < 7)
                {
                    indexViewCardRival++;
                    rivalCards[indexViewCardRival].View();
                    rivalScore += rivalCards[indexViewCardRival].card.price;
                    try
                    {
                        SoundCard.Play();
                    }
                    catch (Exception ex)
                    {

                    }
                    Draw();
                }
                else timer1.Stop();

            }
            else
            {
                timer1.Stop();

                if (rivalScore > 21)
                {
                    Win();
                }
                else if (rivalScore > LocalScore)
                {
                    GameOver();
                }
                else
                {
                    Win();
                }

            }

            if (rivalCards[0].card.name == Card.Name.Ace && rivalCards[1].card.name == Card.Name.Ace)
            {
                GameOver();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void открытьСохранённуюИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Money = Properties.Settings.Default.Money;
            bet = Properties.Settings.Default.bet;

            Draw();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult_ = MessageBox.Show("Закрыть программу?", "Закрыть", MessageBoxButtons.YesNo);
            if (dialogResult_ == DialogResult.Yes)
            {
                if (!(Money == 1000 && bet == 100) && !(Money == Properties.Settings.Default.Money && bet == Properties.Settings.Default.bet))
                {
                    DialogResult dialogResult = MessageBox.Show("Сохранить баланс и ставку!", "Сохранить", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Save();
                    }
                    else
                    {
                        Properties.Settings.Default.isSave = false;
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void min_Click(object sender, EventArgs e)
        {
            bet -= 50;
            if (bet < 50) bet = 50;

            Draw();
            SoundClick.Play();
        }

        private void plas_Click(object sender, EventArgs e)
        {
            bet += 50;
            if (bet > Money) bet = Money;

            Draw();
            SoundClick.Play();
        }

        private void ShuffleCards()
        {
            Random random = new Random();
            var data = new List<Card>();
            foreach (var s in DeckCards)
            {
                int j = random.Next(data.Count + 1);
                if (j == data.Count)
                {
                    data.Add(s);
                }
                else
                {
                    data.Add(data[j]);
                    data[j] = s;
                }
            }

            DeckCards = data;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить текущий рекорд", "Рекорд", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Properties.Settings.Default.record = 0;
            }

        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текущий рекорд: " + Properties.Settings.Default.record.ToString(), "Рекорд");
        }

        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RulesForm rulesForm = new RulesForm();
            rulesForm.Show();
        }

        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatForm formatForm = new FormatForm();
            formatForm.Owner = this;
            formatForm.ShowDialog();
        }

    }
}
