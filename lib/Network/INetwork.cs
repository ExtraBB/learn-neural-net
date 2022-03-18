namespace LearnNeuralNet.Network;
public interface INetwork
{
    void LoadCheckpoint();
    void Train();
    void Infer();
}