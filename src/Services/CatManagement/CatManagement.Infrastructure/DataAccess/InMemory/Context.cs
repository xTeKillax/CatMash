using CatManagement.Domain.CatObject;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace CatManagement.Infrastructure.DataAccess.InMemory
{
    public class Context
    {
        public Collection<Cat> Cats { get; set; }

        public Context()
        {
            Cats = GetCats().GetAwaiter().GetResult();
        }

        private async Task<Collection<Cat>> GetCats()
        {
            string baseUrl = "https://latelier.co/data/cats.json";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                    {
                        using (HttpContent content = res.Content)
                        {
                            var data = await content.ReadAsStringAsync();

                            if (content != null)
                            {
                                Collection<Cat> catList = JObject.Parse(data)["images"].ToObject<Collection<Cat>>();

                                return await Task.FromResult(catList);
                            }
                            else
                            {
                                throw new InfrastructureException("There is no cat to fetch.");
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                throw new InfrastructureException("Error while fetching cats.");
            }
        }
    }
}
