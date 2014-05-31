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
        private int selectedGroupIndex;
     

        public NewsReaderForm()
        {
            InitializeComponent();
        }

        private void NewsReaderForm_Load(object sender, EventArgs e)
        {
            //server
            server = "forums.embarcadero.com";
            textBoxServerURL.Text = server;
            textBoxServerURL.Select();

            //listboxes
            newsGroups = new NewsgroupCollection();
            listBoxNewsgroups.DisplayMember = "Name";
            listBoxArticleHeaders.DisplayMember = "Subject";
            
            //filtering
            checkBoxFilterGroups.Checked = false;
            deactivateFiltering();
            radioButtonInclude.Checked = true;
            checkBoxFilterArticles.Checked = true;
            textBoxNumArticles.Text = "100";
        }

        private void populateNewsGroupsListBox()
        {
            listBoxNewsgroups.Items.Clear();

            if (newsGroups != null)
            {
                foreach (Newsgroup group in newsGroups)
                {
                    listBoxNewsgroups.Items.Add(group);
                }

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

                doFilteredSearch();
                if (searchFoundResults())
                {
                   
                   populateNewsGroupsListBox();
                   
                   listBoxNewsgroups.SelectedIndex = 0;
                   
                }
            }
            catch (NntpException ex1)
            {
                MessageBox.Show("nntpException "+ ex1.Message);
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Other exception " + ex2.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private bool searchFoundResults()
        {
            return newsGroups.Count > 0;
        }

        private void doFilteredSearch()
        {

            List<string> includeTerms = null;
            List<string> excludeTerms = null;

            if (checkBoxFilterGroups.Checked)
            {
                includeTerms = getIncludeTerms();
                excludeTerms = getExcludeTerms();
            }

            newsGroups = Utils.GetNewsGroups(server, includeTerms, excludeTerms);


            ///this is corny, need to simplify
            if (includeTerms != null)
            {
                addSearchToComboBox(includeTerms);
            }
            else if (excludeTerms != null)
            {
                addSearchToComboBox(excludeTerms);
            }   
        }

        private List<string> getSearchTerms()
        {
 
            string searchInput = string.Empty;
            if (comboBoxSearchTerms.SelectedIndex == -1)
            {
                searchInput = comboBoxSearchTerms.Text; ;
            }
            else
            {
                searchInput = comboBoxSearchTerms.SelectedItem.ToString();
            }


            string[] searchWords = searchInput.Trim().Split(' ');

            List<string> includeTerms = new List<string>();
            foreach(string word in searchWords)
            {
                includeTerms.Add(word);
            }
            return includeTerms;
        }

        private List<string> getIncludeTerms()
        {
            if(radioButtonInclude.Checked)
            {
                return getSearchTerms();
            }
            else return null;
        }

        private List<string> getExcludeTerms()
        {
            if(radioButtonExclude.Checked)
            {
                return getSearchTerms();
            }
            else return null;
        }

        private void deactivateFiltering()
        {
            radioButtonInclude.Enabled = false;
            radioButtonExclude.Enabled = false;
            labelSearchPrompt.Enabled = false;
            comboBoxSearchTerms.Enabled = false;
        }

        private void activateFiltering()
        {
            radioButtonInclude.Enabled = true;
            radioButtonExclude.Enabled = true;
            labelSearchPrompt.Enabled = true;
            comboBoxSearchTerms.Enabled = true;
        }

        private void deactivateArticleLimit()
        {
            labelArticles.Enabled = false;
            labelNumArticles.Enabled = false;
            textBoxNumArticles.Enabled = false;
        }

        private void activateArticleLimit()
        {
            labelArticles.Enabled = true;
            labelNumArticles.Enabled = true;
            textBoxNumArticles.Enabled = true;
        }

        private void addSearchToComboBox(List<string> searchTerms)
        {
            string searchDisplay = Utils.ListToString(searchTerms);
            if (comboBoxSearchTerms.Items.Contains(searchDisplay) == false)
            {
                comboBoxSearchTerms.Items.Add(searchDisplay);
            }
        }


        private void listBoxNewsgroups_DoubleClick(object sender, EventArgs e)
        {
            Newsgroup selectedGroup = listBoxNewsgroups.SelectedItem as Newsgroup;
            if (selectedGroup != null)
            {
                selectedGroupIndex = newsGroups.IndexOf(selectedGroup);


                int maxHeaders = 0;
                if (Int32.TryParse(textBoxNumArticles.Text, out maxHeaders))
                {
                    Utils.UpdateGroupArticles(server, selectedGroup, maxHeaders);
                }
                else
                {
                    Utils.UpdateGroupArticles(server, selectedGroup);
                }
                updateArticleListBox(selectedGroup);
            }
        }


        private int getMaxHeaders()
        {
            int maxHeaders = 0;
            if (checkBoxFilterArticles.Checked)
            {
                bool success = Int32.TryParse(textBoxNumArticles.Text, out maxHeaders);
                return maxHeaders;
            }
            else
            {
                maxHeaders = 200;
            }
            return maxHeaders;

        }

        private void updateArticleListBox(Newsgroup selectedGroup)
        {
            clearHeadersList();
            //Utils.UpdateGroupArticles(server, selectedGroup);
            listBoxArticleHeaders.DataSource = selectedGroup.Articles;
           
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
            if (selectedArticle != null && selectedArticle.Body == null)
            {
                Utils.UpdateArticleText(server, selectedGroup, selectedArticle);
                changeArticleDisplay(selectedArticle);
            }

        }

        private void checkBoxFilterGroups_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilterGroups.Checked)
            {
                activateFiltering();
            }
            else
            {
                deactivateFiltering();
            }
        }

        private void checkBoxFilterArticles_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilterArticles.Checked)
            {
                activateArticleLimit();
            }
            else
            {
                deactivateArticleLimit();
            }
        }

        }

       

    }


    

