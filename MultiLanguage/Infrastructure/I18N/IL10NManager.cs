using System.Globalization;

namespace MultiLanguage.Infrastructure.I18N
{
    public interface IL10NManager
    {
        CultureInfo UiCulture { get; }
        CultureInfo Culture { get; }
    }
}
