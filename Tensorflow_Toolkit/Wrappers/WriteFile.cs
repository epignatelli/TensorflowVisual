using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation WriteFile(TFGraph graph, TensorFlow.TFOutput filename, TensorFlow.TFOutput contents, string operName=null)
		{
			return graph.WriteFile(filename, contents, operName);
		}
	}
}
