#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nno =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/nno/ontology#" "nno"
    /// <summary>
    ///   <para>rdfs:label : Activation Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Applies an activation function to an output.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Activation">nno:Activation</a>
    /// </summary>
    let Activation = _prefixId.prefix "Activation"
    /// <summary>
    ///   <para>rdfs:label : Activity Regularization Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Layer that applies an update to the cost function based input activity.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#ActivityRegularization">nno:ActivityRegularization</a>
    /// </summary>
    let ActivityRegularization = _prefixId.prefix "ActivityRegularization"
    /// <summary>
    ///   <para>rdfs:label : Average Pooling 1D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Average pooling for temporal data.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#AveragePooling1D">nno:AveragePooling1D</a>
    /// </summary>
    let AveragePooling1D = _prefixId.prefix "AveragePooling1D"
    /// <summary>
    ///   <para>rdfs:label : Average Pooling 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Average pooling operation for spatial data.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#AveragePooling2D">nno:AveragePooling2D</a>
    /// </summary>
    let AveragePooling2D = _prefixId.prefix "AveragePooling2D"
    /// <summary>
    ///   <para>rdfs:label : Average Pooling 3D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Average pooling operation for 3D data (spatial or spatio-temporal).^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#AveragePooling3D">nno:AveragePooling3D</a>
    /// </summary>
    let AveragePooling3D = _prefixId.prefix "AveragePooling3D"
    /// <summary>
    ///   <para>rdfs:label : Base Model^^xsd:string</para>
    ///   <para>rdfs:comment : Base model from keras application^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#BaseModel">nno:BaseModel</a>
    /// </summary>
    let BaseModel = _prefixId.prefix "BaseModel"
    /// <summary>
    ///   <para>rdfs:label : Batch Normalization Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Batch normalization layer (Ioffe and Szegedy, 2014).
    ///
    /// Normalize the activations of the previous layer at each batch, i.e. applies a transformation that maintains the mean activation close to 0 and the activation standard deviation close to 1.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#BatchNormalization">nno:BatchNormalization</a>
    /// </summary>
    let BatchNormalization = _prefixId.prefix "BatchNormalization"
    /// <summary>
    ///   <para>rdfs:label : Classification Loss Function^^xsd:string</para>
    ///   <para>rdfs:comment : Loss function typically used for classification problems.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#ClassificationLoss">nno:ClassificationLoss</a>
    /// </summary>
    let ClassificationLoss = _prefixId.prefix "ClassificationLoss"
    /// <summary>
    ///   <para>rdfs:label : Convolutional 1D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : 1D convolution layer (e.g. temporal convolution).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input over a single spatial (or temporal) dimension to produce a tensor of outputs.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Conv1D">nno:Conv1D</a>
    /// </summary>
    let Conv1D = _prefixId.prefix "Conv1D"
    /// <summary>
    ///   <para>rdfs:label : Convolutional 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : 2D convolution layer (e.g. spatial convolution over images).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input to produce a tensor of outputs.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Conv2D">nno:Conv2D</a>
    /// </summary>
    let Conv2D = _prefixId.prefix "Conv2D"
    /// <summary>
    ///   <para>rdfs:label : Convolutional 2D Transpose Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Transposed convolution layer (sometimes called Deconvolution).
    ///
    /// The need for transposed convolutions generally arises from the desire to use a transformation going in the opposite direction of a normal convolution, i.e., from something that has the shape of the output of some convolution to something that has the shape of its input while maintaining a connectivity pattern that is compatible with said convolution.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Conv2DTranspose">nno:Conv2DTranspose</a>
    /// </summary>
    let Conv2DTranspose = _prefixId.prefix "Conv2DTranspose"
    /// <summary>
    ///   <para>rdfs:label : Convolutional 3D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : 3D convolution layer (e.g. spatial convolution over volumes).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input to produce a tensor of outputs.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Conv3D">nno:Conv3D</a>
    /// </summary>
    let Conv3D = _prefixId.prefix "Conv3D"
    /// <summary>
    ///   <para>rdfs:label : Convolutional 3D Transpose Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Transposed convolution layer (sometimes called Deconvolution).
    ///
    /// The need for transposed convolutions generally arises from the desire to use a transformation going in the opposite direction of a normal convolution, i.e., from something that has the shape of the output of some convolution to something that has the shape of its input while maintaining a connectivity pattern that is compatible with said convolution.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Conv3DTranspose">nno:Conv3DTranspose</a>
    /// </summary>
    let Conv3DTranspose = _prefixId.prefix "Conv3DTranspose"
    /// <summary>
    ///   <para>rdfs:label : Convolutional LSTM 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Convolutional LSTM.
    ///
    /// It is similar to an LSTM layer, but the input transformations and recurrent transformations are both convolutional.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#ConvLSTM2D">nno:ConvLSTM2D</a>
    /// </summary>
    let ConvLSTM2D = _prefixId.prefix "ConvLSTM2D"
    /// <summary>
    ///   <para>rdfs:label : Convolutional LSTM 2D Cell Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Cell class for the ConvLSTM2D layer.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#ConvLSTM2DCell">nno:ConvLSTM2DCell</a>
    /// </summary>
    let ConvLSTM2DCell = _prefixId.prefix "ConvLSTM2DCell"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://keras.io/layers/convolutional/^^xsd:string</para>
    ///   <para>rdfs:label : Convolutional Layer^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#ConvolutionalLayer">nno:ConvolutionalLayer</a>
    /// </summary>
    let ConvolutionalLayer = _prefixId.prefix "ConvolutionalLayer"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://keras.io/layers/core/^^xsd:string</para>
    ///   <para>rdfs:label : Core Layer^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#CoreLayer">nno:CoreLayer</a>
    /// </summary>
    let CoreLayer = _prefixId.prefix "CoreLayer"
    /// <summary>
    ///   <para>rdfs:label : Cropping 1D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Cropping layer for 1D input (e.g. temporal sequence).
    ///
    /// It crops along the time dimension (axis 1).^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Cropping1D">nno:Cropping1D</a>
    /// </summary>
    let Cropping1D = _prefixId.prefix "Cropping1D"
    /// <summary>
    ///   <para>rdfs:label : Cropping 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Cropping layer for 2D input (e.g. picture).
    ///
    /// It crops along spatial dimensions, i.e. height and width.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Cropping2D">nno:Cropping2D</a>
    /// </summary>
    let Cropping2D = _prefixId.prefix "Cropping2D"
    /// <summary>
    ///   <para>rdfs:label : Cropping 3D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Cropping layer for 3D data (e.g. spatial or spatio-temporal).^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Cropping3D">nno:Cropping3D</a>
    /// </summary>
    let Cropping3D = _prefixId.prefix "Cropping3D"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://developer.nvidia.com/cudnn^^xsd:string</para>
    ///   <para>rdfs:label : CuDNN GRU Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Fast GRU implementation backed by CuDNN.
    ///
    /// Can only be run on GPU, with the TensorFlow backend.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#CuDNNGRU">nno:CuDNNGRU</a>
    /// </summary>
    let CuDNNGRU = _prefixId.prefix "CuDNNGRU"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://developer.nvidia.com/cudnn^^xsd:string</para>
    ///   <para>rdfs:label : CuDNN LSTM Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Fast LSTM implementation with CuDNN.
    ///
    /// Can only be run on GPU, with the TensorFlow backend.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#CuDNNLSTM">nno:CuDNNLSTM</a>
    /// </summary>
    let CuDNNLSTM = _prefixId.prefix "CuDNNLSTM"
    /// <summary>
    ///   <para>rdfs:label : Custom Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Custom layer defined by user^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#CustomLayer">nno:CustomLayer</a>
    /// </summary>
    let CustomLayer = _prefixId.prefix "CustomLayer"
    /// <summary>
    ///   <para>rdfs:label : Dense Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Just your regular densely-connected NN layer.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Dense">nno:Dense</a>
    /// </summary>
    let Dense = _prefixId.prefix "Dense"
    /// <summary>
    ///   <para>rdfs:label : Depthwise Convolutional 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Depthwise separable 2D convolution.
    ///
    /// Depthwise Separable convolutions consists in performing just the first step in a depthwise spatial convolution (which acts on each input channel separately).^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#DepthwiseConv2D">nno:DepthwiseConv2D</a>
    /// </summary>
    let DepthwiseConv2D = _prefixId.prefix "DepthwiseConv2D"
    /// <summary>
    ///   <para>rdfs:label : Dropout Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Applies Dropout to the input.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Dropout">nno:Dropout</a>
    /// </summary>
    let Dropout = _prefixId.prefix "Dropout"
    /// <summary>
    ///   <para>rdfs:label : Embedding Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Turns positive integers (indexes) into dense vectors of fixed size.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Embedding">nno:Embedding</a>
    /// </summary>
    let Embedding = _prefixId.prefix "Embedding"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://keras.io/layers/embeddings/^^xsd:string</para>
    ///   <para>rdfs:label : Embedding Layer^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#EmbeddingLayer">nno:EmbeddingLayer</a>
    /// </summary>
    let EmbeddingLayer = _prefixId.prefix "EmbeddingLayer"
    /// <summary>
    ///   <para>rdfs:label : Flatten Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Flattens the input. Does not affect the batch size.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Flatten">nno:Flatten</a>
    /// </summary>
    let Flatten = _prefixId.prefix "Flatten"
    /// <summary>
    ///   <para>rdfs:label : GRU Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Gated Recurrent Unit - Cho et al. 2014.
    ///
    /// There are two variants. The default one is based on 1406.1078v3 and has reset gate applied to hidden state before matrix multiplication. The other one is based on original 1406.1078v1 and has the order reversed.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#GRU">nno:GRU</a>
    /// </summary>
    let GRU = _prefixId.prefix "GRU"
    /// <summary>
    ///   <para>rdfs:label : GRU Cell Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Cell class for the GRU layer.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#GRUCell">nno:GRUCell</a>
    /// </summary>
    let GRUCell = _prefixId.prefix "GRUCell"
    /// <summary>
    ///   <para>rdfs:label : Global Average Pooling 1D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Global average pooling operation for temporal data.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#GlobalAveragePooling1D">nno:GlobalAveragePooling1D</a>
    /// </summary>
    let GlobalAveragePooling1D = _prefixId.prefix "GlobalAveragePooling1D"
    /// <summary>
    ///   <para>rdfs:label : Global Average Pooling 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Global average pooling operation for spatial data.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#GlobalAveragePooling2D">nno:GlobalAveragePooling2D</a>
    /// </summary>
    let GlobalAveragePooling2D = _prefixId.prefix "GlobalAveragePooling2D"
    /// <summary>
    ///   <para>rdfs:label : Global Average Pooling 3D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Global Average pooling operation for 3D data.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#GlobalAveragePooling3D">nno:GlobalAveragePooling3D</a>
    /// </summary>
    let GlobalAveragePooling3D = _prefixId.prefix "GlobalAveragePooling3D"
    /// <summary>
    ///   <para>rdfs:label : Global Max Pooling 1D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Global max pooling operation for temporal data.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#GlobalMaxPooling1D">nno:GlobalMaxPooling1D</a>
    /// </summary>
    let GlobalMaxPooling1D = _prefixId.prefix "GlobalMaxPooling1D"
    /// <summary>
    ///   <para>rdfs:label : Global Max Pooling 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Global max pooling operation for spatial data.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#GlobalMaxPooling2D">nno:GlobalMaxPooling2D</a>
    /// </summary>
    let GlobalMaxPooling2D = _prefixId.prefix "GlobalMaxPooling2D"
    /// <summary>
    ///   <para>rdfs:label : Global Max Pooling 3D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Global Max pooling operation for 3D data.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#GlobalMaxPooling3D">nno:GlobalMaxPooling3D</a>
    /// </summary>
    let GlobalMaxPooling3D = _prefixId.prefix "GlobalMaxPooling3D"
    /// <summary>
    ///   <para>rdfs:label : Input Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Input() is used to instantiate a Keras tensor.
    ///
    /// A Keras tensor is a tensor object from the underlying backend (Theano, TensorFlow or CNTK), which we augment with certain attributes that allow us to build a Keras model just by knowing the inputs and outputs of the model.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Input">nno:Input</a>
    /// </summary>
    let Input = _prefixId.prefix "Input"
    /// <summary>
    ///   <para>rdfs:label : Input Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Input (e.g. data set).^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#InputLayer">nno:InputLayer</a>
    /// </summary>
    let InputLayer = _prefixId.prefix "InputLayer"
    /// <summary>
    ///   <para>rdfs:label : LSTM Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Long Short-Term Memory layer - Hochreiter 1997.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#LSTM">nno:LSTM</a>
    /// </summary>
    let LSTM = _prefixId.prefix "LSTM"
    /// <summary>
    ///   <para>rdfs:label : LSTM Cell Layer^^xsd:stringrdfs:label : Cell class for the LSTM layer.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#LSTMCell">nno:LSTMCell</a>
    /// </summary>
    let LSTMCell = _prefixId.prefix "LSTMCell"
    /// <summary>
    ///   <para>rdfs:label : Lambda Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Wraps arbitrary expression as a Layer object.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Lambda">nno:Lambda</a>
    /// </summary>
    let Lambda = _prefixId.prefix "Lambda"
    /// <summary>
    ///   <para>rdfs:label : Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Layer of the neural network.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Layer">nno:Layer</a>
    /// </summary>
    let Layer = _prefixId.prefix "Layer"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://keras.io/layers/local/^^xsd:string</para>
    ///   <para>rdfs:label : Locally-connected Layer^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Locally-connectedLayer">nno:Locally-connectedLayer</a>
    /// </summary>
    let Locally_connectedLayer = _prefixId.prefix "Locally-connectedLayer"
    /// <summary>
    ///   <para>rdfs:label : Locally-connected 1D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Locally-connected layer for 1D inputs.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#LocallyConnected1D">nno:LocallyConnected1D</a>
    /// </summary>
    let LocallyConnected1D = _prefixId.prefix "LocallyConnected1D"
    /// <summary>
    ///   <para>rdfs:label : Locally-connected 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Locally-connected layer for 2D inputs.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#LocallyConnected2D">nno:LocallyConnected2D</a>
    /// </summary>
    let LocallyConnected2D = _prefixId.prefix "LocallyConnected2D"
    /// <summary>
    ///   <para>rdfs:label : Loss Function^^xsd:string</para>
    ///   <para>rdfs:comment : Loss function used by Neural Network.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#LossFunction">nno:LossFunction</a>
    /// </summary>
    let LossFunction = _prefixId.prefix "LossFunction"
    /// <summary>
    ///   <para>rdfs:label : Masking Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Masks a sequence by using a mask value to skip timesteps.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Masking">nno:Masking</a>
    /// </summary>
    let Masking = _prefixId.prefix "Masking"
    /// <summary>
    ///   <para>rdfs:label : Max Pooling 1D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Max pooling operation for temporal data.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#MaxPooling1D">nno:MaxPooling1D</a>
    /// </summary>
    let MaxPooling1D = _prefixId.prefix "MaxPooling1D"
    /// <summary>
    ///   <para>rdfs:label : Max Pooling 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Max pooling operation for spatial data.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#MaxPooling2D">nno:MaxPooling2D</a>
    /// </summary>
    let MaxPooling2D = _prefixId.prefix "MaxPooling2D"
    /// <summary>
    ///   <para>rdfs:label : Max Pooling 3D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Max pooling operation for 3D data (spatial or spatio-temporal).^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#MaxPooling3D">nno:MaxPooling3D</a>
    /// </summary>
    let MaxPooling3D = _prefixId.prefix "MaxPooling3D"
    /// <summary>
    ///   <para>rdfs:label : Model^^xsd:string</para>
    ///   <para>rdfs:comment : Model of the repository.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Model">nno:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:label : Neural Network^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#NeuralNetwork">nno:NeuralNetwork</a>
    /// </summary>
    let NeuralNetwork = _prefixId.prefix "NeuralNetwork"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://keras.io/layers/normalization/^^xsd:string</para>
    ///   <para>rdfs:label : Normalization Layer^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#NormalizationLayer">nno:NormalizationLayer</a>
    /// </summary>
    let NormalizationLayer = _prefixId.prefix "NormalizationLayer"
    /// <summary>
    ///   <para>rdfs:label : Optimizer^^xsd:string</para>
    ///   <para>rdfs:comment : Optimizer used by Neural Network.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Optimizer">nno:Optimizer</a>
    /// </summary>
    let Optimizer = _prefixId.prefix "Optimizer"
    /// <summary>
    ///   <para>rdfs:label : Permute Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Permutes the dimensions of the input according to a given pattern.
    ///
    /// Useful for e.g. connecting RNNs and convnets together.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Permute">nno:Permute</a>
    /// </summary>
    let Permute = _prefixId.prefix "Permute"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://keras.io/layers/pooling/^^xsd:string</para>
    ///   <para>rdfs:label : Pooling Layer^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#PoolingLayer">nno:PoolingLayer</a>
    /// </summary>
    let PoolingLayer = _prefixId.prefix "PoolingLayer"
    let RNN = _prefixId.prefix "RNN"
    /// <summary>
    ///   <para>rdfs:seeAlso : https://keras.io/layers/recurrent/^^xsd:string</para>
    ///   <para>rdfs:label : Recurrent Layer^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#RecurrentLayer">nno:RecurrentLayer</a>
    /// </summary>
    let RecurrentLayer = _prefixId.prefix "RecurrentLayer"
    /// <summary>
    ///   <para>rdfs:label : Regression Loss Function^^xsd:string</para>
    ///   <para>rdfs:comment : Loss function typically used for regression problems.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#RegressiveLoss">nno:RegressiveLoss</a>
    /// </summary>
    let RegressiveLoss = _prefixId.prefix "RegressiveLoss"
    /// <summary>
    ///   <para>rdfs:label : Repeat Vector Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Repeats the input n times.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#RepeatVector">nno:RepeatVector</a>
    /// </summary>
    let RepeatVector = _prefixId.prefix "RepeatVector"
    /// <summary>
    ///   <para>rdfs:label : Reshape Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Reshapes an output to a certain shape.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#Reshape">nno:Reshape</a>
    /// </summary>
    let Reshape = _prefixId.prefix "Reshape"
    /// <summary>
    ///   <para>rdfs:label : Separable Convolutional 1D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Depthwise separable 1D convolution.
    ///
    /// Separable convolutions consist in first performing a depthwise spatial convolution (which acts on each input channel separately) followed by a pointwise convolution which mixes together the resulting output channels.
    ///
    /// Intuitively, separable convolutions can be understood as a way to factorize a convolution kernel into two smaller kernels, or as an extreme version of an Inception block.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#SeparableConv1D">nno:SeparableConv1D</a>
    /// </summary>
    let SeparableConv1D = _prefixId.prefix "SeparableConv1D"
    /// <summary>
    ///   <para>rdfs:label : Separable Convolutional 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Depthwise separable 2D convolution.
    ///
    /// Separable convolutions consist in first performing a depthwise spatial convolution (which acts on each input channel separately) followed by a pointwise convolution which mixes together the resulting output channels.
    ///
    /// Intuitively, separable convolutions can be understood as a way to factorize a convolution kernel into two smaller kernels, or as an extreme version of an Inception block.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#SeparableConv2D">nno:SeparableConv2D</a>
    /// </summary>
    let SeparableConv2D = _prefixId.prefix "SeparableConv2D"
    /// <summary>
    ///   <para>rdfs:label : Simple RNN Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Fully-connected RNN where the output is to be fed back to input.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#SimpleRNN">nno:SimpleRNN</a>
    /// </summary>
    let SimpleRNN = _prefixId.prefix "SimpleRNN"
    /// <summary>
    ///   <para>rdfs:label : Simple RNN Cell Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Cell class for SimpleRNN.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#SimpleRNNCell">nno:SimpleRNNCell</a>
    /// </summary>
    let SimpleRNNCell = _prefixId.prefix "SimpleRNNCell"
    /// <summary>
    ///   <para>rdfs:label : Spatial Dropout 1D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Spatial 1D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 1D feature maps instead of individual elements. If adjacent frames within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout1D will help promote independence between feature maps and should be used instead.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#SpatialDropout1D">nno:SpatialDropout1D</a>
    /// </summary>
    let SpatialDropout1D = _prefixId.prefix "SpatialDropout1D"
    /// <summary>
    ///   <para>rdfs:label : Spatial Dropout 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Spatial 2D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 2D feature maps instead of individual elements. If adjacent pixels within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout2D will help promote independence between feature maps and should be used instead.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#SpatialDropout2D">nno:SpatialDropout2D</a>
    /// </summary>
    let SpatialDropout2D = _prefixId.prefix "SpatialDropout2D"
    /// <summary>
    ///   <para>rdfs:label : Spatial Dropout 3D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Spatial 3D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 3D feature maps instead of individual elements. If adjacent pixels within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout3D will help promote independence between feature maps and should be used instead.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#SpatialDropout3D">nno:SpatialDropout3D</a>
    /// </summary>
    let SpatialDropout3D = _prefixId.prefix "SpatialDropout3D"
    /// <summary>
    ///   <para>rdfs:label : Upsampling 1D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Upsampling layer for 1D inputs.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#UpSampling1D">nno:UpSampling1D</a>
    /// </summary>
    let UpSampling1D = _prefixId.prefix "UpSampling1D"
    /// <summary>
    ///   <para>rdfs:label : Upsampling 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Upsampling layer for 2D inputs.
    ///
    /// Repeats the rows and columns of the data by size[0] and size[1] respectively.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#UpSampling2D">nno:UpSampling2D</a>
    /// </summary>
    let UpSampling2D = _prefixId.prefix "UpSampling2D"
    /// <summary>
    ///   <para>rdfs:label : Upsampling 3D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Upsampling layer for 3D inputs.
    ///
    /// Repeats the 1st, 2nd and 3rd dimensions of the data by size[0], size[1] and size[2] respectively.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#UpSampling3D">nno:UpSampling3D</a>
    /// </summary>
    let UpSampling3D = _prefixId.prefix "UpSampling3D"
    /// <summary>
    ///   <para>rdfs:label : Zero-padding 1D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Zero-padding layer for 1D input (e.g. temporal sequence).^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#ZeroPadding1D">nno:ZeroPadding1D</a>
    /// </summary>
    let ZeroPadding1D = _prefixId.prefix "ZeroPadding1D"
    /// <summary>
    ///   <para>rdfs:label : Zero-padding 2D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Zero-padding layer for 2D input (e.g. picture).
    ///
    /// This layer can add rows and columns of zeros at the top, bottom, left and right side of an image tensor.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#ZeroPadding2D">nno:ZeroPadding2D</a>
    /// </summary>
    let ZeroPadding2D = _prefixId.prefix "ZeroPadding2D"
    /// <summary>
    ///   <para>rdfs:label : Zero-padding 3D Layer^^xsd:string</para>
    ///   <para>rdfs:comment : Zero-padding layer for 3D data (spatial or spatio-temporal).^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#ZeroPadding3D">nno:ZeroPadding3D</a>
    /// </summary>
    let ZeroPadding3D = _prefixId.prefix "ZeroPadding3D"
    let adadelta = _prefixId.prefix "adadelta"
    let adagrad = _prefixId.prefix "adagrad"
    let adam = _prefixId.prefix "adam"
    let adamax = _prefixId.prefix "adamax"
    let binarycrossentropy = _prefixId.prefix "binarycrossentropy"
    let categoricalcrossentropy = _prefixId.prefix "categoricalcrossentropy"
    let categoricalhinge = _prefixId.prefix "categoricalhinge"
    let cosineproximity = _prefixId.prefix "cosineproximity"
    let customloss = _prefixId.prefix "customloss"
    let customoptimizer = _prefixId.prefix "customoptimizer"
    /// <summary>
    ///   <para>rdfs:label : data set^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the used dataset for training and evaluating^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#dataset">nno:dataset</a>
    /// </summary>
    let dataset = _prefixId.prefix "dataset"
    /// <summary>
    ///   <para>rdfs:label : has base model^^xsd:string</para>
    ///   <para>rdfs:comment : Base model from keras application^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasBaseModel">nno:hasBaseModel</a>
    /// </summary>
    let hasBaseModel = _prefixId.prefix "hasBaseModel"
    /// <summary>
    ///   <para>rdfs:label : has base model keywords^^xsd:string</para>
    ///   <para>rdfs:comment : Keywords of base model^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasBaseModelKeywords">nno:hasBaseModelKeywords</a>
    /// </summary>
    let hasBaseModelKeywords = _prefixId.prefix "hasBaseModelKeywords"
    /// <summary>
    ///   <para>rdfs:label : has download count^^xsd:string</para>
    ///   <para>rdfs:comment : Number of downloads for this particular model.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasDownloadCount">nno:hasDownloadCount</a>
    /// </summary>
    let hasDownloadCount = _prefixId.prefix "hasDownloadCount"
    /// <summary>
    ///   <para>rdfs:label : has layer^^xsd:string</para>
    ///   <para>rdfs:comment : Layer of the Neural Network.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasLayer">nno:hasLayer</a>
    /// </summary>
    let hasLayer = _prefixId.prefix "hasLayer"
    /// <summary>
    ///   <para>rdfs:label : has layer keywords^^xsd:string</para>
    ///   <para>rdfs:comment : Keywords of a layer^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasLayerKeywords">nno:hasLayerKeywords</a>
    /// </summary>
    let hasLayerKeywords = _prefixId.prefix "hasLayerKeywords"
    /// <summary>
    ///   <para>rdfs:label : has layer parameters^^xsd:string</para>
    ///   <para>rdfs:comment : Parameters of a layer^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasLayerParameters">nno:hasLayerParameters</a>
    /// </summary>
    let hasLayerParameters = _prefixId.prefix "hasLayerParameters"
    /// <summary>
    ///   <para>rdfs:label : has layer sequence^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the sequence of the layers. Starts at 1, the number of layers is n-1, at n: Number of layers.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasLayerSequence">nno:hasLayerSequence</a>
    /// </summary>
    let hasLayerSequence = _prefixId.prefix "hasLayerSequence"
    /// <summary>
    ///   <para>rdfs:label : has loss function^^xsd:string</para>
    ///   <para>rdfs:comment : Loss function used by Neural Network.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasLossFunction">nno:hasLossFunction</a>
    /// </summary>
    let hasLossFunction = _prefixId.prefix "hasLossFunction"
    /// <summary>
    ///   <para>rdfs:label : has metric^^xsd:string</para>
    ///   <para>rdfs:comment : Reflects potential real-world impact of the Model.
    /// Determines the Accuracy, Precision etc. of the model.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasMetric">nno:hasMetric</a>
    /// </summary>
    let hasMetric = _prefixId.prefix "hasMetric"
    /// <summary>
    ///   <para>rdfs:label : has model^^xsd:string</para>
    ///   <para>rdfs:comment : Model of the repository.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasModel">nno:hasModel</a>
    /// </summary>
    let hasModel = _prefixId.prefix "hasModel"
    /// <summary>
    ///   <para>rdfs:label : has model sequence^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the sequence of models, starts at 1^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasModelSequence">nno:hasModelSequence</a>
    /// </summary>
    let hasModelSequence = _prefixId.prefix "hasModelSequence"
    /// <summary>
    ///   <para>rdfs:label : has model type^^xsd:string</para>
    ///   <para>rdfs:comment : type of the model^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasModelType">nno:hasModelType</a>
    /// </summary>
    let hasModelType = _prefixId.prefix "hasModelType"
    /// <summary>
    ///   <para>rdfs:label : has optimizer^^xsd:string</para>
    ///   <para>rdfs:comment : Optimization function used by Neural Network (e.g. SGD, Adam or RMSprop).^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasOptimizer">nno:hasOptimizer</a>
    /// </summary>
    let hasOptimizer = _prefixId.prefix "hasOptimizer"
    /// <summary>
    ///   <para>rdfs:label : has repository link^^xsd:string</para>
    ///   <para>rdfs:comment : Link to the respository (e.g. github) where the model and further information can be found.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasRepositoryLink">nno:hasRepositoryLink</a>
    /// </summary>
    let hasRepositoryLink = _prefixId.prefix "hasRepositoryLink"
    /// <summary>
    ///   <para>rdfs:label : has intended use^^xsd:string</para>
    ///   <para>rdfs:comment : Primary intended use and users (domain) for which the Neural Network was trained for.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#hasintendedUse">nno:hasintendedUse</a>
    /// </summary>
    let hasintendedUse = _prefixId.prefix "hasintendedUse"
    let hinge = _prefixId.prefix "hinge"
    let kullbackleiblerdivergence = _prefixId.prefix "kullbackleiblerdivergence"
    let logcosh = _prefixId.prefix "logcosh"
    let meanabsoluteerror = _prefixId.prefix "meanabsoluteerror"
    let meanabsolutepercentageerror = _prefixId.prefix "meanabsolutepercentageerror"
    let meansquarederror = _prefixId.prefix "meansquarederror"
    let meansquaredlogarithmicerror = _prefixId.prefix "meansquaredlogarithmicerror"
    let nadam = _prefixId.prefix "nadam"
    let ontologyhuberloss = _prefixId.prefix "ontologyhuberloss"
    let poisson = _prefixId.prefix "poisson"
    let rmsprop = _prefixId.prefix "rmsprop"
    let sgd = _prefixId.prefix "sgd"
    let sparsecategoricalcrossentropy = _prefixId.prefix "sparsecategoricalcrossentropy"
    let squaredhinge = _prefixId.prefix "squaredhinge"
    /// <summary>
    ///   <para>rdfs:label : stars^^xsd:string</para>
    ///   <para>rdfs:comment : indicates watchers count^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#stars">nno:stars</a>
    /// </summary>
    let stars = _prefixId.prefix "stars"
    /// <summary>
    ///   <para>rdfs:label : used framework^^xsd:string</para>
    ///   <para>rdfs:comment : Framework (e.g. Keras, Pandas, numpy, etc.) used to create this model.^^xsd:string</para>
    ///   <a href="https://w3id.org/nno/ontology#usedFramework">nno:usedFramework</a>
    /// </summary>
    let usedFramework = _prefixId.prefix "usedFramework"
