using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation OutfeedEnqueue(TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.OutfeedEnqueue(input, operName);
		}
	}
}
