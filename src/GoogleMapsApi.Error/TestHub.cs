using System.Threading.Tasks;
using GoogleMapsApi.Entities.PlacesText.Request;
using GoogleMapsApi.Entities.PlacesText.Response;
using Microsoft.AspNet.SignalR;

namespace GoogleMapsApi.Error
{
    public class TestHub : Hub
    {
        private readonly PlacesTextRequest _request;

        public TestHub()
        {
            _request = new PlacesTextRequest()
            {
                ApiKey = "{need-api-key}",
                Query = "Cineworld"
            };
            
        }

        public async Task<PlacesTextResponse> SearchGooglePlacesAsync()
        {
            return await GoogleMaps.PlacesText.QueryAsync(_request).ConfigureAwait(false);
        }

        public PlacesTextResponse SearchGooglePlacesSync()
        {
            return GoogleMaps.PlacesText.Query(_request);
        }
    }
}
