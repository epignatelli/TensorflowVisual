using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatchingFiles(TFGraph graph, TensorFlow.TFOutput pattern, string operName=null)
		{
			return graph.MatchingFiles(pattern, operName);
		}
	}
}
