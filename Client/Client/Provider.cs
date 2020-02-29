using Client.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Provider
    {
        public Provider()
        {
            StaticStore.memoApi = RestService.For<IMemoAPI>(ConfigurationSettings.AppSettings["MemoApiURL"]);
            
        }

        public async Task<MemoResponse> GetMemo(int id)
        {
            return await StaticStore.memoApi.GetMemo(id, StaticStore.Token);
        }
    }
}
