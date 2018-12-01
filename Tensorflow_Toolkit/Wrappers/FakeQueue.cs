using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FakeQueue(TFGraph graph, TensorFlow.TFOutput resource, string operName=null)
		{
			return graph.FakeQueue(resource, operName);
		}
	}
}
