using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MutexLock(this TFGraph graph, TensorFlow.TFOutput mutex, string operName=null)
		{
			return graph.MutexLock(mutex, operName);
		}
	}
}
