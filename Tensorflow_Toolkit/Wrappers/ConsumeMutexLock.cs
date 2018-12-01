using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ConsumeMutexLock(TFGraph graph, TensorFlow.TFOutput mutex_lock, string operName=null)
		{
			return graph.ConsumeMutexLock(mutex_lock, operName);
		}
	}
}
