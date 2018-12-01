using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation BarrierInsertMany(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput keys, TensorFlow.TFOutput values, long component_index, string operName=null)
		{
			return graph.BarrierInsertMany(handle, keys, values, component_index, operName);
		}
	}
}
