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
        private string server;
        private NewsgroupCollection newsGroups;
        //private Newsgroup selectedGroup;
        private int selectedGroupIndex;
       // private ArticleCollection articles;
        //private Article selectedArticle;
        

        public NewsReaderForm()
        {
            InitializeComponent();
        }

        private void NewsReaderForm_Load(object sender, EventArgs e)
        {
            server = "forums.embarcadero.com";
            textBoxServerURL.Text = server;
            textBoxServerURL.Select();
            newsGroups = new NewsgroupCollection();
        //    articles = new ArticleCollection();

        }

        private void populateNewsGroupsListBox()
        {
            listBoxNewsgroups.Items.Clear();

            foreach (Newsgroup group in newsGroups)
            {
                listBoxNewsgroups.Items.Add(group);
            }
        
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getGroupsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                server = textBoxServerURL.Text;
                this.Cursor = Cursors.WaitCursor;
                List<string> includeTerms = getIncludeTerms();
               // List<string> excludeTerms = getExcludeTerms();
                newsGroups = Utils.GetNewsGroups(server, includeTerms);

                populateNewsGroupsListBox();
                listBoxNewsgroups.DisplayMember = "Name";
                listBoxNewsgroups.SelectedIndex = 0;
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No such host");
            }
        }

        private List<string> getIncludeTerms()
        {
            List<string> includeTerms = new List<string>();
            string[] searchWords = comboBoxSearchTerms.Text.Split();
            foreach(string word in searchWords)
            {
                includeTerms.Add(word);
            }
            return includeTerms;
        }



        private void listBoxNewsgroups_DoubleClick(object sender, EventArgs e)
        {
            Newsgroup selectedGroup = listBoxNewsgroups.SelectedItem as Newsgroup;
            selectedGroupIndex = newsGroups.IndexOf(selectedGroup);
            Utils.UpdateGroupArticles(server, selectedGroup);
            updateArticleListBox(selectedGroup);
        }


        private void updateArticleListBox(Newsgroup selectedGroup)
        {
            clearHeadersList();
            //Utils.UpdateGroupArticles(server, selectedGroup);
            listBoxArticleHeaders.DataSource = selectedGroup.Articles;
            listBoxArticleHeaders.DisplayMember = "Subject";
        }

   
        private void clearHeadersList()
        {
            listBoxArticleHeaders.DataSource = null;
        }


        private void listBoxNewsgroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            Newsgroup selectedGroup = listBoxNewsgroups.SelectedItem as Newsgroup;
            updateArticleListBox(selectedGroup);
        }




        private void clearArticleDisplay()
        {
            textBoxArticleText.Text = string.Empty;
        }

        private void changeArticleDisplay(Article article)
        {

            if (article == null || article.Body == null)
            {
                clearArticleDisplay();
            }
            else
            {
                textBoxArticleText.Text = article.Body;
            }

        }

        private void listBoxArticleHeaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Article selectedArticle = listBoxArticleHeaders.SelectedItem as Article;
            changeArticleDisplay(selectedArticle);
        }

        private void listBoxArticleHeaders_DoubleClick(object sender, EventArgs e)
        {
            Newsgroup selectedGroup = listBoxNewsgroups.SelectedItem as Newsgroup;
            Article selectedArticle = listBoxArticleHeaders.SelectedItem as Article;
            // selectedGroupIndex = newsGroups.IndexOf(selectedGroup);
            if (selectedArticle.Body == null)
            {
                Utils.UpdateArticleText(server, selectedGroup, selectedArticle);
                changeArticleDisplay(selectedArticle);
            }

        }

       

    }


    }

