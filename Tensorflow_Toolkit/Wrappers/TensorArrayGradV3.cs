using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> TensorArrayGradV3(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput flow_in, string source, string operName=null)
		{
			return graph.TensorArrayGradV3(handle, flow_in, source, operName);
		}
	}
}
