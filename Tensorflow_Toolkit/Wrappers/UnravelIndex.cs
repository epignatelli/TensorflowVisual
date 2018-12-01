using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput UnravelIndex(TFGraph graph, TensorFlow.TFOutput indices, TensorFlow.TFOutput dims, string operName=null)
		{
			return graph.UnravelIndex(indices, dims, operName);
		}
	}
}
