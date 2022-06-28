using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings frm3 = new settings();
            {
                frm3.ShowDialog();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about frm2 = new about();
            {
                frm2.ShowDialog();
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            conversations frm4 = new conversations();
            {
                frm4.ShowDialog();
            }
        }

        private void conversationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversations frm4 = new conversations();
            {
                frm4.ShowDialog();
            }
        }

        private void expCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expcalc frm5 = new expcalc();
            {
                frm5.ShowDialog();
            }
        }

        private void spellBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spellbook frm6 = new spellbook();
            {
                frm6.ShowDialog();
            }
        }

        private void onlinePlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onlineplayers frm7 = new onlineplayers();
            {
                frm7.ShowDialog();
            }
        }

        private void playerStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerstats frm8 = new playerstats();
            {
                frm8.ShowDialog();
            }
        }

        private void sessionStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sessionstats frm9 = new sessionstats();
            {
                frm9.ShowDialog();
            }
        }

        private void timeAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timeanalysis frm10 = new timeanalysis();
            {
                frm10.ShowDialog();
            }
        }

        private void partyStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partystats frm11 = new partystats();
            {
                frm11.ShowDialog();
            }
        }

        private void qToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quicktools frm12 = new quicktools();
            {
                frm12.ShowDialog();
            }
        }

        private void backScrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backscroll frm13 = new backscroll();
            {
                frm13.ShowDialog();
            }
        }
    }
}
