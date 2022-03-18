using LearnNeuralNet.Layers;

namespace LearnNeuralNet.Network;
public class NeuralNetwork : INetwork
{
    public Layer[] Layers { get; set; }

    public NeuralNetwork() => Layers = new Layer[0];
    public NeuralNetwork(Layer[] layers) => Layers = layers;

    public void LoadCheckpoint()
    {
        throw new NotImplementedException();
    }

    public void Train()
    {
        throw new NotImplementedException();
    }

    public void Infer()
    {
        throw new NotImplementedException();
    }
}
