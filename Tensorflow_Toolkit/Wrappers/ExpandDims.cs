using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ExpandDims(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput dim, string operName=null)
		{
			return graph.ExpandDims(input, dim, operName);
		}
	}
}
