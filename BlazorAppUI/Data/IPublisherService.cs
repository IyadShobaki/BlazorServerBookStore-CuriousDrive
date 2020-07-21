using System.Collections.Generic;

namespace BlazorAppUI.Data
{
    public interface IPublisherService
    {
        List<Publisher> Publishers { get; set; }

        void DeletePublisher(string publisherId);
        Publisher GetPublisherById(string publisherId);
        List<Publisher> GetPublishers();
        bool SavePublisher(Publisher publisher);
    }
}