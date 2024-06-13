namespace PaparaIntegration.Models.Response.Account
{
    public class Data
    {
        public ICollection<Items> items { get; set; }

        public int page { get; set; }

        public int pageItemCount { get; set; }

        public int totalItemCount { get; set; }

        public int totalPageCount { get; set; }

        public int pageSkip { get; set; }
    }

    

}