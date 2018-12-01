using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> Merge(this TFGraph graph, TensorFlow.TFOutput[] inputs, string operName=null)
		{
			return graph.Merge(inputs, operName);
		}
	}
}
