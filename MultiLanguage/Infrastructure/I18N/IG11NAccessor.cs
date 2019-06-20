using System.Collections.Generic;
using System.Globalization;

namespace MultiLanguage.Infrastructure.I18N
{
    public interface IG11NAccessor
    {
        IList<CultureInfo> SupportedCultures { get; }
        IList<CultureInfo> SupportedUICultures { get; }
    }
}
