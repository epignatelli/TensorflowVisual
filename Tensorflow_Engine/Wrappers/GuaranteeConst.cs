using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GuaranteeConst(this TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.GuaranteeConst(input, operName);
		}
	}
}
