using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Cond(this TFGraph graph, TensorFlow.TFOutput pred, Func<TensorFlow.TFOutput> true_fn, Func<TensorFlow.TFOutput> false_fn, string operName=null)
		{
			return graph.Cond(pred, true_fn, false_fn, operName);
		}
	}
}
