﻿namespace KitsorLab.BuildingBlocks.EventBus.RabbitMQ
{
	using global::RabbitMQ.Client;
	using System;

	public interface IRabbitMQPersistentConnection : IDisposable
	{
		bool IsConnected { get; }

		bool TryConnect();

		IModel CreateModel();
	}
}
