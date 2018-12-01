using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StackV2(TFGraph graph, TensorFlow.TFOutput max_size, TensorFlow.TFDataType elem_type, string stack_name=null, string operName=null)
		{
			return graph.StackV2(max_size, elem_type, stack_name, operName);
		}
	}
}
