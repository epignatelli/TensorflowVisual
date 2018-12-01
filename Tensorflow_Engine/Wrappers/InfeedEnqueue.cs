using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation InfeedEnqueue(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFShape shape=null, long? device_ordinal=null, string operName=null)
		{
			return graph.InfeedEnqueue(input, shape, device_ordinal, operName);
		}
	}
}
