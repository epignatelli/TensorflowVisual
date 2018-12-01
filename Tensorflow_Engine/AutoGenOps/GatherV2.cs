using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GatherV2(this TFGraph graph, TensorFlow.TFOutput parameters, TensorFlow.TFOutput indices, TensorFlow.TFOutput axis, string operName=null)
		{
			return graph.GatherV2(parameters, indices, axis, operName);
		}
	}
}
