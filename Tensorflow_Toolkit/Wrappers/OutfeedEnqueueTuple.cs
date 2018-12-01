using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation OutfeedEnqueueTuple(TFGraph graph, TensorFlow.TFOutput[] inputs, string operName=null)
		{
			return graph.OutfeedEnqueueTuple(inputs, operName);
		}
	}
}
