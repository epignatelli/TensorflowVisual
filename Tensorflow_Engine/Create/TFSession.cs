using TensorFlow;

namespace BH.Engine.Tensorflow
{
    public static partial class Create
    {
        public static TFSession TFSession()
        {
            return new TFSession();
        }

        public static TFSession TFSession(TFGraph graph)
        {
            return new TFSession(graph);
        }
    }
}
