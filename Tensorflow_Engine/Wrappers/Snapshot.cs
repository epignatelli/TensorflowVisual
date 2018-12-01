using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Snapshot(this TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.Snapshot(input, operName);
		}
	}
}
