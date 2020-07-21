using System;
using System.Collections.Generic;

namespace BlazorAppUI.Data
{
    public interface IAuthorService
    {
        List<Author> Authors { get; set; }
        DateTime CreationDate { get; set; }

        Author GetAuthorById(string authorId);
        List<Author> GetAuthors();
        DateTime GetCreatedDate();
        string GetVersion();
        bool SaveAuthor(Author author);
    }
}