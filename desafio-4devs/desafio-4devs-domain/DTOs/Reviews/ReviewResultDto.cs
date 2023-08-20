using desafio_4devs_domain.Enums;
using desafio_4devs_domain.Extensions;
using desafio_4devs_domain.Models;

namespace desafio_4devs_domain.DTOs.Reviews
{
    public class ReviewResultDto
    {
        public int Promoters { get; set; }
        public int Neutrals { get; set; }
        public int Detractors { get; set; }
        public double Total { get {  return Promoters + Neutrals + Detractors; } }
        public double Nps { get { return Math.Round(((Promoters - Detractors) / Total) * 100, 0); } }
        public ENpsResultColor ResultColor { 
            get 
            { 
                return Nps >= 80 
                    ? ENpsResultColor.Green 
                    : Nps >= 60 
                        ? ENpsResultColor.Yellow 
                        : ENpsResultColor.Red; 
            } 
        }
        public string ResultColorDescription { get { return ResultColor.GetDescription(); } }

        public ReviewResultDto(List<Review> reviews)
        {
            Promoters = reviews.Where(r => r.Rating >= 9).Count();
            Neutrals = reviews.Where(r => r.Rating >= 7 && r.Rating <= 8).Count();
            Detractors = reviews.Where(r => r.Rating <= 6).Count();
        }

    }
}
