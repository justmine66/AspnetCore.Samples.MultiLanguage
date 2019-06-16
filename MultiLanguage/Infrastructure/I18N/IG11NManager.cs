using System.Collections.Generic;
using System.Globalization;

namespace MultiLanguage.Infrastructure.I18N
{
    public interface IG11NManager
    {
        IList<CultureInfo> SupportedCultures { get; }
        IList<CultureInfo> SupportedUICultures { get; }
    }
}
