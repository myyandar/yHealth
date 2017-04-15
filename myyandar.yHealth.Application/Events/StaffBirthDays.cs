using Abp.Application.Services;
using Abp.Events.Bus;

namespace myyandar.yHealth.Events
{
    class StaffBirthDaysAppService : ApplicationService
    {
        public IEventBus EventBus { get; set; }

        public StaffBirthDaysAppService()
        {
            EventBus = NullEventBus.Instance;
        }
    }
}