﻿using NServiceBus.Saga;

namespace Receiver
{
    public class OrderLifecycleSagaData : ContainSagaData
    {
        public virtual string OrderId { get; set; }
    }
}