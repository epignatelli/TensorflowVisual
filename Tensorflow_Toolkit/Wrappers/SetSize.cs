using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SetSize(TFGraph graph, TensorFlow.TFOutput set_indices, TensorFlow.TFOutput set_values, TensorFlow.TFOutput set_shape, System.Boolean? validate_indices=null, string operName=null)
		{
			return graph.SetSize(set_indices, set_values, set_shape, validate_indices, operName);
		}
	}
}
