namespace https.w3id.org.nno.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nno =
    let _namespace_iri = Namespace_Iri nno |> NamespaceIRI
    /// <summary>
    ///   <para>nno:NeuralNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Neural Network</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#NeuralNetwork">https://w3id.org/nno/ontology#NeuralNetwork</seealso>
    let NeuralNetwork = Prefixed_Name(nno, "NeuralNetwork") |> PrefixedName
    /// <summary>
    ///   <para>nno:Layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Layer of the neural network.</para>
    /// labels<para>Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Layer">https://w3id.org/nno/ontology#Layer</seealso>
    let Layer = Prefixed_Name(nno, "Layer") |> PrefixedName

    /// <summary>
    ///   <para>nno:GlobalAveragePooling1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Global average pooling operation for temporal data.</para>
    /// labels<para>Global Average Pooling 1D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GlobalAveragePooling1D">https://w3id.org/nno/ontology#GlobalAveragePooling1D</seealso>
    let GlobalAveragePooling1D =
        Prefixed_Name(nno, "GlobalAveragePooling1D") |> PrefixedName

    /// <summary>
    ///   <para>nno:GlobalAveragePooling2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Global average pooling operation for spatial data.</para>
    /// labels<para>Global Average Pooling 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GlobalAveragePooling2D">https://w3id.org/nno/ontology#GlobalAveragePooling2D</seealso>
    let GlobalAveragePooling2D =
        Prefixed_Name(nno, "GlobalAveragePooling2D") |> PrefixedName

    /// <summary>
    ///   <para>nno:BatchNormalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Batch normalization layer (Ioffe and Szegedy, 2014).
    ///
    /// Normalize the activations of the previous layer at each batch, i.e. applies a transformation that maintains the mean activation close to 0 and the activation standard deviation close to 1.</para>
    /// labels<para>Batch Normalization Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#BatchNormalization">https://w3id.org/nno/ontology#BatchNormalization</seealso>
    let BatchNormalization = Prefixed_Name(nno, "BatchNormalization") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasLayerParameters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Parameters of a layer</para>
    /// labels<para>has layer parameters</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasLayerParameters">https://w3id.org/nno/ontology#hasLayerParameters</seealso>
    let hasLayerParameters = Prefixed_Name(nno, "hasLayerParameters") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasLossFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Loss function used by Neural Network.</para>
    /// labels<para>has loss function</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasLossFunction">https://w3id.org/nno/ontology#hasLossFunction</seealso>
    let hasLossFunction = Prefixed_Name(nno, "hasLossFunction") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Model of the repository.</para>
    /// labels<para>has model</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasModel">https://w3id.org/nno/ontology#hasModel</seealso>
    let hasModel = Prefixed_Name(nno, "hasModel") |> PrefixedName

    /// <summary>
    ///   <para>nno:hasBaseModelKeywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Keywords of base model</para>
    /// labels<para>has base model keywords</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasBaseModelKeywords">https://w3id.org/nno/ontology#hasBaseModelKeywords</seealso>
    let hasBaseModelKeywords =
        Prefixed_Name(nno, "hasBaseModelKeywords") |> PrefixedName

    /// <summary>
    ///   <para>nno:hasLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Layer of the Neural Network.</para>
    /// labels<para>has layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasLayer">https://w3id.org/nno/ontology#hasLayer</seealso>
    let hasLayer = Prefixed_Name(nno, "hasLayer") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasLayerKeywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Keywords of a layer</para>
    /// labels<para>has layer keywords</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasLayerKeywords">https://w3id.org/nno/ontology#hasLayerKeywords</seealso>
    let hasLayerKeywords = Prefixed_Name(nno, "hasLayerKeywords") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasLayerSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the sequence of the layers. Starts at 1, the number of layers is n-1, at n: Number of layers.</para>
    /// labels<para>has layer sequence</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasLayerSequence">https://w3id.org/nno/ontology#hasLayerSequence</seealso>
    let hasLayerSequence = Prefixed_Name(nno, "hasLayerSequence") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Reflects potential real-world impact of the Model.
    /// Determines the Accuracy, Precision etc. of the model.</para>
    /// labels<para>has metric</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasMetric">https://w3id.org/nno/ontology#hasMetric</seealso>
    let hasMetric = Prefixed_Name(nno, "hasMetric") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasModelSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the sequence of models, starts at 1</para>
    /// labels<para>has model sequence</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasModelSequence">https://w3id.org/nno/ontology#hasModelSequence</seealso>
    let hasModelSequence = Prefixed_Name(nno, "hasModelSequence") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasRepositoryLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Link to the respository (e.g. github) where the model and further information can be found.</para>
    /// labels<para>has repository link</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasRepositoryLink">https://w3id.org/nno/ontology#hasRepositoryLink</seealso>
    let hasRepositoryLink = Prefixed_Name(nno, "hasRepositoryLink") |> PrefixedName
    /// <summary>
    ///   <para>nno:hinge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///
    /// labels<para>Hinge</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hinge">https://w3id.org/nno/ontology#hinge</seealso>
    let hinge = Prefixed_Name(nno, "hinge") |> PrefixedName

    /// <summary>
    ///   <para>nno:kullbackleiblerdivergence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///
    /// labels<para>Kullback Leibler Divergence</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#kullbackleiblerdivergence">https://w3id.org/nno/ontology#kullbackleiblerdivergence</seealso>
    let kullbackleiblerdivergence =
        Prefixed_Name(nno, "kullbackleiblerdivergence") |> PrefixedName

    /// <summary>
    ///   <para>nno:meansquaredlogarithmicerror</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Mean Squared Logarithmic Error</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#meansquaredlogarithmicerror">https://w3id.org/nno/ontology#meansquaredlogarithmicerror</seealso>
    let meansquaredlogarithmicerror =
        Prefixed_Name(nno, "meansquaredlogarithmicerror") |> PrefixedName

    /// <summary>
    ///   <para>nno:nadam</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Much like Adam is essentially RMSprop with momentum, Nadam is Adam RMSprop with Nesterov momentum.</para>
    /// labels<para>Nesterov Adam Optimizer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#nadam">https://w3id.org/nno/ontology#nadam</seealso>
    let nadam = Prefixed_Name(nno, "nadam") |> PrefixedName
    /// <summary>
    ///   <para>nno:sgd</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Includes support for momentum, learning rate decay, and Nesterov momentum.</para>
    /// labels<para>Stochastic Gradient Descent Optimizer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#sgd">https://w3id.org/nno/ontology#sgd</seealso>
    let sgd = Prefixed_Name(nno, "sgd") |> PrefixedName
    /// <summary>
    ///   <para>nno:usedFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Framework (e.g. Keras, Pandas, numpy, etc.) used to create this model.</para>
    /// labels<para>used framework</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#usedFramework">https://w3id.org/nno/ontology#usedFramework</seealso>
    let usedFramework = Prefixed_Name(nno, "usedFramework") |> PrefixedName
    /// <summary>
    ///   <para>nno:adagrad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>Adagrad is an optimizer with parameter-specific learning rates, which are adapted relative to how frequently a parameter gets updated during training. The more updates a parameter receives, the smaller the learning rate.</para>
    /// labels<para>Adagrad Optimizer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#adagrad">https://w3id.org/nno/ontology#adagrad</seealso>
    let adagrad = Prefixed_Name(nno, "adagrad") |> PrefixedName
    /// <summary>
    ///   <para>nno:binarycrossentropy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///
    /// labels<para>Binary Crossentropy</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#binarycrossentropy">https://w3id.org/nno/ontology#binarycrossentropy</seealso>
    let binarycrossentropy = Prefixed_Name(nno, "binarycrossentropy") |> PrefixedName
    /// <summary>
    ///   <para>nno:customloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#LossFunction</para>
    ///   <para>Custom loss function defined by user</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nno/ontology#customloss">https://w3id.org/nno/ontology#customloss</seealso>
    let customloss = Prefixed_Name(nno, "customloss") |> PrefixedName
    /// <summary>
    ///   <para>nno:dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describes the used dataset for training and evaluating</para>
    /// labels<para>data set</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#dataset">https://w3id.org/nno/ontology#dataset</seealso>
    let dataset = Prefixed_Name(nno, "dataset") |> PrefixedName
    /// <summary>
    ///   <para>nno:Activation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Applies an activation function to an output.</para>
    /// labels<para>Activation Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Activation">https://w3id.org/nno/ontology#Activation</seealso>
    let Activation = Prefixed_Name(nno, "Activation") |> PrefixedName
    /// <summary>
    ///   <para>nno:CoreLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Core Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#CoreLayer">https://w3id.org/nno/ontology#CoreLayer</seealso>
    let CoreLayer = Prefixed_Name(nno, "CoreLayer") |> PrefixedName
    /// <summary>
    ///   <para>nno:AveragePooling1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Average pooling for temporal data.</para>
    /// labels<para>Average Pooling 1D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#AveragePooling1D">https://w3id.org/nno/ontology#AveragePooling1D</seealso>
    let AveragePooling1D = Prefixed_Name(nno, "AveragePooling1D") |> PrefixedName
    /// <summary>
    ///   <para>nno:AveragePooling3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Average pooling operation for 3D data (spatial or spatio-temporal).</para>
    /// labels<para>Average Pooling 3D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#AveragePooling3D">https://w3id.org/nno/ontology#AveragePooling3D</seealso>
    let AveragePooling3D = Prefixed_Name(nno, "AveragePooling3D") |> PrefixedName
    /// <summary>
    ///   <para>nno:LossFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Loss function used by Neural Network.</para>
    /// labels<para>Loss Function</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#LossFunction">https://w3id.org/nno/ontology#LossFunction</seealso>
    let LossFunction = Prefixed_Name(nno, "LossFunction") |> PrefixedName
    /// <summary>
    ///   <para>nno:ConvolutionalLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Convolutional Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ConvolutionalLayer">https://w3id.org/nno/ontology#ConvolutionalLayer</seealso>
    let ConvolutionalLayer = Prefixed_Name(nno, "ConvolutionalLayer") |> PrefixedName
    /// <summary>
    ///   <para>nno:Conv2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>2D convolution layer (e.g. spatial convolution over images).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input to produce a tensor of outputs.</para>
    /// labels<para>Convolutional 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Conv2D">https://w3id.org/nno/ontology#Conv2D</seealso>
    let Conv2D = Prefixed_Name(nno, "Conv2D") |> PrefixedName
    /// <summary>
    ///   <para>nno:Conv3DTranspose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Transposed convolution layer (sometimes called Deconvolution).
    ///
    /// The need for transposed convolutions generally arises from the desire to use a transformation going in the opposite direction of a normal convolution, i.e., from something that has the shape of the output of some convolution to something that has the shape of its input while maintaining a connectivity pattern that is compatible with said convolution.</para>
    /// labels<para>Convolutional 3D Transpose Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Conv3DTranspose">https://w3id.org/nno/ontology#Conv3DTranspose</seealso>
    let Conv3DTranspose = Prefixed_Name(nno, "Conv3DTranspose") |> PrefixedName
    /// <summary>
    ///   <para>nno:RecurrentLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Recurrent Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#RecurrentLayer">https://w3id.org/nno/ontology#RecurrentLayer</seealso>
    let RecurrentLayer = Prefixed_Name(nno, "RecurrentLayer") |> PrefixedName
    /// <summary>
    ///   <para>nno:ConvLSTM2DCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cell class for the ConvLSTM2D layer.</para>
    /// labels<para>Convolutional LSTM 2D Cell Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ConvLSTM2DCell">https://w3id.org/nno/ontology#ConvLSTM2DCell</seealso>
    let ConvLSTM2DCell = Prefixed_Name(nno, "ConvLSTM2DCell") |> PrefixedName
    /// <summary>
    ///   <para>nno:Cropping3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cropping layer for 3D data (e.g. spatial or spatio-temporal).</para>
    /// labels<para>Cropping 3D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Cropping3D">https://w3id.org/nno/ontology#Cropping3D</seealso>
    let Cropping3D = Prefixed_Name(nno, "Cropping3D") |> PrefixedName
    /// <summary>
    ///   <para>nno:CuDNNLSTM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fast LSTM implementation with CuDNN.
    ///
    /// Can only be run on GPU, with the TensorFlow backend.</para>
    /// labels<para>CuDNN LSTM Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#CuDNNLSTM">https://w3id.org/nno/ontology#CuDNNLSTM</seealso>
    let CuDNNLSTM = Prefixed_Name(nno, "CuDNNLSTM") |> PrefixedName
    /// <summary>
    ///   <para>nno:AveragePooling2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Average pooling operation for spatial data.</para>
    /// labels<para>Average Pooling 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#AveragePooling2D">https://w3id.org/nno/ontology#AveragePooling2D</seealso>
    let AveragePooling2D = Prefixed_Name(nno, "AveragePooling2D") |> PrefixedName

    /// <summary>
    ///   <para>nno:ActivityRegularization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Layer that applies an update to the cost function based input activity.</para>
    /// labels<para>Activity Regularization Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ActivityRegularization">https://w3id.org/nno/ontology#ActivityRegularization</seealso>
    let ActivityRegularization =
        Prefixed_Name(nno, "ActivityRegularization") |> PrefixedName

    /// <summary>
    ///   <para>nno:PoolingLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Pooling Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#PoolingLayer">https://w3id.org/nno/ontology#PoolingLayer</seealso>
    let PoolingLayer = Prefixed_Name(nno, "PoolingLayer") |> PrefixedName
    /// <summary>
    ///   <para>nno:BaseModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Base model from keras application</para>
    /// labels<para>Base Model</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#BaseModel">https://w3id.org/nno/ontology#BaseModel</seealso>
    let BaseModel = Prefixed_Name(nno, "BaseModel") |> PrefixedName
    /// <summary>
    ///   <para>nno:ClassificationLoss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Loss function typically used for classification problems.</para>
    /// labels<para>Classification Loss Function</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ClassificationLoss">https://w3id.org/nno/ontology#ClassificationLoss</seealso>
    let ClassificationLoss = Prefixed_Name(nno, "ClassificationLoss") |> PrefixedName
    /// <summary>
    ///   <para>nno:logcosh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///
    /// labels<para>Log Cosh Loss</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#logcosh">https://w3id.org/nno/ontology#logcosh</seealso>
    let logcosh = Prefixed_Name(nno, "logcosh") |> PrefixedName
    /// <summary>
    ///   <para>nno:meansquarederror</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///
    /// labels<para>Mean Squared Error</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#meansquarederror">https://w3id.org/nno/ontology#meansquarederror</seealso>
    let meansquarederror = Prefixed_Name(nno, "meansquarederror") |> PrefixedName
    /// <summary>
    ///   <para>nno:ontologyhuberloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Huber Loss</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ontologyhuberloss">https://w3id.org/nno/ontology#ontologyhuberloss</seealso>
    let ontologyhuberloss = Prefixed_Name(nno, "ontologyhuberloss") |> PrefixedName
    /// <summary>
    ///   <para>nno:stars</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>indicates watchers count</para>
    /// labels<para>stars</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#stars">https://w3id.org/nno/ontology#stars</seealso>
    let stars = Prefixed_Name(nno, "stars") |> PrefixedName
    /// <summary>
    ///   <para>nno:NormalizationLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Normalization Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#NormalizationLayer">https://w3id.org/nno/ontology#NormalizationLayer</seealso>
    let NormalizationLayer = Prefixed_Name(nno, "NormalizationLayer") |> PrefixedName
    /// <summary>
    ///   <para>nno:Conv2DTranspose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Transposed convolution layer (sometimes called Deconvolution).
    ///
    /// The need for transposed convolutions generally arises from the desire to use a transformation going in the opposite direction of a normal convolution, i.e., from something that has the shape of the output of some convolution to something that has the shape of its input while maintaining a connectivity pattern that is compatible with said convolution.</para>
    /// labels<para>Convolutional 2D Transpose Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Conv2DTranspose">https://w3id.org/nno/ontology#Conv2DTranspose</seealso>
    let Conv2DTranspose = Prefixed_Name(nno, "Conv2DTranspose") |> PrefixedName
    /// <summary>
    ///   <para>nno:ConvLSTM2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Convolutional LSTM.
    ///
    /// It is similar to an LSTM layer, but the input transformations and recurrent transformations are both convolutional.</para>
    /// labels<para>Convolutional LSTM 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ConvLSTM2D">https://w3id.org/nno/ontology#ConvLSTM2D</seealso>
    let ConvLSTM2D = Prefixed_Name(nno, "ConvLSTM2D") |> PrefixedName
    /// <summary>
    ///   <para>nno:Cropping1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cropping layer for 1D input (e.g. temporal sequence).
    ///
    /// It crops along the time dimension (axis 1).</para>
    /// labels<para>Cropping 1D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Cropping1D">https://w3id.org/nno/ontology#Cropping1D</seealso>
    let Cropping1D = Prefixed_Name(nno, "Cropping1D") |> PrefixedName
    /// <summary>
    ///   <para>nno:CuDNNGRU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fast GRU implementation backed by CuDNN.
    ///
    /// Can only be run on GPU, with the TensorFlow backend.</para>
    /// labels<para>CuDNN GRU Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#CuDNNGRU">https://w3id.org/nno/ontology#CuDNNGRU</seealso>
    let CuDNNGRU = Prefixed_Name(nno, "CuDNNGRU") |> PrefixedName
    /// <summary>
    ///   <para>nno:CustomLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Custom layer defined by user</para>
    /// labels<para>Custom Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#CustomLayer">https://w3id.org/nno/ontology#CustomLayer</seealso>
    let CustomLayer = Prefixed_Name(nno, "CustomLayer") |> PrefixedName
    /// <summary>
    ///   <para>nno:Dense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Just your regular densely-connected NN layer.</para>
    /// labels<para>Dense Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Dense">https://w3id.org/nno/ontology#Dense</seealso>
    let Dense = Prefixed_Name(nno, "Dense") |> PrefixedName
    /// <summary>
    ///   <para>nno:DepthwiseConv2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depthwise separable 2D convolution.
    ///
    /// Depthwise Separable convolutions consists in performing just the first step in a depthwise spatial convolution (which acts on each input channel separately).</para>
    /// labels<para>Depthwise Convolutional 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#DepthwiseConv2D">https://w3id.org/nno/ontology#DepthwiseConv2D</seealso>
    let DepthwiseConv2D = Prefixed_Name(nno, "DepthwiseConv2D") |> PrefixedName
    /// <summary>
    ///   <para>nno:Embedding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Turns positive integers (indexes) into dense vectors of fixed size.</para>
    /// labels<para>Embedding Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Embedding">https://w3id.org/nno/ontology#Embedding</seealso>
    let Embedding = Prefixed_Name(nno, "Embedding") |> PrefixedName
    /// <summary>
    ///   <para>nno:EmbeddingLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Embedding Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#EmbeddingLayer">https://w3id.org/nno/ontology#EmbeddingLayer</seealso>
    let EmbeddingLayer = Prefixed_Name(nno, "EmbeddingLayer") |> PrefixedName
    /// <summary>
    ///   <para>nno:Flatten</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Flattens the input. Does not affect the batch size.</para>
    /// labels<para>Flatten Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Flatten">https://w3id.org/nno/ontology#Flatten</seealso>
    let Flatten = Prefixed_Name(nno, "Flatten") |> PrefixedName
    /// <summary>
    ///   <para>nno:GRU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gated Recurrent Unit - Cho et al. 2014.
    ///
    /// There are two variants. The default one is based on 1406.1078v3 and has reset gate applied to hidden state before matrix multiplication. The other one is based on original 1406.1078v1 and has the order reversed.</para>
    /// labels<para>GRU Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GRU">https://w3id.org/nno/ontology#GRU</seealso>
    let GRU = Prefixed_Name(nno, "GRU") |> PrefixedName
    /// <summary>
    ///   <para>nno:GRUCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cell class for the GRU layer.</para>
    /// labels<para>GRU Cell Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GRUCell">https://w3id.org/nno/ontology#GRUCell</seealso>
    let GRUCell = Prefixed_Name(nno, "GRUCell") |> PrefixedName

    /// <summary>
    ///   <para>nno:GlobalAveragePooling3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Global Average pooling operation for 3D data.</para>
    /// labels<para>Global Average Pooling 3D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GlobalAveragePooling3D">https://w3id.org/nno/ontology#GlobalAveragePooling3D</seealso>
    let GlobalAveragePooling3D =
        Prefixed_Name(nno, "GlobalAveragePooling3D") |> PrefixedName

    /// <summary>
    ///   <para>nno:GlobalMaxPooling2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Global max pooling operation for spatial data.</para>
    /// labels<para>Global Max Pooling 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GlobalMaxPooling2D">https://w3id.org/nno/ontology#GlobalMaxPooling2D</seealso>
    let GlobalMaxPooling2D = Prefixed_Name(nno, "GlobalMaxPooling2D") |> PrefixedName
    /// <summary>
    ///   <para>nno:GlobalMaxPooling3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Global Max pooling operation for 3D data.</para>
    /// labels<para>Global Max Pooling 3D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GlobalMaxPooling3D">https://w3id.org/nno/ontology#GlobalMaxPooling3D</seealso>
    let GlobalMaxPooling3D = Prefixed_Name(nno, "GlobalMaxPooling3D") |> PrefixedName
    /// <summary>
    ///   <para>nno:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Input() is used to instantiate a Keras tensor.
    ///
    /// A Keras tensor is a tensor object from the underlying backend (Theano, TensorFlow or CNTK), which we augment with certain attributes that allow us to build a Keras model just by knowing the inputs and outputs of the model.</para>
    /// labels<para>Input Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Input">https://w3id.org/nno/ontology#Input</seealso>
    let Input = Prefixed_Name(nno, "Input") |> PrefixedName
    /// <summary>
    ///   <para>nno:InputLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Input (e.g. data set).</para>
    /// labels<para>Input Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#InputLayer">https://w3id.org/nno/ontology#InputLayer</seealso>
    let InputLayer = Prefixed_Name(nno, "InputLayer") |> PrefixedName
    /// <summary>
    ///   <para>nno:LSTM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Long Short-Term Memory layer - Hochreiter 1997.</para>
    /// labels<para>LSTM Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#LSTM">https://w3id.org/nno/ontology#LSTM</seealso>
    let LSTM = Prefixed_Name(nno, "LSTM") |> PrefixedName
    /// <summary>
    ///   <para>nno:Lambda</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Wraps arbitrary expression as a Layer object.</para>
    /// labels<para>Lambda Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Lambda">https://w3id.org/nno/ontology#Lambda</seealso>
    let Lambda = Prefixed_Name(nno, "Lambda") |> PrefixedName

    /// <summary>
    ///   <para>nno:Locally-connectedLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Locally-connected Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Locally-connectedLayer">https://w3id.org/nno/ontology#Locally-connectedLayer</seealso>
    let Locally_connectedLayer =
        Prefixed_Name(nno, "Locally-connectedLayer") |> PrefixedName

    /// <summary>
    ///   <para>nno:LocallyConnected1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Locally-connected layer for 1D inputs.</para>
    /// labels<para>Locally-connected 1D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#LocallyConnected1D">https://w3id.org/nno/ontology#LocallyConnected1D</seealso>
    let LocallyConnected1D = Prefixed_Name(nno, "LocallyConnected1D") |> PrefixedName
    /// <summary>
    ///   <para>nno:Masking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Masks a sequence by using a mask value to skip timesteps.</para>
    /// labels<para>Masking Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Masking">https://w3id.org/nno/ontology#Masking</seealso>
    let Masking = Prefixed_Name(nno, "Masking") |> PrefixedName
    /// <summary>
    ///   <para>nno:MaxPooling1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Max pooling operation for temporal data.</para>
    /// labels<para>Max Pooling 1D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#MaxPooling1D">https://w3id.org/nno/ontology#MaxPooling1D</seealso>
    let MaxPooling1D = Prefixed_Name(nno, "MaxPooling1D") |> PrefixedName
    /// <summary>
    ///   <para>nno:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Model of the repository.</para>
    /// labels<para>Model</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Model">https://w3id.org/nno/ontology#Model</seealso>
    let Model = Prefixed_Name(nno, "Model") |> PrefixedName
    /// <summary>
    ///   <para>nno:RNN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nno/ontology#RNN">https://w3id.org/nno/ontology#RNN</seealso>
    let RNN = Prefixed_Name(nno, "RNN") |> PrefixedName
    /// <summary>
    ///   <para>nno:RegressiveLoss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Loss function typically used for regression problems.</para>
    /// labels<para>Regression Loss Function</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#RegressiveLoss">https://w3id.org/nno/ontology#RegressiveLoss</seealso>
    let RegressiveLoss = Prefixed_Name(nno, "RegressiveLoss") |> PrefixedName
    /// <summary>
    ///   <para>nno:Reshape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reshapes an output to a certain shape.</para>
    /// labels<para>Reshape Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Reshape">https://w3id.org/nno/ontology#Reshape</seealso>
    let Reshape = Prefixed_Name(nno, "Reshape") |> PrefixedName
    /// <summary>
    ///   <para>nno:SeparableConv1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depthwise separable 1D convolution.
    ///
    /// Separable convolutions consist in first performing a depthwise spatial convolution (which acts on each input channel separately) followed by a pointwise convolution which mixes together the resulting output channels.
    ///
    /// Intuitively, separable convolutions can be understood as a way to factorize a convolution kernel into two smaller kernels, or as an extreme version of an Inception block.</para>
    /// labels<para>Separable Convolutional 1D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SeparableConv1D">https://w3id.org/nno/ontology#SeparableConv1D</seealso>
    let SeparableConv1D = Prefixed_Name(nno, "SeparableConv1D") |> PrefixedName
    /// <summary>
    ///   <para>nno:SeparableConv2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Depthwise separable 2D convolution.
    ///
    /// Separable convolutions consist in first performing a depthwise spatial convolution (which acts on each input channel separately) followed by a pointwise convolution which mixes together the resulting output channels.
    ///
    /// Intuitively, separable convolutions can be understood as a way to factorize a convolution kernel into two smaller kernels, or as an extreme version of an Inception block.</para>
    /// labels<para>Separable Convolutional 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SeparableConv2D">https://w3id.org/nno/ontology#SeparableConv2D</seealso>
    let SeparableConv2D = Prefixed_Name(nno, "SeparableConv2D") |> PrefixedName
    /// <summary>
    ///   <para>nno:SpatialDropout1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatial 1D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 1D feature maps instead of individual elements. If adjacent frames within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout1D will help promote independence between feature maps and should be used instead.</para>
    /// labels<para>Spatial Dropout 1D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SpatialDropout1D">https://w3id.org/nno/ontology#SpatialDropout1D</seealso>
    let SpatialDropout1D = Prefixed_Name(nno, "SpatialDropout1D") |> PrefixedName
    /// <summary>
    ///   <para>nno:SpatialDropout2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatial 2D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 2D feature maps instead of individual elements. If adjacent pixels within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout2D will help promote independence between feature maps and should be used instead.</para>
    /// labels<para>Spatial Dropout 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SpatialDropout2D">https://w3id.org/nno/ontology#SpatialDropout2D</seealso>
    let SpatialDropout2D = Prefixed_Name(nno, "SpatialDropout2D") |> PrefixedName
    /// <summary>
    ///   <para>nno:Conv1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>1D convolution layer (e.g. temporal convolution).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input over a single spatial (or temporal) dimension to produce a tensor of outputs.</para>
    /// labels<para>Convolutional 1D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Conv1D">https://w3id.org/nno/ontology#Conv1D</seealso>
    let Conv1D = Prefixed_Name(nno, "Conv1D") |> PrefixedName
    /// <summary>
    ///   <para>nno:Dropout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Applies Dropout to the input.</para>
    /// labels<para>Dropout Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Dropout">https://w3id.org/nno/ontology#Dropout</seealso>
    let Dropout = Prefixed_Name(nno, "Dropout") |> PrefixedName
    /// <summary>
    ///   <para>nno:GlobalMaxPooling1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Global max pooling operation for temporal data.</para>
    /// labels<para>Global Max Pooling 1D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GlobalMaxPooling1D">https://w3id.org/nno/ontology#GlobalMaxPooling1D</seealso>
    let GlobalMaxPooling1D = Prefixed_Name(nno, "GlobalMaxPooling1D") |> PrefixedName
    /// <summary>
    ///   <para>nno:LSTMCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cell class for the LSTM layer.</para><para>LSTM Cell Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#LSTMCell">https://w3id.org/nno/ontology#LSTMCell</seealso>
    let LSTMCell = Prefixed_Name(nno, "LSTMCell") |> PrefixedName
    /// <summary>
    ///   <para>nno:LocallyConnected2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Locally-connected layer for 2D inputs.</para>
    /// labels<para>Locally-connected 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#LocallyConnected2D">https://w3id.org/nno/ontology#LocallyConnected2D</seealso>
    let LocallyConnected2D = Prefixed_Name(nno, "LocallyConnected2D") |> PrefixedName
    /// <summary>
    ///   <para>nno:MaxPooling3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Max pooling operation for 3D data (spatial or spatio-temporal).</para>
    /// labels<para>Max Pooling 3D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#MaxPooling3D">https://w3id.org/nno/ontology#MaxPooling3D</seealso>
    let MaxPooling3D = Prefixed_Name(nno, "MaxPooling3D") |> PrefixedName
    /// <summary>
    ///   <para>nno:Optimizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Optimizer used by Neural Network.</para>
    /// labels<para>Optimizer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Optimizer">https://w3id.org/nno/ontology#Optimizer</seealso>
    let Optimizer = Prefixed_Name(nno, "Optimizer") |> PrefixedName
    /// <summary>
    ///   <para>nno:Permute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Permutes the dimensions of the input according to a given pattern.
    ///
    /// Useful for e.g. connecting RNNs and convnets together.</para>
    /// labels<para>Permute Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Permute">https://w3id.org/nno/ontology#Permute</seealso>
    let Permute = Prefixed_Name(nno, "Permute") |> PrefixedName
    /// <summary>
    ///   <para>nno:RepeatVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Repeats the input n times.</para>
    /// labels<para>Repeat Vector Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#RepeatVector">https://w3id.org/nno/ontology#RepeatVector</seealso>
    let RepeatVector = Prefixed_Name(nno, "RepeatVector") |> PrefixedName
    /// <summary>
    ///   <para>nno:SimpleRNN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fully-connected RNN where the output is to be fed back to input.</para>
    /// labels<para>Simple RNN Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SimpleRNN">https://w3id.org/nno/ontology#SimpleRNN</seealso>
    let SimpleRNN = Prefixed_Name(nno, "SimpleRNN") |> PrefixedName
    /// <summary>
    ///   <para>nno:SpatialDropout3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatial 3D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 3D feature maps instead of individual elements. If adjacent pixels within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout3D will help promote independence between feature maps and should be used instead.</para>
    /// labels<para>Spatial Dropout 3D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SpatialDropout3D">https://w3id.org/nno/ontology#SpatialDropout3D</seealso>
    let SpatialDropout3D = Prefixed_Name(nno, "SpatialDropout3D") |> PrefixedName
    /// <summary>
    ///   <para>nno:UpSampling3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Upsampling layer for 3D inputs.
    ///
    /// Repeats the 1st, 2nd and 3rd dimensions of the data by size[0], size[1] and size[2] respectively.</para>
    /// labels<para>Upsampling 3D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#UpSampling3D">https://w3id.org/nno/ontology#UpSampling3D</seealso>
    let UpSampling3D = Prefixed_Name(nno, "UpSampling3D") |> PrefixedName
    /// <summary>
    ///   <para>nno:MaxPooling2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Max pooling operation for spatial data.</para>
    /// labels<para>Max Pooling 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#MaxPooling2D">https://w3id.org/nno/ontology#MaxPooling2D</seealso>
    let MaxPooling2D = Prefixed_Name(nno, "MaxPooling2D") |> PrefixedName
    /// <summary>
    ///   <para>nno:SimpleRNNCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cell class for SimpleRNN.</para>
    /// labels<para>Simple RNN Cell Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SimpleRNNCell">https://w3id.org/nno/ontology#SimpleRNNCell</seealso>
    let SimpleRNNCell = Prefixed_Name(nno, "SimpleRNNCell") |> PrefixedName
    /// <summary>
    ///   <para>nno:UpSampling2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Upsampling layer for 2D inputs.
    ///
    /// Repeats the rows and columns of the data by size[0] and size[1] respectively.</para>
    /// labels<para>Upsampling 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#UpSampling2D">https://w3id.org/nno/ontology#UpSampling2D</seealso>
    let UpSampling2D = Prefixed_Name(nno, "UpSampling2D") |> PrefixedName
    /// <summary>
    ///   <para>nno:ZeroPadding1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Zero-padding layer for 1D input (e.g. temporal sequence).</para>
    /// labels<para>Zero-padding 1D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ZeroPadding1D">https://w3id.org/nno/ontology#ZeroPadding1D</seealso>
    let ZeroPadding1D = Prefixed_Name(nno, "ZeroPadding1D") |> PrefixedName
    /// <summary>
    ///   <para>nno:ZeroPadding3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Zero-padding layer for 3D data (spatial or spatio-temporal).</para>
    /// labels<para>Zero-padding 3D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ZeroPadding3D">https://w3id.org/nno/ontology#ZeroPadding3D</seealso>
    let ZeroPadding3D = Prefixed_Name(nno, "ZeroPadding3D") |> PrefixedName
    /// <summary>
    ///   <para>nno:adam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///
    /// labels<para>Adam Optimizer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#adam">https://w3id.org/nno/ontology#adam</seealso>
    let adam = Prefixed_Name(nno, "adam") |> PrefixedName

    /// <summary>
    ///   <para>nno:categoricalcrossentropy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Categorical Crossentropy</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#categoricalcrossentropy">https://w3id.org/nno/ontology#categoricalcrossentropy</seealso>
    let categoricalcrossentropy =
        Prefixed_Name(nno, "categoricalcrossentropy") |> PrefixedName

    /// <summary>
    ///   <para>nno:cosineproximity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Cosine Proximity</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#cosineproximity">https://w3id.org/nno/ontology#cosineproximity</seealso>
    let cosineproximity = Prefixed_Name(nno, "cosineproximity") |> PrefixedName
    /// <summary>
    ///   <para>nno:UpSampling1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Upsampling layer for 1D inputs.</para>
    /// labels<para>Upsampling 1D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#UpSampling1D">https://w3id.org/nno/ontology#UpSampling1D</seealso>
    let UpSampling1D = Prefixed_Name(nno, "UpSampling1D") |> PrefixedName
    /// <summary>
    ///   <para>nno:ZeroPadding2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Zero-padding layer for 2D input (e.g. picture).
    ///
    /// This layer can add rows and columns of zeros at the top, bottom, left and right side of an image tensor.</para>
    /// labels<para>Zero-padding 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ZeroPadding2D">https://w3id.org/nno/ontology#ZeroPadding2D</seealso>
    let ZeroPadding2D = Prefixed_Name(nno, "ZeroPadding2D") |> PrefixedName
    /// <summary>
    ///   <para>nno:adadelta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>Adadelta is a more robust extension of Adagrad that adapts learning rates based on a moving window of gradient updates, instead of accumulating all past gradients. This way, Adadelta continues learning even when many updates have been done. Compared to Adagrad, in the original version of Adadelta you don't have to set an initial learning rate. In this version, initial learning rate and decay factor can be set, as in most other Keras optimizers.</para>
    /// labels<para>Adadelta Optimizer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#adadelta">https://w3id.org/nno/ontology#adadelta</seealso>
    let adadelta = Prefixed_Name(nno, "adadelta") |> PrefixedName
    /// <summary>
    ///   <para>nno:adamax</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///
    /// labels<para>Adamax Optimizer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#adamax">https://w3id.org/nno/ontology#adamax</seealso>
    let adamax = Prefixed_Name(nno, "adamax") |> PrefixedName
    /// <summary>
    ///   <para>nno:categoricalhinge</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Categorical Hinge</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#categoricalhinge">https://w3id.org/nno/ontology#categoricalhinge</seealso>
    let categoricalhinge = Prefixed_Name(nno, "categoricalhinge") |> PrefixedName
    /// <summary>
    ///   <para>nno:customoptimizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Custom optimizer defined by user</para>
    /// labels<para>Custom Optimizer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#customoptimizer">https://w3id.org/nno/ontology#customoptimizer</seealso>
    let customoptimizer = Prefixed_Name(nno, "customoptimizer") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasBaseModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Base model from keras application</para>
    /// labels<para>has base model</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasBaseModel">https://w3id.org/nno/ontology#hasBaseModel</seealso>
    let hasBaseModel = Prefixed_Name(nno, "hasBaseModel") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasDownloadCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of downloads for this particular model.</para>
    /// labels<para>has download count</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasDownloadCount">https://w3id.org/nno/ontology#hasDownloadCount</seealso>
    let hasDownloadCount = Prefixed_Name(nno, "hasDownloadCount") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasModelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>type of the model</para>
    /// labels<para>has model type</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasModelType">https://w3id.org/nno/ontology#hasModelType</seealso>
    let hasModelType = Prefixed_Name(nno, "hasModelType") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasOptimizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Optimization function used by Neural Network (e.g. SGD, Adam or RMSprop).</para>
    /// labels<para>has optimizer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasOptimizer">https://w3id.org/nno/ontology#hasOptimizer</seealso>
    let hasOptimizer = Prefixed_Name(nno, "hasOptimizer") |> PrefixedName
    /// <summary>
    ///   <para>nno:hasintendedUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Primary intended use and users (domain) for which the Neural Network was trained for.</para>
    /// labels<para>has intended use</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasintendedUse">https://w3id.org/nno/ontology#hasintendedUse</seealso>
    let hasintendedUse = Prefixed_Name(nno, "hasintendedUse") |> PrefixedName
    /// <summary>
    ///   <para>nno:meanabsoluteerror</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///
    /// labels<para>Mean Absolute Error</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#meanabsoluteerror">https://w3id.org/nno/ontology#meanabsoluteerror</seealso>
    let meanabsoluteerror = Prefixed_Name(nno, "meanabsoluteerror") |> PrefixedName

    /// <summary>
    ///   <para>nno:meanabsolutepercentageerror</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///
    /// labels<para>Mean Absolute Percentage Error</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#meanabsolutepercentageerror">https://w3id.org/nno/ontology#meanabsolutepercentageerror</seealso>
    let meanabsolutepercentageerror =
        Prefixed_Name(nno, "meanabsolutepercentageerror") |> PrefixedName

    /// <summary>
    ///   <para>nno:poisson</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Poisson</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#poisson">https://w3id.org/nno/ontology#poisson</seealso>
    let poisson = Prefixed_Name(nno, "poisson") |> PrefixedName
    /// <summary>
    ///   <para>nno:rmsprop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>This optimizer is usually a good choice for recurrent neural networks.</para>
    /// labels<para>RMSProp Optimizer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#rmsprop">https://w3id.org/nno/ontology#rmsprop</seealso>
    let rmsprop = Prefixed_Name(nno, "rmsprop") |> PrefixedName

    /// <summary>
    ///   <para>nno:sparsecategoricalcrossentropy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Sparse Categorical Crossentropy</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#sparsecategoricalcrossentropy">https://w3id.org/nno/ontology#sparsecategoricalcrossentropy</seealso>
    let sparsecategoricalcrossentropy =
        Prefixed_Name(nno, "sparsecategoricalcrossentropy") |> PrefixedName

    /// <summary>
    ///   <para>nno:squaredhinge</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Squared Hinge</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#squaredhinge">https://w3id.org/nno/ontology#squaredhinge</seealso>
    let squaredhinge = Prefixed_Name(nno, "squaredhinge") |> PrefixedName
    /// <summary>
    ///   <para>nno:Conv3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>3D convolution layer (e.g. spatial convolution over volumes).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input to produce a tensor of outputs.</para>
    /// labels<para>Convolutional 3D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Conv3D">https://w3id.org/nno/ontology#Conv3D</seealso>
    let Conv3D = Prefixed_Name(nno, "Conv3D") |> PrefixedName
    /// <summary>
    ///   <para>nno:Cropping2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cropping layer for 2D input (e.g. picture).
    ///
    /// It crops along spatial dimensions, i.e. height and width.</para>
    /// labels<para>Cropping 2D Layer</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Cropping2D">https://w3id.org/nno/ontology#Cropping2D</seealso>
    let Cropping2D = Prefixed_Name(nno, "Cropping2D") |> PrefixedName
