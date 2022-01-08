namespace AuphonicApi.Models
{
    public class Algorithms
    {
        public bool Hipfilter { get; set; }
        public bool Normloudness { get; set; }
        public bool Denoise { get; set; }
        public bool Leveler { get; set; }
        public int Loudnesstarget { get; set; }
        public int Denoiseamount { get; set; }
    }
}