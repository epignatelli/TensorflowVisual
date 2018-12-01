using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ResourceGather(TFGraph graph, TensorFlow.TFOutput resource, TensorFlow.TFOutput indices, TensorFlow.TFDataType dtype, System.Boolean? validate_indices=null, string operName=null)
		{
			return graph.ResourceGather(resource, indices, dtype, validate_indices, operName);
		}
	}
}
