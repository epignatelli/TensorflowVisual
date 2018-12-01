using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ApproximateEqual(TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput y, System.Single? tolerance=null, string operName=null)
		{
			return graph.ApproximateEqual(x, y, tolerance, operName);
		}
	}
}
