using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Softsign(TFGraph graph, TensorFlow.TFOutput features, string operName=null)
		{
			return graph.Softsign(features, operName);
		}
	}
}
