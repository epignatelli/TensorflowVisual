using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedResizeBilinear(this TFGraph graph, TensorFlow.TFOutput images, TensorFlow.TFOutput size, TensorFlow.TFOutput min, TensorFlow.TFOutput max, System.Boolean? align_corners=null, string operName=null)
		{
			return graph.QuantizedResizeBilinear(images, size, min, max, align_corners, operName);
		}
	}
}
