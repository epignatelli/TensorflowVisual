using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FakeQueue(this TFGraph graph, TensorFlow.TFOutput resource, string operName=null)
		{
			return graph.FakeQueue(resource, operName);
		}
	}
}
