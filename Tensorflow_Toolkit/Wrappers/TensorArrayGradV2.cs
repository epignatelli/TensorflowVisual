using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorArrayGradV2(TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput flow_in, string source, string operName=null)
		{
			return graph.TensorArrayGradV2(handle, flow_in, source, operName);
		}
	}
}
