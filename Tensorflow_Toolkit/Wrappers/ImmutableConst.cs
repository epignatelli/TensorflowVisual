using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ImmutableConst(TFGraph graph, TensorFlow.TFDataType dtype, TensorFlow.TFShape shape, string memory_region_name, string operName=null)
		{
			return graph.ImmutableConst(dtype, shape, memory_region_name, operName);
		}
	}
}
