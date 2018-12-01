using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput InfeedDequeue(TFGraph graph, TensorFlow.TFDataType dtype, TensorFlow.TFShape shape, string operName=null)
		{
			return graph.InfeedDequeue(dtype, shape, operName);
		}
	}
}
