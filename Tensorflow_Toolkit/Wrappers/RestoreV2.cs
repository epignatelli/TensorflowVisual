using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] RestoreV2(TFGraph graph, TensorFlow.TFOutput prefix, TensorFlow.TFOutput tensor_names, TensorFlow.TFOutput shape_and_slices, TensorFlow.TFDataType[] dtypes, string operName=null)
		{
			return graph.RestoreV2(prefix, tensor_names, shape_and_slices, dtypes, operName);
		}
	}
}
