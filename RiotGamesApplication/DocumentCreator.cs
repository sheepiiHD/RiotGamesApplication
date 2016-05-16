using Novacode;
using System;
using System.Diagnostics;
using System.Drawing;

namespace RiotGamesApplication
{
    class DocumentCreator
    {
        String greeting, farewell;
        String[] body;
        System.Drawing.Image[] imgs;


        private string global_path;

        public DocumentCreator()
        {
            greeting = "";
            body = new String[] { "" };
            farewell = "";
        }
        public DocumentCreator(String greeting, String[] body, String farewell)
        {
            this.greeting = greeting;
            this.body = body;
            this.farewell = farewell;
        }
        public DocumentCreator(String greeting, String[] body, String farewell, params System.Drawing.Image[] imgs)
        {
            this.greeting = greeting;
            this.body = body;
            this.farewell = farewell;
            this.imgs = imgs;
        }
        /// <summary>
        /// Create a new cover letter. This will eventually be overridden based on Objects of Resumes and Cover Letters. This will also eventually accept user input.
        /// Eventually this will design cover letters for people. 
        /// </summary>
        public void create(CoverLetter cl)
        { 
             string appDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            // Modify to suit your machine:
            

            Console.WriteLine(createDirectory(appDataFolderPath));
            Console.ReadKey();

            string fileName = global_path + @"\CoverLetter.docx";

            // Create a document in memory:
            var doc = DocX.Create(fileName);

            Microsoft.Office.Interop.Word.Document aDoc = null;

            // Insert a paragrpah:
            doc.InsertParagraph("This is my first paragraph");

            

            // Save to the output directory:
            doc.Save();

            // Open in Word:
            // Process.Start("WINWORD.EXE", fileName);

        }
        private bool anyNull(params object[] items)
        {
            foreach (object i in items)
            {
                if (i.Equals(null))
                {
                    return true;
                }
            }
            return false;
        }
        private string createDirectory(string appDataFolderPath)
        {
            string path = appDataFolderPath + @"\RiotCoverLetter";
            bool exists = System.IO.Directory.Exists(path);

            global_path = path;

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(path);
                return "Directory created in: " + path;
            }
            else
            {
                return "Directory found.";
            }

        }
    }
}
