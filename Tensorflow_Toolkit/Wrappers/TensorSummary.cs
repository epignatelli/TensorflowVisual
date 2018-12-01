using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorSummary(TFGraph graph, TensorFlow.TFOutput tensor, string description=null, string[] labels=null, string display_name=null, string operName=null)
		{
			return graph.TensorSummary(tensor, description, labels, display_name, operName);
		}
	}
}
