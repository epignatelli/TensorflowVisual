using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Fill(this TFGraph graph, TensorFlow.TFOutput dims, TensorFlow.TFOutput value, string operName=null)
		{
			return graph.Fill(dims, value, operName);
		}
	}
}
