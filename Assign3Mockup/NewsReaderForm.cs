using COMP2614.News;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign3Mockup
{
    public partial class NewsReaderForm : Form
    {
        public NewsReaderForm()
        {
            InitializeComponent();
        }

        private void NewsReaderForm_Load(object sender, EventArgs e)
        {
            NewsConnection connection = new NewsConnection();
            connection.Connect("forums.embarcadero.com");

            connection.Disconnect();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
