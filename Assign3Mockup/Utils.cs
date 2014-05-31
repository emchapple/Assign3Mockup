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

        public static NewsgroupCollection GetNewsGroups(string server, List<string> includeList, List<string> excludeList) 
        {
            NewsConnection connection = new NewsConnection();
           
                connection.Connect(server);
                NewsgroupCollection groups = connection.GetNewsgroups(includeList, excludeList);
                connection.Disconnect();
            

            return groups;
        }

        public static void UpdateGroupArticles(string server, Newsgroup newsGroup, int maxHeaders)
        {
            if (newsGroup != null && newsGroup.Articles == null)
            {
                NewsConnection connection = new NewsConnection();
                connection.Connect(server);
                ArticleCollection articles = connection.GetArticleHeaders(newsGroup, maxHeaders);
                connection.Disconnect();
                newsGroup.Articles = articles;
            }
        }


        //ugly overload, fragile, too much duplicated code :(
        public static void UpdateGroupArticles(string server, Newsgroup newsGroup)
        {
            if (newsGroup.Articles == null)
            {
                NewsConnection connection = new NewsConnection();
                connection.Connect(server);
                ArticleCollection articles = connection.GetArticleHeaders(newsGroup );
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

        public static string ListToString(List<string> words)
        {
            string result = string.Empty;
            if (words != null)
            {
                foreach (string word in words)
                {
                    result += word + " ";
                }
            }
            return result;
        }


}
}
