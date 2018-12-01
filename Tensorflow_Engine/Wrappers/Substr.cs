using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Substr(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput pos, TensorFlow.TFOutput len, string operName=null)
		{
			return graph.Substr(input, pos, len, operName);
		}
	}
}
