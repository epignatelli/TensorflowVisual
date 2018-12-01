using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RefEnter(TFGraph graph, TensorFlow.TFOutput data, string frame_name, System.Boolean? is_constant=null, long? parallel_iterations=null, string operName=null)
		{
			return graph.RefEnter(data, frame_name, is_constant, parallel_iterations, operName);
		}
	}
}
