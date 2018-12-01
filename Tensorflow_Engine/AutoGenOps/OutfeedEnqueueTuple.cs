using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation OutfeedEnqueueTuple(this TFGraph graph, TensorFlow.TFOutput[] inputs, string operName=null)
		{
			return graph.OutfeedEnqueueTuple(inputs, operName);
		}
	}
}
