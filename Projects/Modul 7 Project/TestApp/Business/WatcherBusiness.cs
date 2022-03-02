using Data;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class WatcherBusiness
    {
        private WatcherContext watcherContext = null;
        public List<Watcher> GetAll()
        {
            using (watcherContext = new WatcherContext())
            {
                return watcherContext.Watchers.ToList();
            }
        }

        public void Add(Watcher watcher)
        {
            using (watcherContext = new WatcherContext())
            {
                watcherContext.Watchers.Add(watcher);
                watcherContext.SaveChanges();
            }
        }
    }
}
