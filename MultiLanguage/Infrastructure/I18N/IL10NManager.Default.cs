using System.Globalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace MultiLanguage.Infrastructure.I18N
{
    public class L10NManager : IL10NManager
    {
        private readonly RequestCulture _requestCulture;
        public L10NManager(IHttpContextAccessor accessor)
        {
            _requestCulture = accessor.HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture;
        }

        /// <summary>
        /// UI文化
        /// 确定<see cref="System.Resources.ResourceManager"/> 如何查找特定区域性资源文件（.resx 文件）。
        /// </summary>
        public CultureInfo UiCulture => _requestCulture.UICulture;

        /// <summary>
        /// 文化
        /// 1. 决定区域性相关函数的结果，如日期、时间、数字和货币格式等。
        /// 2. 确定文本的排序顺序、大小写约定和字符串比较。
        /// </summary>
        public CultureInfo Culture => _requestCulture.Culture;
    }
}
