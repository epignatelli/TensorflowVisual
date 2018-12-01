using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFShape GetTensorShape(TFGraph graph, TensorFlow.TFOutput output, TensorFlow.TFStatus status=null)
		{
			return graph.GetTensorShape(output, status);
		}
	}
}
