using System.Collections.Generic;
using System.Configuration;

namespace StudentApplication.Web.Bootstrappers.Ioc
{
    public static class ConnectionStringSettingsCollectionExtensions
    {
        public static Dictionary<string, string> AsDictionary(this ConnectionStringSettingsCollection col)
        {
            var dict = new Dictionary<string, string>();
            foreach (ConnectionStringSettings item in col)
            {
                dict.Add(item.Name, item.ConnectionString);
            }
            return dict;
        }
    }
}