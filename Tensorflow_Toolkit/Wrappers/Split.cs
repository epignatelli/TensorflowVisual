using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] Split(TFGraph graph, TensorFlow.TFOutput split_dim, TensorFlow.TFOutput value, long num_split, string operName=null)
		{
			return graph.Split(split_dim, value, num_split, operName);
		}
	}
}
