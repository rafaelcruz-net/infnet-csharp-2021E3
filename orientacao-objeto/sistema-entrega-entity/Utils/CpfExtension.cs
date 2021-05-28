using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_entrega_entity.Utils
{
    public static class CpfExtension
    {
        public static String FormataCPF(this Int64 numero)
        {
            return String.Format(@"{0:000\.000\.000\-00}", numero);
        }
    }
}
