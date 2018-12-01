using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodeJSONExample(TFGraph graph, TensorFlow.TFOutput json_examples, string operName=null)
		{
			return graph.DecodeJSONExample(json_examples, operName);
		}
	}
}
