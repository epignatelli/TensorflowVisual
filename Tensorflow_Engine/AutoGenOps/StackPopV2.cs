using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StackPopV2(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFDataType elem_type, string operName=null)
		{
			return graph.StackPopV2(handle, elem_type, operName);
		}
	}
}
