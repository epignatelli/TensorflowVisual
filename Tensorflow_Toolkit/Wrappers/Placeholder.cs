using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Placeholder(TFGraph graph, TensorFlow.TFDataType dtype, TensorFlow.TFShape shape=null, string operName=null)
		{
			return graph.Placeholder(dtype, shape, operName);
		}
	}
}
