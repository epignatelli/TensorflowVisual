using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFFunction ToFunction(TFGraph graph, string functionName, string description, TensorFlow.TFOperation[] operations, TensorFlow.TFOutput[] inputs, TensorFlow.TFOutput[] outputs, string[] outputNames, System.Boolean appendHashToFunctionName=False, TensorFlow.TFStatus status=null)
		{
			return graph.ToFunction(functionName, description, operations, inputs, outputs, outputNames, appendHashToFunctionName, status);
		}
	}
}
