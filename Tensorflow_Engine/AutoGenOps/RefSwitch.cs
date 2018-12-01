using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput> RefSwitch(this TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput pred, string operName=null)
		{
			return graph.RefSwitch(data, pred, operName);
		}
	}
}
