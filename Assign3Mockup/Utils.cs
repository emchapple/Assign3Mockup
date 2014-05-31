using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP2614.News;


namespace Assign3Mockup
{
    class Utils
    {



        public static void init()
        {
            NewsConnection connection = new NewsConnection();
            connection.Connect("forums.embarcadero.com");
            connection.Disconnect();
        }

        //good test server: forums.embarcadero.com.

        public static NewsgroupCollection GetNewsGroups(string server, List<string> includeTerms)
        {
            NewsConnection connection = new NewsConnection();

            connection.Connect(server);
            NewsgroupCollection groups = connection.GetNewsgroups(includeTerms, null);
        //    connection.get
            connection.Disconnect();

            return groups;
        }

        public static void UpdateGroupArticles(string server, Newsgroup newsGroup)
        {
            if (newsGroup.Articles == null)
            {
                NewsConnection connection = new NewsConnection();
                connection.Connect(server);
                ArticleCollection articles = connection.GetArticleHeaders(newsGroup, 100);
                connection.Disconnect();
                newsGroup.Articles = articles;
            }
        }  




        public static void UpdateArticleText(string server, Newsgroup newsgroup, Article article)
        {
            NewsConnection connection = new NewsConnection();
            connection.Connect(server);
            string articleText = connection.GetArticle(newsgroup, article);
            article.Body = articleText;
        }




}
}
