using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> SampleDistortedBoundingBoxV2(this TFGraph graph, TensorFlow.TFOutput image_size, TensorFlow.TFOutput bounding_boxes, TensorFlow.TFOutput min_object_covered, long? seed=null, long? seed2=null, System.Single[] aspect_ratio_range=null, System.Single[] area_range=null, long? max_attempts=null, System.Boolean? use_image_if_no_bounding_boxes=null, string operName=null)
		{
			return graph.SampleDistortedBoundingBoxV2(image_size, bounding_boxes, min_object_covered, seed, seed2, aspect_ratio_range, area_range, max_attempts, use_image_if_no_bounding_boxes, operName);
		}
	}
}
