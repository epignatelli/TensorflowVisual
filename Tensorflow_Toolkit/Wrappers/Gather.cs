using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Gather(TFGraph graph, TensorFlow.TFOutput parameters, TensorFlow.TFOutput indices, System.Boolean? validate_indices=null, string operName=null)
		{
			return graph.Gather(parameters, indices, validate_indices, operName);
		}
	}
}
