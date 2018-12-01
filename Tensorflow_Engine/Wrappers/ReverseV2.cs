using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReverseV2(this TFGraph graph, TensorFlow.TFOutput tensor, TensorFlow.TFOutput axis, string operName=null)
		{
			return graph.ReverseV2(tensor, axis, operName);
		}
	}
}
