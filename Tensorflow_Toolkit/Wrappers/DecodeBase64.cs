using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodeBase64(TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.DecodeBase64(input, operName);
		}
	}
}
