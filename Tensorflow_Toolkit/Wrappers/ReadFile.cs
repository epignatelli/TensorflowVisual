using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ReadFile(TFGraph graph, TensorFlow.TFOutput filename, string operName=null)
		{
			return graph.ReadFile(filename, operName);
		}
	}
}
