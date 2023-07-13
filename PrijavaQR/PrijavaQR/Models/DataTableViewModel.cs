namespace PrijavaQR.Models
{
    public class DataTableViewModel
    {
        public int idStatus { get; set; }

        public List<string> StatusList { get; set; } = new List<string> { "Nije plaćeno", "U tijeku", "Plaćeno" };
    }
}
