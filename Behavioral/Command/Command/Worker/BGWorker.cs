namespace Command.Worker
{
    public static class BGWorker
    {
        public static async void BgRunner()
        {
            _ = Task.Run(async () =>
            {
                do
                {
                    await Task.Delay(2000);
                    if (Invoker.Invoker.GetList().Any())
                    {
                        while (Invoker.Invoker.GetList().Any())
                        {
                            var item = Invoker.Invoker.GetList().Dequeue();
                            Invoker.Invoker.ExecuteCMD(item);
                        }
                    }
                } while (true);
            });
        }
    }
}
