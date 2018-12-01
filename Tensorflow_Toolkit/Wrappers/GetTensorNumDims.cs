using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static int GetTensorNumDims(TFGraph graph, TensorFlow.TFOutput output, TensorFlow.TFStatus status=null)
		{
			return graph.GetTensorNumDims(output, status);
		}
	}
}
