using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseConditionalAccumulator(this TFGraph graph, TensorFlow.TFDataType dtype, TensorFlow.TFShape shape, string container=null, string shared_name=null, string operName=null)
		{
			return graph.SparseConditionalAccumulator(dtype, shape, container, shared_name, operName);
		}
	}
}
