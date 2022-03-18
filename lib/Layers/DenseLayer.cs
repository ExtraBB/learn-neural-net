using LearnNeuralNet.Activations;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra;

namespace LearnNeuralNet.Layers;

public class DenseLayer : ILayer
{
    private readonly Activation activation;
    private readonly Matrix<float> weights;

    public DenseLayer(int numFeatures, int numOutputs, Activation activation)
    {
        // TODO better initialization (xavier?)
        weights = Matrix<float>.Build.Random(numFeatures, numOutputs, new Normal());
        this.activation = activation;
    }

    public Matrix<float> Backward(Matrix<float> output, Matrix<float> gradient)
    {
        throw new NotImplementedException();
    }

    public Matrix<float> Forward(Matrix<float> input)
    {
        if(input.ColumnCount != weights.RowCount)
        {
            throw new ArgumentException("Invalid input matrix");
        }

        // TODO: bias, check math here

        Matrix<float> result = input.Multiply(weights);
        result.MapInplace(x => ActivationFunctions.Activate(x, activation));
        return result;
    }
}