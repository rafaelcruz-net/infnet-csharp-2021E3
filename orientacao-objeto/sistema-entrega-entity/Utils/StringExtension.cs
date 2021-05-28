using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_entrega_entity.Utils
{
    public static class StringExtension
    {
        public static String FormataNome(this string nome)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome);
        }
    }
}
