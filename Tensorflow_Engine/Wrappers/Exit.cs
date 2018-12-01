using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Exit(this TFGraph graph, TensorFlow.TFOutput data, string operName=null)
		{
			return graph.Exit(data, operName);
		}
	}
}
