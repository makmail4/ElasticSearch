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
            var node = new Uri("https://08c9002df605125a7badb91ee1988c9e.us-east-1.aws.found.io:9243");
            var settings = new ConnectionSettings(node);
            settings.BasicAuthentication("elastic", "jBIJdYtKY22O3lKKyf8V0gQo");
            settings.DefaultIndex("stackoverflow");
            settings.DefaultIndex("stackoverflow");
            return new ElasticClient(settings);
        }
    }
}