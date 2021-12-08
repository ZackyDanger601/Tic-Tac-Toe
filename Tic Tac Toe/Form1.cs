using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelPlayer1_Paint(object sender, PaintEventArgs e)
        {
            // Pink Background Color
        }

        private void lblPlayer1_Click(object sender, EventArgs e)
        {
            // Player 1 Settings Placement
        }

        private void btnPlayer1Character1_Click(object sender, EventArgs e)
        {
            
        }

        private void pannelPlayer2_Paint(object sender, PaintEventArgs e)
        {
            // Blue Background Color
        }

        public void txtBxPlayer1_TextChanged(object sender, EventArgs e)
        {
            String player1Name = txtBxPlayer1.Text; // player 1's Name
            GameForm gF = new GameForm();
            gF.Show();
            this.Hide();
            
            
        }

        private void testlbl_Click(object sender, EventArgs e)
        {
            

        }

        private void txtBxPlayer2_TextChanged(object sender, EventArgs e)
        {
            String player2Name = txtBxPlayer2.Text; // Player 2 Name
        }

        private void btnPlayer2Character1_Click(object sender, EventArgs e)
        {
            
        }

        public void btnPlayer1Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gF = new GameForm();
            gF.Show();

        }

        private void btnPlayer2Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gF = new GameForm();
            gF.Show();
        }

        private void btnPlayer1SymbolColor_Click(object sender, EventArgs e)
        {
            if(Player1SymbolColorbx.ShowDialog() == DialogResult.OK)
            {
                Color player1SymbolColor = Player1SymbolColorbx.Color;
                btnPlayer1SymbolColor.BackColor = player1SymbolColor;
            }
        }

        private void btnPlayer1BackColor_Click(object sender, EventArgs e)
        {
            if(Player1BackColorBx.ShowDialog() == DialogResult.OK)
            {
                Color player1BackgroundColor = Player1BackColorBx.Color;
                btnPlayer1BackColor.BackColor = player1BackgroundColor;
            }
        }

        private void btnPlayer2SymbolColor_Click(object sender, EventArgs e)
        {
            if (Player2SymbolColorBx.ShowDialog() == DialogResult.OK)
            {
                Color player2SymbolColor = Player2SymbolColorBx.Color;
                btnPlayer2SymbolColor.BackColor = player2SymbolColor;
            }
        }

        private void btnPlayer2BackColor_Click(object sender, EventArgs e)
        {
            if(Player2BackColorBx.ShowDialog() == DialogResult.OK)
            {
                Color player2BackgroundColor = Player2BackColorBx.Color;
                btnPlayer2BackColor.BackColor = Player2BackColorBx.Color;
            }
        }
    }
}
