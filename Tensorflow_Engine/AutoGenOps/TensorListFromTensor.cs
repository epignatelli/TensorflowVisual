using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorListFromTensor(this TFGraph graph, TensorFlow.TFOutput tensor, TensorFlow.TFOutput element_shape, string operName=null)
		{
			return graph.TensorListFromTensor(tensor, element_shape, operName);
		}
	}
}
