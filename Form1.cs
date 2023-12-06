using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemonMachine
{
    public partial class Form1 : Form
    {
        static Image pikachu = pokemonMachine.Properties.Resources.pikachu;
        static Image bulbasaur = pokemonMachine.Properties.Resources.bulb;
        static Image charmander = pokemonMachine.Properties.Resources._char;
        static Image eevee = pokemonMachine.Properties.Resources.eevie;
        static Image squirtle = pokemonMachine.Properties.Resources.squirt;
        static Image rat = pokemonMachine.Properties.Resources.rat;
        static Image pidgey =pokemonMachine.Properties.Resources.pidgey;
        static Image cat = pokemonMachine.Properties.Resources.cat;
        static Image jiggly = pokemonMachine.Properties.Resources.jiggly;
        static Image diglet = pokemonMachine.Properties.Resources.diglet;
        static Image psyduck = pokemonMachine.Properties.Resources.psyduck;
        static Image pokeball = pokemonMachine.Properties.Resources.Pokéball;
        static Image hold_on = pokemonMachine.Properties.Resources.hold_on;
        static Image hold_off = pokemonMachine.Properties.Resources.hold_off;
        Image[] reels =  { pikachu, bulbasaur, charmander, eevee, squirtle,rat,pidgey,cat,jiggly,diglet,psyduck, pokeball };
        int count;
        int leftReelPointer;
        int centreReelPointer;
        int rightReelPointer;
        int nudges = 0;
        int credit = 20;       
            public Form1()
        {
            InitializeComponent();
        }

        
        public int mod(int x, int m)
        {
            return (x % m + m) % m;
        }

        private void tmr_reel1_Tick(object sender, EventArgs e)
        {
            leftReelPointer++;
            if (leftReelPointer == 12) { leftReelPointer = 0; }
            PB_left_centre.Image = reels[leftReelPointer];
            PB_bottom_left.Image = reels[mod(leftReelPointer - 1, 12)];
            PB_top_left.Image = reels[(leftReelPointer + 1) % 12];

        }

        private void tmr_reel2_Tick(object sender, EventArgs e)
        {
            centreReelPointer++;
            if (centreReelPointer == 12) { centreReelPointer = 0; }
            PB_middle_centre.Image = reels[centreReelPointer];
            PB_bottom_centre.Image = reels[mod(centreReelPointer - 1,12)];
            PB_top_centre.Image = reels[(centreReelPointer + 1) % 12];

        }

        private void tmr_reel3_Tick(object sender, EventArgs e)
        {
            rightReelPointer++;
            if (rightReelPointer == 12) { rightReelPointer = 0; }
            PB_right_centre.Image = reels[rightReelPointer];
            PB_bottom_right.Image = reels[mod(rightReelPointer - 1, 12)];
            PB_top_right.Image = reels[(rightReelPointer + 1) % 12];

        }

        private void tmr_master_Tick(object sender, EventArgs e)
        {
             { tmr_reel1.Start(); }
            count++;
            if (count == 2 ) { tmr_reel2.Start(); }
            if (count == 4 ) { tmr_reel3.Start(); }
            if (count == 20)
            {
                tmr_reel1.Stop();
                tmr_reel2.Stop();
                tmr_reel3.Stop();
                tmr_master.Stop();
                count = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            leftReelPointer = rnd.Next(0, 11);
            centreReelPointer = rnd.Next(0, 11);
            rightReelPointer = rnd.Next(0, 11);
            //set reels
            PB_left_centre.Image = reels[leftReelPointer];
            PB_middle_centre.Image = reels[centreReelPointer];
            PB_right_centre.Image = reels[rightReelPointer];
            PB_bottom_left.Image = reels[mod(leftReelPointer - 1, 12)];
            PB_bottom_centre.Image = reels[mod(centreReelPointer - 1, 12)];
            PB_bottom_right.Image = reels[mod(rightReelPointer - 1, 12)];
            PB_top_left.Image = reels[(leftReelPointer + 1) % 12];
            PB_top_centre.Image = reels[(centreReelPointer + 1) % 12];
            PB_top_right.Image = reels[(rightReelPointer + 1) % 12];
            tmr_master.Stop();
            tmr_reel1.Stop();
            tmr_reel2.Stop();
            tmr_reel3.Stop();
            tmr_hold.Stop();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (credit > 0)
            {
                nudges = 0;
                lbl_nudges.Text = nudges.ToString();
                
                tmr_master.Start();
                credit--;
                lbl_credit.Text = credit.ToString();
                Random rnd_nudge = new Random();                
                if (rnd_nudge.Next(1, 6) == 5)
                { 
                    nudges = nudges + rnd_nudge.Next(1, 4);
                    lbl_nudges.Text = nudges.ToString();
                }
               

            }

        }

        private void nudge_left_Click(object sender, EventArgs e)
        {
            if (nudges > 0)
            {
                leftReelPointer = (leftReelPointer + 1) % 12;
                PB_left_centre.Image = reels[leftReelPointer];
                PB_top_left.Image = reels[mod(leftReelPointer + 1, 12)];
                PB_bottom_left.Image = reels[mod(leftReelPointer - 1,12)];
                nudges--;
                lbl_nudges.Text = nudges.ToString();
            }
        }

        private void nudge_centre_Click(object sender, EventArgs e)
        {
            if (nudges > 0)
            {
                centreReelPointer = (centreReelPointer + 1) % 12;
                PB_middle_centre.Image = reels[centreReelPointer];
                PB_top_centre.Image = reels[mod(centreReelPointer + 1, 12)];
                PB_bottom_centre.Image = reels[mod(centreReelPointer - 1,12)];
                nudges--;
                lbl_nudges.Text= nudges.ToString();
            }
        }

        private void nudge_right_Click(object sender, EventArgs e)
        {
            if (nudges > 0)
            {
                rightReelPointer = (rightReelPointer + 1) % 12;
                PB_right_centre.Image = reels[rightReelPointer];
                PB_top_right.Image = reels[mod(rightReelPointer + 1, 12)];
                PB_bottom_right.Image = reels[mod(rightReelPointer - 1, 12)];
                nudges--;
                lbl_nudges.Text = nudges.ToString();
            }
        }

        private void tmr_hold_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void hold_left_Click(object sender, EventArgs e)
        {
           
        }

        private void hold_centre_Click(object sender, EventArgs e)
        {
            
            

        }

        private void hold_right_Click(object sender, EventArgs e)
        {
            
        }
    }
}
