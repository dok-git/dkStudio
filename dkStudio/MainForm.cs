using System;
using System.Windows.Forms;

namespace dkStudio
{
    public partial class MainForm : Form
    {
        private WProject wProject = new WProject();
        private WAssets wAssets = new WAssets();
        private WProperties wProperties = new WProperties();
        private WOutput wOutput = new WOutput();
        public MainForm()
        {
            InitializeComponent();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            wProject.Show(dockPanel);
            wAssets.Show(dockPanel);
            wProperties.Show(dockPanel);
            wOutput.Show(dockPanel);
                    
        }
    }
}
