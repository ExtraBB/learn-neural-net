using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnNeuralNet.Activations;
using System;

namespace LearnNeuralNetTests;

[TestClass]
public class ActivationsTests
{
    [DataTestMethod]
    [DataRow(1.0f)]
    [DataRow(0.0f)]
    [DataRow(-1.0f)]
    [DataRow(-0.5f)]
    [DataRow(0.5f)]
    [DataRow(0.0000001f)]
    [DataRow(-0.0000001f)]
    [DataRow(9999999.0f)]
    [DataRow(default)]
    public void Activate(float x)
    {
        Assert.AreEqual(ActivationFunctions.Relu(x), ActivationFunctions.Activate(x, Activation.Relu));
        Assert.AreEqual(ActivationFunctions.Sigmoid(x), ActivationFunctions.Activate(x, Activation.Sigmoid));
    }

    [TestMethod]
    public void Activate_Invalid()
    {
        Assert.ThrowsException<ArgumentException>(() => ActivationFunctions.Activate(0.271f, (Activation)999));
    }

    [DataTestMethod]
    [DataRow(1.0f, 1.0f)]
    [DataRow(0.0f, 0.0f)]
    [DataRow(-1.0f, 0.0f)]
    [DataRow(-0.5f, 0.0f)]
    [DataRow(0.5f, 0.5f)]
    [DataRow(0.0000001f, 0.0000001f)]
    [DataRow(-0.0000001f, 0.0f)]
    [DataRow(9999999.0f, 9999999.0f)]
    [DataRow(default, 0.0f)]
    public void Relu(float x, float expected)
    {
        Assert.AreEqual(expected, ActivationFunctions.Relu(x));
    }

    [DataTestMethod]
    [DataRow(1.0f)]
    [DataRow(0.0f)]
    [DataRow(-1.0f)]
    [DataRow(-0.5f)]
    [DataRow(0.5f)]
    [DataRow(0.0000001f)]
    [DataRow(-0.0000001f)]
    [DataRow(9999999.0f)]
    [DataRow(default)]
    public void Sigmoid(float x)
    {
        if (x < 0)
        {
            float y = ActivationFunctions.Sigmoid(x);
            Assert.IsTrue(y <= 0.5f && y >= 0.0f);
        }
        else if (x > 0)
        {
            float y = ActivationFunctions.Sigmoid(x);
            Assert.IsTrue(y >= 0.5f && y <= 1.0f);
        }
        else
        {
            Assert.AreEqual(0.5f, ActivationFunctions.Sigmoid(x));
        }
    }
}