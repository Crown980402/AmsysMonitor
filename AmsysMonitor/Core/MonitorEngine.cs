using AmsysMonitor.Models;
using AmsysMonitor.Services;

namespace AmsysMonitor.Core
{
    public class MonitorEngine
    {
        private readonly ProcessWatcher watcher;

        public MonitorEngine(MonitorSetting setting)
        {
            watcher = new ProcessWatcher(setting);
        }

        public void Check()
        {
            watcher.Check();
        }
    }
}