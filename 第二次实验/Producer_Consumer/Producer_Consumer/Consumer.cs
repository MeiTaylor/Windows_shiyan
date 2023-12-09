using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer
{
    public class Consumer
    {
        private SharedResources sharedResources;
        private Action<string> updateUIAction; 

        private bool _isConsuming = false; 

        public Consumer(SharedResources sharedResources, Action<string> updateUIAction)
        {
            this.sharedResources = sharedResources;
            this.updateUIAction = updateUIAction;
        }

        public void ConsumeData()
        {
            while (_isConsuming)
            {
                int? data = sharedResources.ConsumeData();
                if (data.HasValue)
                {
                    updateUIAction($"{data.Value}");
                    Thread.Sleep(500);
                }
            }

        }

        public void StartConsuming()
        {
            _isConsuming = true;
        }

        public void StopConsuming()
        {
            _isConsuming = false;
        }

        public bool IsConsuming => _isConsuming;
    }
}
