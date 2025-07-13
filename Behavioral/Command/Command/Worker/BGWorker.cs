namespace Command.Worker
{
    public static class BGWorker
    {
        public static async Task BgRunner()
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
                            await item.Execute();
                        }
                    }
                } while (true);
            });
        }
    }
}
