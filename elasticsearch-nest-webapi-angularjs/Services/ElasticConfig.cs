using System;
using System.Configuration;
using Nest;

namespace elasticsearch_nest_webapi_angularjs.Services
{
    public static class ElasticConfig
    {
        public static string IndexName
        {
            get { return ConfigurationManager.AppSettings["indexName"]; }
        }

        public static string ElastisearchUrl
        {
            get { return ConfigurationManager.AppSettings["elastisearchUrl"]; }
        }

        public static IElasticClient GetClient()
        {
            var node = new Uri("https://localhost");
            var settings = new ConnectionSettings(node);
            settings.BasicAuthentication("elastic", "pwd");
            settings.DefaultIndex("stackoverflow");
            settings.DefaultIndex("stackoverflow");
            return new ElasticClient(settings);
        }
    }
}