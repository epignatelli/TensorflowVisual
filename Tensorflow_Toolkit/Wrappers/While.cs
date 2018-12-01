using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] While(TFGraph graph, TensorFlow.TFOutput[] inputs, TensorFlow.TFGraph+WhileConstructor constructor, TensorFlow.TFStatus status=null)
		{
			return graph.While(inputs, constructor, status);
		}
	}
}
