using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueHoraEsEn
{
    internal class ZonaHorariaService
    {
        public DateTime GetFechaActualPorZonaHoraria(string zonaHorariaId)
        {
            var zonaHoraria = TimeZoneInfo.FindSystemTimeZoneById(zonaHorariaId);
            return TimeZoneInfo.ConvertTime(DateTime.Now, zonaHoraria);
        }
    }
}
