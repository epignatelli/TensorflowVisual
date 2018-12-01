using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Bucketize(TFGraph graph, TensorFlow.TFOutput input, System.Single[] boundaries, string operName=null)
		{
			return graph.Bucketize(input, boundaries, operName);
		}
	}
}
