using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput IsFinite(this TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.IsFinite(x, operName);
		}
	}
}
