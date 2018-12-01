using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Elu(TFGraph graph, TensorFlow.TFOutput features, string operName=null)
		{
			return graph.Elu(features, operName);
		}
	}
}