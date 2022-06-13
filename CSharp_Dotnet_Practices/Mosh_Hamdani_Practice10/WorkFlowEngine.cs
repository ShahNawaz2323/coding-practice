namespace Mosh_Hamdani_Practice10
{
    public class WorkFlowEngine
    {
        private IList<IActivity> _Activity;
        
        public WorkFlowEngine()
        {
            _Activity = new List<IActivity>();
        }

        public void Run()
        {
            foreach (var Activity in _Activity)
            {
                Activity.Execute();
            }
        }
        public void RegisterActivity(IActivity Activity)
        {
            _Activity.Add(Activity);
        }

    }
}
