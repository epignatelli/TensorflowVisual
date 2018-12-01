using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Log(this TFGraph graph, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Log(x, operName);
		}
	}
}
