using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StackPop(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFDataType elem_type, string operName=null)
		{
			return graph.StackPop(handle, elem_type, operName);
		}
	}
}
