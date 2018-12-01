using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Size(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFDataType? out_type=null, string operName=null)
		{
			return graph.Size(input, out_type, operName);
		}
	}
}
