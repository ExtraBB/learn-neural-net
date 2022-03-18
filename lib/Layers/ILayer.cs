using MathNet.Numerics.LinearAlgebra;

namespace LearnNeuralNet.Layers;

public interface ILayer 
{
    Matrix<float> Forward(Matrix<float> input);
    Matrix<float> Backward(Matrix<float> output, Matrix<float> gradient);
}