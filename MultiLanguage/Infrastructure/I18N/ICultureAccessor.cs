using Microsoft.AspNetCore.Localization;
using System.Collections.Generic;
using System.Globalization;

namespace MultiLanguage.Infrastructure.I18N
{
    /// <summary>
    /// 区域性访问器
    /// </summary>
    public interface ICultureAccessor
    {
        IList<CultureInfo> SupportedCultures { get; }
        IList<CultureInfo> SupportedUICultures { get; }
        RequestCulture RequestCulture { get; set; }
    }
}
