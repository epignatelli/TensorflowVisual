using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DiagPart(this TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.DiagPart(input, operName);
		}
	}
}
