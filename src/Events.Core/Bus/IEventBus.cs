﻿namespace Events.Core.Bus
{
    public interface IEventBus : IDisposable
    {
        void Subscribe<TEvent>(Func<TEvent, Task> handler) where TEvent : class;

        void Unsubscribe<TEvent>(Func<TEvent, Task> handler) where TEvent : class;

        Task PublishAsync<TEvent>(
            TEvent @event, 
            int priority = 0,
            DateTimeOffset? scheduledEnqueueTime = null, 
            CancellationToken cancellationToken = default) where TEvent : class;

        Task StartAsync();
        Task StopAsync();
    }
}
