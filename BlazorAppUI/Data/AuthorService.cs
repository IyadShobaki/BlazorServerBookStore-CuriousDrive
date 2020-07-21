using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppUI.Data
{
    public class AuthorService : IAuthorService
    {
        public DateTime CreationDate { get; set; }
        public List<Author> Authors { get; set; }

        public AuthorService()
        {
            CreationDate = DateTime.Now;

            Authors = new List<Author>();

            Authors.Add(new Author("172-32-1176", "Johnson", "White",
                "408 496 7223", "Menlo Park", "johnson.white@gmail.com",11000));
            Authors.Add(new Author("213-46-8915", "Marjorie", "Green",
                "415 986 7020", "Oakland", "marjorite.green@gmail.com", 22000));
            Authors.Add(new Author("238-95-7766", "Cheryl", "Carson",
                "415 548 7723", "Berkeley", "cheryl.carson@gmail.com", 39000));
            Authors.Add(new Author("267-41-2394", "Michael", "O'Leary",
                "408 286 2428", "San Jose", "michael.oleary@gmail.com", 31000));
            Authors.Add(new Author("274-80-9391", "Dean", "Straight",
                "415 834 2919", "Oakland", "dean.straight@gmail.com", 29000));

        }

        public List<Author> GetAuthors()
        {
            return Authors;
        }

        public Author GetAuthorById(string authorId)
        {
            return Authors.Where(auth => auth.AuthorId == authorId).FirstOrDefault();
        }

        public DateTime GetCreatedDate()
        {
            return CreationDate;
        }

        public string GetVersion()
        {
            return "v1";
        }

        public void SaveAuthor(Author author)
        {
            author.AuthorId = GetNewAuthor();
            Authors.Add(author);
        }
        private string GetNewAuthor()
        {
            string id;
            Random random = new Random();
            id = random.Next(100, 1000).ToString() + "-";
            id += random.Next(10, 100).ToString() + "-";
            id += random.Next(1000, 10000).ToString();

            return id;
        }

        
    }
}
