using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SoftsignGrad(TFGraph graph, TensorFlow.TFOutput gradients, TensorFlow.TFOutput features, string operName=null)
		{
			return graph.SoftsignGrad(gradients, features, operName);
		}
	}
}
