using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ScatterNdSub(this TFGraph graph, TensorFlow.TFOutput reference, TensorFlow.TFOutput indices, TensorFlow.TFOutput updates, System.Boolean? use_locking=null, string operName=null)
		{
			return graph.ScatterNdSub(reference, indices, updates, use_locking, operName);
		}
	}
}
