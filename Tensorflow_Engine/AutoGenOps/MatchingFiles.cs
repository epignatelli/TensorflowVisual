using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MatchingFiles(this TFGraph graph, TensorFlow.TFOutput pattern, string operName=null)
		{
			return graph.MatchingFiles(pattern, operName);
		}
	}
}
