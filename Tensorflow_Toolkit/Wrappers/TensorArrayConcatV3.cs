using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> TensorArrayConcatV3(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput flow_in, TensorFlow.TFDataType dtype, TensorFlow.TFShape element_shape_except0=null, string operName=null)
		{
			return graph.TensorArrayConcatV3(handle, flow_in, dtype, element_shape_except0, operName);
		}
	}
}
