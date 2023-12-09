using Producer_Consumer;
using System;
using System.Threading;

namespace YourNamespace
{
    public class Producer
    {
        // 定义事件来更新UI
        public event Action<int, int> Produced; // 参数1是生产者的ID，参数2是生产的数据

        private static Random random = new Random();
        private int producerId;
        private SharedResources sharedResources;

        public bool IsProducing { get; private set; } = false;

        public void StartProducing()
        {
            IsProducing = true;
        }

        public void StopProducing()
        {
            IsProducing = false;
        }

        // 修改构造函数以接收SharedResources参数
        public Producer(int id, SharedResources sharedResources)
        {
            this.producerId = id;
            this.sharedResources = sharedResources;
        }

        // 生成数据的方法
        public void ProduceData()
        {
            while (IsProducing)
            {
                int data = random.Next(1000);

                sharedResources.SaveData(data);

                Produced?.Invoke(producerId, data);

                Thread.Sleep(500);
            }
        }
    }
}
