# Artificial Neural Network
Artificial neural network builder and calculator.  Can have multiple inputs, outputs, hidden layers and hidden neurons.

--

For CEMI414's 2015 group assignment 1, the efficient functioning of artificial neural networks in the fields of process modelling and
inferential control have to be investigated. The study should include a comprehensive literature review as well as a practical
demonstration of an artificial neural network in the field of inferential control.

Instead of just constructing a fixed neural network, a program was written to build **any** neural network the user wants.
This is the repo of *that* program.

Feel free to browse through the source code or download a release.



---

#Current features:

- User-specifiable number of hidden layers
- User-specifiable number of neurons per hidden layer
- User-specifiable activation functions per layer

Implements the following *activation functions*:
* Linear
* Sigmoid
* "Shouldered" sigmoid  (outputs 1 if f>0.9,  0 if f<0.1,  because of the sigmoid's asymptotical behaviour)
* Hyperbolic tangent

The neural networks that are created by this program are *fully connected* neural networks. 

The backpropagation algorithm *with optional momentum*, is implememted for training the network.

The user can specify if bias values have to be kept constant (equal to 1), or updated alongside the weights.  If opted to update, each neuron in each hidden layer can have its own bias value (thus, not a shared bias between them).
