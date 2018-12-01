using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StackPopV2(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFDataType elem_type, string operName=null)
		{
			return graph.StackPopV2(handle, elem_type, operName);
		}
	}
}
