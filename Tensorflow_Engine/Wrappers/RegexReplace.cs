using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RegexReplace(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput pattern, TensorFlow.TFOutput rewrite, System.Boolean? replace_global=null, string operName=null)
		{
			return graph.RegexReplace(input, pattern, rewrite, replace_global, operName);
		}
	}
}
