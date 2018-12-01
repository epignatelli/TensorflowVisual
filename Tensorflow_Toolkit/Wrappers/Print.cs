using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Print(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput[] data, string message=null, long? first_n=null, long? summarize=null, string operName=null)
		{
			return graph.Print(input, data, message, first_n, summarize, operName);
		}
	}
}
