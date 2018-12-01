using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation SaveSlices(TFGraph graph, TensorFlow.TFOutput filename, TensorFlow.TFOutput tensor_names, TensorFlow.TFOutput shapes_and_slices, TensorFlow.TFOutput[] data, string operName=null)
		{
			return graph.SaveSlices(filename, tensor_names, shapes_and_slices, data, operName);
		}
	}
}
