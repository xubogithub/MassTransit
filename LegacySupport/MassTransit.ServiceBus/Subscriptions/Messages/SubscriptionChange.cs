/// Copyright 2007-2008 The Apache Software Foundation.
/// 
/// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
/// this file except in compliance with the License. You may obtain a copy of the 
/// License at 
/// 
///   http://www.apache.org/licenses/LICENSE-2.0 
/// 
/// Unless required by applicable law or agreed to in writing, software distributed 
/// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
/// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
/// specific language governing permissions and limitations under the License.
namespace MassTransit.ServiceBus.Subscriptions.Messages
{
	using System;

	[Serializable]
	public abstract class SubscriptionChange
	{
		private readonly Subscription _subscription;

		//xml serialization
		protected SubscriptionChange()
		{
		}

		public SubscriptionChange(string messageName, Uri address)
			: this(new Subscription(messageName, address))
		{
		}

		public SubscriptionChange(Subscription subscription)
		{
			_subscription = subscription;
		}

		public Subscription Subscription
		{
			get { return _subscription; }
		}
	}
}