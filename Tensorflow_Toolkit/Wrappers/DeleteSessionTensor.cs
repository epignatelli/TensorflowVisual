using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation DeleteSessionTensor(TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.DeleteSessionTensor(handle, operName);
		}
	}
}
