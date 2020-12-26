namespace Xis.Models
{
    public class SearchResult
    {
        public string ServiceName { get; }
        public Issue[] Issues { get; }

        public SearchResult(string serviceName, Issue[] issues)
        {
            ServiceName = serviceName;
            Issues = issues;
        }
    }

    public class Issue
    {
        public string Title { get; }
        public string Body { get; }

        public Issue(string title, string body)
        {
            Title = title;
            Body = body;
        }
    }
}
