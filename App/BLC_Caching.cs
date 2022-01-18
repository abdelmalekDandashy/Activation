using System.Collections.Generic;
using Enyim.Caching;
using Enyim.Caching.Configuration;
using Enyim.Caching.Memcached;
using Microsoft.Extensions.Logging;
using System.Configuration;

namespace BLC
{
    public partial class BLC
    {
        public MemcachedClient Init_MemcachedClient()
        {
            #region Declaration And Initialization Section.
            #endregion
            #region Body Section.
	    //if (ConfigurationManager.AppSettings["MEMCACHED_ENABLED"] != "1") { return null; }
            var serverList = new List<Server>
            {
              new Server
              {
                Address = ConfigurationManager.AppSettings["MEMCACHED_IP"],
                Port = System.Convert.ToInt32(ConfigurationManager.AppSettings["MEMCACHED_PORT"])
              }
            };

            // memcached client options
            var clientOptions = new MemcachedClientOptions { Servers = serverList , Protocol = MemcachedProtocol.Text };
            var logger = new LoggerFactory();
            var clientConfiguration = new MemcachedClientConfiguration(logger, clientOptions);

            // create memcached client
            MemcachedClient _MemcachedClient = new MemcachedClient(logger, clientConfiguration);
            #endregion

            #region Return Section.
            return _MemcachedClient;
            #endregion
        }

        public string Caching_Get_Entry(string key)
        {
           object toRet = null;
            if (this.My_MemcachedClient.TryGet(key, out toRet))
            {
                return toRet.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        public void Caching_Set_Entry(string key, string value)
        {
            this.My_MemcachedClient.Store(StoreMode.Set, key,value);
        }

        public void Caching_Flush_All()
        {
            this.My_MemcachedClient.FlushAll();
        }
    }
}
