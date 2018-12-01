using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DestroyTemporaryVariable(TFGraph graph, TensorFlow.TFOutput reference, string var_name, string operName=null)
		{
			return graph.DestroyTemporaryVariable(reference, var_name, operName);
		}
	}
}
