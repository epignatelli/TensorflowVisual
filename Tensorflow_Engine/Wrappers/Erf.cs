using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Erf(this TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Erf(x, operName);
		}
	}
}
