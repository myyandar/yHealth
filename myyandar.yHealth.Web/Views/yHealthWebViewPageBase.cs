using Abp.Web.Mvc.Views;

namespace myyandar.yHealth.Web.Views
{
    public abstract class yHealthWebViewPageBase : yHealthWebViewPageBase<dynamic>
    {

    }

    public abstract class yHealthWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected yHealthWebViewPageBase()
        {
            LocalizationSourceName = yHealthConsts.LocalizationSourceName;
        }
    }
}