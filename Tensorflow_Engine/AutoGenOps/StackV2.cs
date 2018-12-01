using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StackV2(this TFGraph graph, TensorFlow.TFOutput max_size, TensorFlow.TFDataType elem_type, string stack_name=null, string operName=null)
		{
			return graph.StackV2(max_size, elem_type, stack_name, operName);
		}
	}
}
