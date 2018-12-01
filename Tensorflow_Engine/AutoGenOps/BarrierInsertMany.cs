using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation BarrierInsertMany(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput keys, TensorFlow.TFOutput values, long component_index, string operName=null)
		{
			return graph.BarrierInsertMany(handle, keys, values, component_index, operName);
		}
	}
}
