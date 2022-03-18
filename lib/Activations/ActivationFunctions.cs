namespace LearnNeuralNet.Activations;

public static class ActivationFunctions
{
    public static float Activate(float x, Activation activation) 
    {
        switch(activation) 
        {
            case Activation.Relu: return Relu(x);
            case Activation.Sigmoid: return Sigmoid(x);
            default: throw new ArgumentException("Invalid activation function", nameof(activation));
        }
    }

    public static float Relu(float x)
    {
        return Math.Max(0, x);
    }

    public static float Sigmoid(float x)
    {
        return 1.0f / (1.0f + (float)Math.Pow(Math.E, -x));
    }
}