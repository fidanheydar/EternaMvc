using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class HomeViewModel
    {
        public List<Slide> Slides { get; set; }
        public List<Client> Clients { get; set; }
        public List<Service> Services { get; set; }
        public List<Feature> Features { get; set; }
    }
}
