using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] StagePeek(this TFGraph graph, TensorFlow.TFOutput index, TensorFlow.TFDataType[] dtypes, long? capacity=null, long? memory_limit=null, string container=null, string shared_name=null, string operName=null)
		{
			return graph.StagePeek(index, dtypes, capacity, memory_limit, container, shared_name, operName);
		}
	}
}
