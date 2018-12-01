using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation InfeedEnqueueTuple(TFGraph graph, TensorFlow.TFOutput[] inputs, TensorFlow.TFShape[] shapes, long? device_ordinal=null, string operName=null)
		{
			return graph.InfeedEnqueueTuple(inputs, shapes, device_ordinal, operName);
		}
	}
}
