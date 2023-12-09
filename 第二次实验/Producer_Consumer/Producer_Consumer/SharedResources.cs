using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer_Consumer
{
    public class SharedResources
    {
        // 使用Queue保存数据，代表缓冲区
        private Queue<int> dataQueue = new Queue<int>();
        public Queue<int> DataQueue => dataQueue;

        public event Action DataChanged;


        // 定义信号量
        private Semaphore semaphore = new Semaphore(0, int.MaxValue); 

        // 添加数据
        public void SaveData(int data)
        {

            lock (dataQueue) 
            {
                dataQueue.Enqueue(data);  
                semaphore.Release();  
            }
            DataChanged?.Invoke();
        }

        // 获取数据
        public int? ConsumeData()
        {
            int? consumedData = null;

            semaphore.WaitOne();

            lock (dataQueue)
            {
                if (dataQueue.Count > 0)
                {
                    consumedData = dataQueue.Dequeue();
                }
            }

            DataChanged?.Invoke();
            return consumedData;
        }

    }
}
