using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] AddGradients(this TFGraph graph, string prefix, TensorFlow.TFOutput[] y, TensorFlow.TFOutput[] x, TensorFlow.TFOutput[] dx=null, TensorFlow.TFStatus status=null)
		{
			return graph.AddGradients(prefix, y, x, dx, status);
		}
	}
}
