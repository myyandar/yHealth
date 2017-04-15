using Xunit;

namespace myyandar.yHealth.Tests
{
    public sealed class MultiTenantFactAttribute : FactAttribute
    {
        public MultiTenantFactAttribute()
        {
            if (!yHealthConsts.MultiTenancyEnabled)
            {
#pragma warning disable CS0162 // Unreachable code detected
                Skip = "MultiTenancy is disabled.";
#pragma warning restore CS0162 // Unreachable code detected
            }
        }
    }
}
