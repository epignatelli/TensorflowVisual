using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation Save(TFGraph graph, TensorFlow.TFOutput filename, TensorFlow.TFOutput tensor_names, TensorFlow.TFOutput[] data, string operName=null)
		{
			return graph.Save(filename, tensor_names, data, operName);
		}
	}
}
