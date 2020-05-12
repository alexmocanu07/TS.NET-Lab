using System;
using System.Windows.Forms;
using PostComment;
namespace ClientPostComment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            test();
        }

        static void test()
        {
            PostCommentClient client = new PostCommentClient();
            Post post = new Post();
            post.Date = DateTime.Now;
            post.Description = "asbasdas";
            post.Domain = "12312412";

            client.AddPost(post);

            Console.WriteLine("Done");
        }
    }
}
