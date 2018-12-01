using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ConditionalAccumulator(TFGraph graph, TensorFlow.TFDataType dtype, TensorFlow.TFShape shape, string container=null, string shared_name=null, string operName=null)
		{
			return graph.ConditionalAccumulator(dtype, shape, container, shared_name, operName);
		}
	}
}
