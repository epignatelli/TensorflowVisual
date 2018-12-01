using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> SampleDistortedBoundingBox(this TFGraph graph, TensorFlow.TFOutput image_size, TensorFlow.TFOutput bounding_boxes, long? seed=null, long? seed2=null, System.Single? min_object_covered=null, System.Single[] aspect_ratio_range=null, System.Single[] area_range=null, long? max_attempts=null, System.Boolean? use_image_if_no_bounding_boxes=null, string operName=null)
		{
			return graph.SampleDistortedBoundingBox(image_size, bounding_boxes, seed, seed2, min_object_covered, aspect_ratio_range, area_range, max_attempts, use_image_if_no_bounding_boxes, operName);
		}
	}
}
