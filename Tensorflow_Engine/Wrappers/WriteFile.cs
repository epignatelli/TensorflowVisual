using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation WriteFile(this TFGraph graph, TensorFlow.TFOutput filename, TensorFlow.TFOutput contents, string operName=null)
		{
			return graph.WriteFile(filename, contents, operName);
		}
	}
}
