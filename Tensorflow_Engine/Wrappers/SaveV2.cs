using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation SaveV2(this TFGraph graph, TensorFlow.TFOutput prefix, TensorFlow.TFOutput tensor_names, TensorFlow.TFOutput shape_and_slices, TensorFlow.TFOutput[] tensors, string operName=null)
		{
			return graph.SaveV2(prefix, tensor_names, shape_and_slices, tensors, operName);
		}
	}
}
