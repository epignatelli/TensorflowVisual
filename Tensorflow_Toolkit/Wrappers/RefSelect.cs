using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RefSelect(TFGraph graph, TensorFlow.TFOutput index, TensorFlow.TFOutput[] inputs, string operName=null)
		{
			return graph.RefSelect(index, inputs, operName);
		}
	}
}
