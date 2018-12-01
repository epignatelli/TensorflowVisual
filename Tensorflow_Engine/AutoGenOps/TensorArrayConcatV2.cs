using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> TensorArrayConcatV2(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput flow_in, TensorFlow.TFDataType dtype, TensorFlow.TFShape element_shape_except0=null, string operName=null)
		{
			return graph.TensorArrayConcatV2(handle, flow_in, dtype, element_shape_except0, operName);
		}
	}
}
