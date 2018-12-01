using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput BarrierReadySize(this TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.BarrierReadySize(handle, operName);
		}
	}
}
