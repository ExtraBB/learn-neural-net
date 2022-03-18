using LearnNeuralNet.Layers;

namespace LearnNeuralNet.Network;
public class NeuralNetwork : INetwork
{
    public ILayer[] Layers { get; set; }

    public NeuralNetwork() => Layers = new ILayer[0];
    public NeuralNetwork(ILayer[] layers) => Layers = layers;

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
