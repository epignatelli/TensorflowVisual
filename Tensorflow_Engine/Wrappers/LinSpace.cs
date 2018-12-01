using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LinSpace(this TFGraph graph, TensorFlow.TFOutput start, TensorFlow.TFOutput stop, TensorFlow.TFOutput num, string operName=null)
		{
			return graph.LinSpace(start, stop, num, operName);
		}
	}
}
