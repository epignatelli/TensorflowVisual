using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Stack(TFGraph graph, TensorFlow.TFDataType elem_type, string stack_name=null, string operName=null)
		{
			return graph.Stack(elem_type, stack_name, operName);
		}
	}
}
