using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput UnbatchGrad(this TFGraph graph, TensorFlow.TFOutput original_input, TensorFlow.TFOutput batch_index, TensorFlow.TFOutput grad, TensorFlow.TFOutput id, string container=null, string shared_name=null, string operName=null)
		{
			return graph.UnbatchGrad(original_input, batch_index, grad, id, container, shared_name, operName);
		}
	}
}
