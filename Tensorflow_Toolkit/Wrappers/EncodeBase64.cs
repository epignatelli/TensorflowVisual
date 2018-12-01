using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput EncodeBase64(TFGraph graph, TensorFlow.TFOutput input, System.Boolean? pad=null, string operName=null)
		{
			return graph.EncodeBase64(input, pad, operName);
		}
	}
}
