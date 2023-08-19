using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_4devs_domain.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            
            if(field == null) return string.Empty;

            var attributes = field.GetCustomAttributes(false);
            dynamic? displayAttribute = null;
            if (attributes.Any())
            {
                displayAttribute = attributes.ElementAt(0);
            }
            return displayAttribute?.Description ?? string.Empty;
        }
    }
}
