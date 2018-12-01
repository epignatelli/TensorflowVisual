using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SerializeTensor(TFGraph graph, TensorFlow.TFOutput tensor, string operName=null)
		{
			return graph.SerializeTensor(tensor, operName);
		}
	}
}
