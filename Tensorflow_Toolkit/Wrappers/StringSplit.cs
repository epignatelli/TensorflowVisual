using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> StringSplit(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput delimiter, System.Boolean? skip_empty=null, string operName=null)
		{
			return graph.StringSplit(input, delimiter, skip_empty, operName);
		}
	}
}