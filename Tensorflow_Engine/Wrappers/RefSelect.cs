using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RefSelect(this TFGraph graph, TensorFlow.TFOutput index, TensorFlow.TFOutput[] inputs, string operName=null)
		{
			return graph.RefSelect(index, inputs, operName);
		}
	}
}
