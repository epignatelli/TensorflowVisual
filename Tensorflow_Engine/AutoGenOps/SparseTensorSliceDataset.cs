using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseTensorSliceDataset(this TFGraph graph, TensorFlow.TFOutput indices, TensorFlow.TFOutput values, TensorFlow.TFOutput dense_shape, string operName=null)
		{
			return graph.SparseTensorSliceDataset(indices, values, dense_shape, operName);
		}
	}
}
