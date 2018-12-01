using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.Variable Variable(TFGraph graph, TensorFlow.TFOutput initialValue, System.Boolean trainable=True, string operName=null)
		{
			return graph.Variable(initialValue, trainable, operName);
		}
	}
}
