using System;
using EPiServer;
using EPiServer.Core;
using EPiServer.PlugIn;
using EPiServer.Scheduler;
using EPiServer.ServiceLocation;

namespace Scheduler_Copy.Business
{
    [ScheduledPlugIn(DisplayName = "CreatePages")]
    public class CreatePages : ScheduledJobBase
    {
        private bool _stopSignaled;

        public CreatePages()
        {
            IsStoppable = true;
        }

        /// <summary>
        /// Called when a user clicks on Stop for a manually started job, or when ASP.NET shuts down.
        /// </summary>
        public override void Stop()
        {
            _stopSignaled = true;
        }

        /// <summary>
        /// Called when a scheduled job executes
        /// </summary>
        /// <returns>A status message to be stored in the database log and visible from admin mode</returns>
        public override string Execute()
        {
            //Call OnStatusChanged to periodically notify progress of job for manually started jobs
            OnStatusChanged(String.Format("Starting execution of {0}", this.GetType()));
            //Add implementation

            var repo = ServiceLocator.Current.GetInstance<IContentRepository>();
            var page = repo.GetDefault<Models.Pages.StandardPage>(ContentReference.RootPage);
            page.Name = "TestPage";
            page.StandardHeading = "Heading";
            page.StandardMainBody = new XhtmlString("MainBody");
            //repo.Save(page, EPiServer.DataAccess.SaveAction.Publish);
            repo.Save(page, EPiServer.DataAccess.SaveAction.Publish, EPiServer.Security.AccessLevel.NoAccess);


            //For long running jobs periodically check if stop is signaled and if so stop execution
            if (_stopSignaled)
            {
                return "Stop of job was called";
            }
            return "Change to message that describes outcome of execution";
        }
    }
}
