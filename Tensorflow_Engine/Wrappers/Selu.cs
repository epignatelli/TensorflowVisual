using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Selu(this TFGraph graph, TensorFlow.TFOutput features, string operName=null)
		{
			return graph.Selu(features, operName);
		}
	}
}
