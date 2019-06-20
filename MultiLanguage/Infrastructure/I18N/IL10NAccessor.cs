using System.Globalization;

namespace MultiLanguage.Infrastructure.I18N
{
    public interface IL10NAccessor
    {
        CultureInfo UiCulture { get; }
        CultureInfo Culture { get; }
    }
}
