using System.ComponentModel;

namespace desafio_4devs_domain.Enums
{
    public enum EOrganizationCategoryReview
    {
        [Description("Nenhum")]
        None = 0,
        [Description("Promotor")]
        Promoter = 1,
        [Description("Neutro")]
        Neutral = 2,
        [Description("Detrator")]
        Detractor = 3        
    }
}
