using CSharpLearning.Services.List.Models;
using Newtonsoft.Json;

namespace CSharpLearning.Services.List
{
    public class ListService
    {
        public List<ListCSharp> ListingListProperties()
        {
            var json = "./../../Data/listproperty.json";

            List<ListCSharp> response = new List<ListCSharp>();

            var Lista = JsonConvert.DeserializeObject<List<ListCSharp>>(json);

            foreach (var item in Lista)
            {
                response.Add(item);
            }

            return response;

        }
    }
}
