using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation GcsConfigureCredentials(TFGraph graph, TensorFlow.TFOutput json, string operName=null)
		{
			return graph.GcsConfigureCredentials(json, operName);
		}
	}
}
