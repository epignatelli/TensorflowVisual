using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Softplus(this TFGraph graph, TensorFlow.TFOutput features, string operName=null)
		{
			return graph.Softplus(features, operName);
		}
	}
}
