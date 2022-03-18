using LearnNeuralNet.Layers;

namespace LearnNeuralNet.Network;
public class Network
{
    public Layer[] Layers { get; set; }

    public Network() => Layers = new Layer[0];
    public Network(Layer[] layers) => Layers = layers;

    
}
