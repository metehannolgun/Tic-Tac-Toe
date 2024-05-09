namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool siraX, SiraO;
        Random r = new Random();
        private void Temizle()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            int rastgeleSayi = r.Next(1, 3);
            if (rastgeleSayi == 1)
            {
                siraX = true;
                SiraO = false;
               

            }
            else if (rastgeleSayi == 2)
            {
                SiraO = true;
                siraX = false;
                
            }

        }
        private void KontrolEt()
        {
            if (label1.Text == "X" && label2.Text == "X" && label3.Text == "X")
            {
                MessageBox.Show("X kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label4.Text == "X" && label5.Text == "X" && label6.Text == "X")
            {
                MessageBox.Show("X kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label7.Text == "X" && label8.Text == "X" && label9.Text == "X")
            {
                MessageBox.Show("X kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label1.Text == "X" && label4.Text == "X" && label7.Text == "X")
            {
                MessageBox.Show("X kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label2.Text == "X" && label5.Text == "X" && label8.Text == "X")
            {
                MessageBox.Show("X kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label3.Text == "X" && label6.Text == "X" && label9.Text == "X")
            {
                MessageBox.Show("X kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label1.Text == "X" && label5.Text == "X" && label9.Text == "X")
            {
                MessageBox.Show("X kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label3.Text == "X" && label5.Text == "X" && label7.Text == "X")
            {
                MessageBox.Show("X kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }////////
            if (label1.Text == "O" && label2.Text == "O" && label3.Text == "O")
            {
                MessageBox.Show("O kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label4.Text == "O" && label5.Text == "O" && label6.Text == "O")
            {
                MessageBox.Show("O kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label7.Text == "O" && label8.Text == "O" && label9.Text == "O")
            {
                MessageBox.Show("O kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label1.Text == "O" && label4.Text == "O" && label7.Text == "O")
            {
                MessageBox.Show("O kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label2.Text == "O" && label5.Text == "O" && label8.Text == "O")
            {
                MessageBox.Show("O kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label3.Text == "O" && label6.Text == "O" && label9.Text == "O")
            {
                MessageBox.Show("O kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label1.Text == "O" && label5.Text == "O" && label9.Text == "O")
            {
                MessageBox.Show("O kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }
            else if (label3.Text == "O" && label5.Text == "O" && label7.Text == "O")
            {
                MessageBox.Show("O kazandý!", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }////////

            else if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
            {
                MessageBox.Show("Oyun Berabere Bitti", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Temizle();
            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Temizle();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
            {
                if (siraX)
                {
                    label1.Text = "X";
                   
                    siraX = false;
                    SiraO = true;
                }
                else if (SiraO)
                {
                    label1.Text = "O";
                   
                    siraX = true;
                    SiraO = false;
                }

            }
            KontrolEt();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "")
            {
                if (siraX)
                {
                    label2.Text = "X";
                    
                    siraX = false;
                    SiraO = true;
                }
                else if (SiraO)
                {
                    label2.Text = "O";
                   
                    siraX = true;
                    SiraO = false;
                }

            }
            KontrolEt();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                if (siraX)
                {
                    label3.Text = "X";
                    
                    siraX = false;
                    SiraO = true;
                }
                else if (SiraO)
                {
                    label3.Text = "O";
                    
                    siraX = true;
                    SiraO = false;
                }

            }
            KontrolEt();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "")
            {
                if (siraX)
                {
                    label4.Text = "X";
                    
                    siraX = false;
                    SiraO = true;
                }
                else if (SiraO)
                {
                    label4.Text = "O";
                    
                    siraX = true;
                    SiraO = false;
                }

            }
            KontrolEt();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "")
            {
                if (siraX)
                {
                    label5.Text = "X";
                   
                    siraX = false;
                    SiraO = true;
                }
                else if (SiraO)
                {
                    label5.Text = "O";
                    
                    siraX = true;
                    SiraO = false;
                }

            }
            KontrolEt();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "")
            {
                if (siraX)
                {
                    label6.Text = "X";
                    
                    siraX = false;
                    SiraO = true;
                }
                else if (SiraO)
                {
                    label6.Text = "O";
                    
                    siraX = true;
                    SiraO = false;
                }

            }
            KontrolEt();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.Text == "")
            {
                if (siraX)
                {
                    label7.Text = "X";
                    
                    siraX = false;
                    SiraO = true;
                }
                else if (SiraO)
                {
                    label7.Text = "O";
                    
                    siraX = true;
                    SiraO = false;
                }

            }
            KontrolEt();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == "")
            {
                if (siraX)
                {
                    label8.Text = "X";
                    siraX = false;
                    SiraO = true;
                }
                else if (SiraO)
                {
                    label8.Text = "O";
                    siraX = true;
                    SiraO = false;
                }

            }
            KontrolEt();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (label9.Text == "")
            {
                if (siraX)
                {
                    label9.Text = "X";
                    siraX = false;
                    SiraO = true;
                }
                else if (SiraO)
                {
                    label9.Text = "O";
                    siraX = true;
                    SiraO = false;
                }

            }
            KontrolEt();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (label1.Text == "")
            {
                label1.BackColor = Color.LimeGreen;
            }
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.SpringGreen;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (label2.Text == "")
            {
                label2.BackColor = Color.LimeGreen;
            }
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            if (label2.Text == "")
            {
                label2.BackColor = Color.SpringGreen;
            }
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (label3.Text == "")
            {
                label3.BackColor = Color.LimeGreen;
            }
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                label3.BackColor = Color.SpringGreen;
            }
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (label4.Text == "")
            {
                label4.BackColor = Color.LimeGreen;
            }
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            if (label4.Text == "")
            {
                label4.BackColor = Color.SpringGreen;
            }
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            if (label5.Text == "")
            {
                label5.BackColor = Color.LimeGreen;
            }
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            if (label5.Text == "")
            {
                label5.BackColor = Color.SpringGreen;
            }
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            if (label6.Text == "")
            {
                label6.BackColor = Color.LimeGreen;
            }
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            if (label6.Text == "")
            {
                label6.BackColor = Color.SpringGreen;
            }
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            if (label7.Text == "")
            {
                label7.BackColor = Color.LimeGreen;
            }
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            if (label7.Text == "")
            {
                label7.BackColor = Color.SpringGreen;
            }
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            if (label8.Text == "")
            {
                label8.BackColor = Color.LimeGreen;
            }
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            if (label8.Text == "")
            {
                label8.BackColor = Color.SpringGreen;
            }
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            if (label9.Text == "")
            {
                label9.BackColor = Color.LimeGreen;
            }
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            if (label9.Text == "")
            {
                label9.BackColor = Color.SpringGreen;
            }
        }

        private void labelSira_Click(object sender, EventArgs e)
        {

        }
    }
}
