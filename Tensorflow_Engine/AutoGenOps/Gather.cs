using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Gather(this TFGraph graph, TensorFlow.TFOutput parameters, TensorFlow.TFOutput indices, System.Boolean? validate_indices=null, string operName=null)
		{
			return graph.Gather(parameters, indices, validate_indices, operName);
		}
	}
}
