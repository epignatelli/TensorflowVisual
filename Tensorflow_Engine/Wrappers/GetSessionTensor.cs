using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GetSessionTensor(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFDataType dtype, string operName=null)
		{
			return graph.GetSessionTensor(handle, dtype, operName);
		}
	}
}
