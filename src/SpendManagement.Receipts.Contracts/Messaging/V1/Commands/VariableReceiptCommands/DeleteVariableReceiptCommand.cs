﻿using Contracts.Messaging.Interfaces;
using System.Runtime.Serialization;

namespace Contracts.Messaging.V1.Commands.VariableReceiptCommands
{
    public struct DeleteVariableReceiptCommand(Guid id) : ICommand
    {
        [IgnoreDataMember]
        public string RoutingKey { get; set; } = id.ToString();

        [IgnoreDataMember]
        public DateTime CommandCreatedDate { get; set; } = DateTime.UtcNow;

        [DataMember(Order = 1)]
        public Guid Id { get; set; } = id;
    }
}
