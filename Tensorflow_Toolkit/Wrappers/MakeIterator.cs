using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation MakeIterator(TFGraph graph, TensorFlow.TFOutput dataset, TensorFlow.TFOutput iterator, string operName=null)
		{
			return graph.MakeIterator(dataset, iterator, operName);
		}
	}
}
