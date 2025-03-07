using System.Threading.Tasks;
using SpotifyAPI.Web.Http;
using URLs = SpotifyAPI.Web.SpotifyUrls;

namespace SpotifyAPI.Web
{
  public class MarketsClient : APIClient, IMarketsClient
  {
    public MarketsClient(IAPIConnector apiConnector) : base(apiConnector) { }

    public Task<AvailableMarketsResponse> AvailableMarkets()
    {
      return API.Get<AvailableMarketsResponse>(URLs.Markets());
    }
  }
}
