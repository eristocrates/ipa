namespace https.w3id.org.nno.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module nno =
    let _namespace_name = "https://w3id.org/nno/ontology#"

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#NeuralNetwork"></see>
    /// </summary>
    let NeuralNetwork =
        Namespaced_IRI.parse _namespace_name "NeuralNetwork" |> NamespacedName

    /// <summary>
    /// Layer of the neural network.
    /// <see href="https://w3id.org/nno/ontology#Layer"></see></summary>
    let Layer = Namespaced_IRI.parse _namespace_name "Layer" |> NamespacedName
    /// <summary>
    /// Applies an activation function to an output.
    /// <see href="https://w3id.org/nno/ontology#Activation"></see></summary>
    let Activation = Namespaced_IRI.parse _namespace_name "Activation" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#CoreLayer"></see>
    /// </summary>
    let CoreLayer = Namespaced_IRI.parse _namespace_name "CoreLayer" |> NamespacedName

    /// <summary>
    /// Layer that applies an update to the cost function based input activity.
    /// <see href="https://w3id.org/nno/ontology#ActivityRegularization"></see></summary>
    let ActivityRegularization =
        Namespaced_IRI.parse _namespace_name "ActivityRegularization" |> NamespacedName

    /// <summary>
    /// Average pooling for temporal data.
    /// <see href="https://w3id.org/nno/ontology#AveragePooling1D"></see></summary>
    let AveragePooling1D =
        Namespaced_IRI.parse _namespace_name "AveragePooling1D" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#PoolingLayer"></see>
    /// </summary>
    let PoolingLayer =
        Namespaced_IRI.parse _namespace_name "PoolingLayer" |> NamespacedName

    /// <summary>
    /// Average pooling operation for spatial data.
    /// <see href="https://w3id.org/nno/ontology#AveragePooling2D"></see></summary>
    let AveragePooling2D =
        Namespaced_IRI.parse _namespace_name "AveragePooling2D" |> NamespacedName

    /// <summary>
    /// Average pooling operation for 3D data (spatial or spatio-temporal).
    /// <see href="https://w3id.org/nno/ontology#AveragePooling3D"></see></summary>
    let AveragePooling3D =
        Namespaced_IRI.parse _namespace_name "AveragePooling3D" |> NamespacedName

    /// <summary>
    /// Base model from keras application
    /// <see href="https://w3id.org/nno/ontology#BaseModel"></see></summary>
    let BaseModel = Namespaced_IRI.parse _namespace_name "BaseModel" |> NamespacedName

    /// <summary>
    /// Batch normalization layer (Ioffe and Szegedy, 2014).
    ///
    /// Normalize the activations of the previous layer at each batch, i.e. applies a transformation that maintains the mean activation close to 0 and the activation standard deviation close to 1.
    /// <see href="https://w3id.org/nno/ontology#BatchNormalization"></see></summary>
    let BatchNormalization =
        Namespaced_IRI.parse _namespace_name "BatchNormalization" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#NormalizationLayer"></see>
    /// </summary>
    let NormalizationLayer =
        Namespaced_IRI.parse _namespace_name "NormalizationLayer" |> NamespacedName

    /// <summary>
    /// Loss function typically used for classification problems.
    /// <see href="https://w3id.org/nno/ontology#ClassificationLoss"></see></summary>
    let ClassificationLoss =
        Namespaced_IRI.parse _namespace_name "ClassificationLoss" |> NamespacedName

    /// <summary>
    /// Loss function used by Neural Network.
    /// <see href="https://w3id.org/nno/ontology#LossFunction"></see></summary>
    let LossFunction =
        Namespaced_IRI.parse _namespace_name "LossFunction" |> NamespacedName

    /// <summary>
    /// 1D convolution layer (e.g. temporal convolution).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input over a single spatial (or temporal) dimension to produce a tensor of outputs.
    /// <see href="https://w3id.org/nno/ontology#Conv1D"></see></summary>
    let Conv1D = Namespaced_IRI.parse _namespace_name "Conv1D" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#ConvolutionalLayer"></see>
    /// </summary>
    let ConvolutionalLayer =
        Namespaced_IRI.parse _namespace_name "ConvolutionalLayer" |> NamespacedName

    /// <summary>
    /// 2D convolution layer (e.g. spatial convolution over images).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input to produce a tensor of outputs.
    /// <see href="https://w3id.org/nno/ontology#Conv2D"></see></summary>
    let Conv2D = Namespaced_IRI.parse _namespace_name "Conv2D" |> NamespacedName

    /// <summary>
    /// Transposed convolution layer (sometimes called Deconvolution).
    ///
    /// The need for transposed convolutions generally arises from the desire to use a transformation going in the opposite direction of a normal convolution, i.e., from something that has the shape of the output of some convolution to something that has the shape of its input while maintaining a connectivity pattern that is compatible with said convolution.
    /// <see href="https://w3id.org/nno/ontology#Conv2DTranspose"></see></summary>
    let Conv2DTranspose =
        Namespaced_IRI.parse _namespace_name "Conv2DTranspose" |> NamespacedName

    /// <summary>
    /// 3D convolution layer (e.g. spatial convolution over volumes).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input to produce a tensor of outputs.
    /// <see href="https://w3id.org/nno/ontology#Conv3D"></see></summary>
    let Conv3D = Namespaced_IRI.parse _namespace_name "Conv3D" |> NamespacedName

    /// <summary>
    /// Transposed convolution layer (sometimes called Deconvolution).
    ///
    /// The need for transposed convolutions generally arises from the desire to use a transformation going in the opposite direction of a normal convolution, i.e., from something that has the shape of the output of some convolution to something that has the shape of its input while maintaining a connectivity pattern that is compatible with said convolution.
    /// <see href="https://w3id.org/nno/ontology#Conv3DTranspose"></see></summary>
    let Conv3DTranspose =
        Namespaced_IRI.parse _namespace_name "Conv3DTranspose" |> NamespacedName

    /// <summary>
    /// Convolutional LSTM.
    ///
    /// It is similar to an LSTM layer, but the input transformations and recurrent transformations are both convolutional.
    /// <see href="https://w3id.org/nno/ontology#ConvLSTM2D"></see></summary>
    let ConvLSTM2D = Namespaced_IRI.parse _namespace_name "ConvLSTM2D" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#RecurrentLayer"></see>
    /// </summary>
    let RecurrentLayer =
        Namespaced_IRI.parse _namespace_name "RecurrentLayer" |> NamespacedName

    /// <summary>
    /// Cell class for the ConvLSTM2D layer.
    /// <see href="https://w3id.org/nno/ontology#ConvLSTM2DCell"></see></summary>
    let ConvLSTM2DCell =
        Namespaced_IRI.parse _namespace_name "ConvLSTM2DCell" |> NamespacedName

    /// <summary>
    /// Cropping layer for 1D input (e.g. temporal sequence).
    ///
    /// It crops along the time dimension (axis 1).
    /// <see href="https://w3id.org/nno/ontology#Cropping1D"></see></summary>
    let Cropping1D = Namespaced_IRI.parse _namespace_name "Cropping1D" |> NamespacedName
    /// <summary>
    /// Cropping layer for 2D input (e.g. picture).
    ///
    /// It crops along spatial dimensions, i.e. height and width.
    /// <see href="https://w3id.org/nno/ontology#Cropping2D"></see></summary>
    let Cropping2D = Namespaced_IRI.parse _namespace_name "Cropping2D" |> NamespacedName
    /// <summary>
    /// Cropping layer for 3D data (e.g. spatial or spatio-temporal).
    /// <see href="https://w3id.org/nno/ontology#Cropping3D"></see></summary>
    let Cropping3D = Namespaced_IRI.parse _namespace_name "Cropping3D" |> NamespacedName
    /// <summary>
    /// Fast GRU implementation backed by CuDNN.
    ///
    /// Can only be run on GPU, with the TensorFlow backend.
    /// <see href="https://w3id.org/nno/ontology#CuDNNGRU"></see></summary>
    let CuDNNGRU = Namespaced_IRI.parse _namespace_name "CuDNNGRU" |> NamespacedName
    /// <summary>
    /// Fast LSTM implementation with CuDNN.
    ///
    /// Can only be run on GPU, with the TensorFlow backend.
    /// <see href="https://w3id.org/nno/ontology#CuDNNLSTM"></see></summary>
    let CuDNNLSTM = Namespaced_IRI.parse _namespace_name "CuDNNLSTM" |> NamespacedName

    /// <summary>
    /// Custom layer defined by user
    /// <see href="https://w3id.org/nno/ontology#CustomLayer"></see></summary>
    let CustomLayer =
        Namespaced_IRI.parse _namespace_name "CustomLayer" |> NamespacedName

    /// <summary>
    /// Just your regular densely-connected NN layer.
    /// <see href="https://w3id.org/nno/ontology#Dense"></see></summary>
    let Dense = Namespaced_IRI.parse _namespace_name "Dense" |> NamespacedName

    /// <summary>
    /// Depthwise separable 2D convolution.
    ///
    /// Depthwise Separable convolutions consists in performing just the first step in a depthwise spatial convolution (which acts on each input channel separately).
    /// <see href="https://w3id.org/nno/ontology#DepthwiseConv2D"></see></summary>
    let DepthwiseConv2D =
        Namespaced_IRI.parse _namespace_name "DepthwiseConv2D" |> NamespacedName

    /// <summary>
    /// Applies Dropout to the input.
    /// <see href="https://w3id.org/nno/ontology#Dropout"></see></summary>
    let Dropout = Namespaced_IRI.parse _namespace_name "Dropout" |> NamespacedName
    /// <summary>
    /// Turns positive integers (indexes) into dense vectors of fixed size.
    /// <see href="https://w3id.org/nno/ontology#Embedding"></see></summary>
    let Embedding = Namespaced_IRI.parse _namespace_name "Embedding" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#EmbeddingLayer"></see>
    /// </summary>
    let EmbeddingLayer =
        Namespaced_IRI.parse _namespace_name "EmbeddingLayer" |> NamespacedName

    /// <summary>
    /// Flattens the input. Does not affect the batch size.
    /// <see href="https://w3id.org/nno/ontology#Flatten"></see></summary>
    let Flatten = Namespaced_IRI.parse _namespace_name "Flatten" |> NamespacedName
    /// <summary>
    /// Gated Recurrent Unit - Cho et al. 2014.
    ///
    /// There are two variants. The default one is based on 1406.1078v3 and has reset gate applied to hidden state before matrix multiplication. The other one is based on original 1406.1078v1 and has the order reversed.
    /// <see href="https://w3id.org/nno/ontology#GRU"></see></summary>
    let GRU = Namespaced_IRI.parse _namespace_name "GRU" |> NamespacedName
    /// <summary>
    /// Cell class for the GRU layer.
    /// <see href="https://w3id.org/nno/ontology#GRUCell"></see></summary>
    let GRUCell = Namespaced_IRI.parse _namespace_name "GRUCell" |> NamespacedName

    /// <summary>
    /// Global average pooling operation for temporal data.
    /// <see href="https://w3id.org/nno/ontology#GlobalAveragePooling1D"></see></summary>
    let GlobalAveragePooling1D =
        Namespaced_IRI.parse _namespace_name "GlobalAveragePooling1D" |> NamespacedName

    /// <summary>
    /// Global average pooling operation for spatial data.
    /// <see href="https://w3id.org/nno/ontology#GlobalAveragePooling2D"></see></summary>
    let GlobalAveragePooling2D =
        Namespaced_IRI.parse _namespace_name "GlobalAveragePooling2D" |> NamespacedName

    /// <summary>
    /// Global Average pooling operation for 3D data.
    /// <see href="https://w3id.org/nno/ontology#GlobalAveragePooling3D"></see></summary>
    let GlobalAveragePooling3D =
        Namespaced_IRI.parse _namespace_name "GlobalAveragePooling3D" |> NamespacedName

    /// <summary>
    /// Global max pooling operation for temporal data.
    /// <see href="https://w3id.org/nno/ontology#GlobalMaxPooling1D"></see></summary>
    let GlobalMaxPooling1D =
        Namespaced_IRI.parse _namespace_name "GlobalMaxPooling1D" |> NamespacedName

    /// <summary>
    /// Global max pooling operation for spatial data.
    /// <see href="https://w3id.org/nno/ontology#GlobalMaxPooling2D"></see></summary>
    let GlobalMaxPooling2D =
        Namespaced_IRI.parse _namespace_name "GlobalMaxPooling2D" |> NamespacedName

    /// <summary>
    /// Global Max pooling operation for 3D data.
    /// <see href="https://w3id.org/nno/ontology#GlobalMaxPooling3D"></see></summary>
    let GlobalMaxPooling3D =
        Namespaced_IRI.parse _namespace_name "GlobalMaxPooling3D" |> NamespacedName

    /// <summary>
    /// Input() is used to instantiate a Keras tensor.
    ///
    /// A Keras tensor is a tensor object from the underlying backend (Theano, TensorFlow or CNTK), which we augment with certain attributes that allow us to build a Keras model just by knowing the inputs and outputs of the model.
    /// <see href="https://w3id.org/nno/ontology#Input"></see></summary>
    let Input = Namespaced_IRI.parse _namespace_name "Input" |> NamespacedName
    /// <summary>
    /// Input (e.g. data set).
    /// <see href="https://w3id.org/nno/ontology#InputLayer"></see></summary>
    let InputLayer = Namespaced_IRI.parse _namespace_name "InputLayer" |> NamespacedName
    /// <summary>
    /// Long Short-Term Memory layer - Hochreiter 1997.
    /// <see href="https://w3id.org/nno/ontology#LSTM"></see></summary>
    let LSTM = Namespaced_IRI.parse _namespace_name "LSTM" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#LSTMCell"></see>
    /// </summary>
    let LSTMCell = Namespaced_IRI.parse _namespace_name "LSTMCell" |> NamespacedName
    /// <summary>
    /// Wraps arbitrary expression as a Layer object.
    /// <see href="https://w3id.org/nno/ontology#Lambda"></see></summary>
    let Lambda = Namespaced_IRI.parse _namespace_name "Lambda" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#Locally-connectedLayer"></see>
    /// </summary>
    let ``Locally-connectedLayer`` =
        Namespaced_IRI.parse _namespace_name "Locally-connectedLayer" |> NamespacedName

    /// <summary>
    /// Locally-connected layer for 1D inputs.
    /// <see href="https://w3id.org/nno/ontology#LocallyConnected1D"></see></summary>
    let LocallyConnected1D =
        Namespaced_IRI.parse _namespace_name "LocallyConnected1D" |> NamespacedName

    /// <summary>
    /// Locally-connected layer for 2D inputs.
    /// <see href="https://w3id.org/nno/ontology#LocallyConnected2D"></see></summary>
    let LocallyConnected2D =
        Namespaced_IRI.parse _namespace_name "LocallyConnected2D" |> NamespacedName

    /// <summary>
    /// Masks a sequence by using a mask value to skip timesteps.
    /// <see href="https://w3id.org/nno/ontology#Masking"></see></summary>
    let Masking = Namespaced_IRI.parse _namespace_name "Masking" |> NamespacedName

    /// <summary>
    /// Max pooling operation for temporal data.
    /// <see href="https://w3id.org/nno/ontology#MaxPooling1D"></see></summary>
    let MaxPooling1D =
        Namespaced_IRI.parse _namespace_name "MaxPooling1D" |> NamespacedName

    /// <summary>
    /// Max pooling operation for spatial data.
    /// <see href="https://w3id.org/nno/ontology#MaxPooling2D"></see></summary>
    let MaxPooling2D =
        Namespaced_IRI.parse _namespace_name "MaxPooling2D" |> NamespacedName

    /// <summary>
    /// Max pooling operation for 3D data (spatial or spatio-temporal).
    /// <see href="https://w3id.org/nno/ontology#MaxPooling3D"></see></summary>
    let MaxPooling3D =
        Namespaced_IRI.parse _namespace_name "MaxPooling3D" |> NamespacedName

    /// <summary>
    /// Model of the repository.
    /// <see href="https://w3id.org/nno/ontology#Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName
    /// <summary>
    /// Optimizer used by Neural Network.
    /// <see href="https://w3id.org/nno/ontology#Optimizer"></see></summary>
    let Optimizer = Namespaced_IRI.parse _namespace_name "Optimizer" |> NamespacedName
    /// <summary>
    /// Permutes the dimensions of the input according to a given pattern.
    ///
    /// Useful for e.g. connecting RNNs and convnets together.
    /// <see href="https://w3id.org/nno/ontology#Permute"></see></summary>
    let Permute = Namespaced_IRI.parse _namespace_name "Permute" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#RNN"></see>
    /// </summary>
    let RNN = Namespaced_IRI.parse _namespace_name "RNN" |> NamespacedName

    /// <summary>
    /// Loss function typically used for regression problems.
    /// <see href="https://w3id.org/nno/ontology#RegressiveLoss"></see></summary>
    let RegressiveLoss =
        Namespaced_IRI.parse _namespace_name "RegressiveLoss" |> NamespacedName

    /// <summary>
    /// Repeats the input n times.
    /// <see href="https://w3id.org/nno/ontology#RepeatVector"></see></summary>
    let RepeatVector =
        Namespaced_IRI.parse _namespace_name "RepeatVector" |> NamespacedName

    /// <summary>
    /// Reshapes an output to a certain shape.
    /// <see href="https://w3id.org/nno/ontology#Reshape"></see></summary>
    let Reshape = Namespaced_IRI.parse _namespace_name "Reshape" |> NamespacedName

    /// <summary>
    /// Depthwise separable 1D convolution.
    ///
    /// Separable convolutions consist in first performing a depthwise spatial convolution (which acts on each input channel separately) followed by a pointwise convolution which mixes together the resulting output channels.
    ///
    /// Intuitively, separable convolutions can be understood as a way to factorize a convolution kernel into two smaller kernels, or as an extreme version of an Inception block.
    /// <see href="https://w3id.org/nno/ontology#SeparableConv1D"></see></summary>
    let SeparableConv1D =
        Namespaced_IRI.parse _namespace_name "SeparableConv1D" |> NamespacedName

    /// <summary>
    /// Depthwise separable 2D convolution.
    ///
    /// Separable convolutions consist in first performing a depthwise spatial convolution (which acts on each input channel separately) followed by a pointwise convolution which mixes together the resulting output channels.
    ///
    /// Intuitively, separable convolutions can be understood as a way to factorize a convolution kernel into two smaller kernels, or as an extreme version of an Inception block.
    /// <see href="https://w3id.org/nno/ontology#SeparableConv2D"></see></summary>
    let SeparableConv2D =
        Namespaced_IRI.parse _namespace_name "SeparableConv2D" |> NamespacedName

    /// <summary>
    /// Fully-connected RNN where the output is to be fed back to input.
    /// <see href="https://w3id.org/nno/ontology#SimpleRNN"></see></summary>
    let SimpleRNN = Namespaced_IRI.parse _namespace_name "SimpleRNN" |> NamespacedName

    /// <summary>
    /// Cell class for SimpleRNN.
    /// <see href="https://w3id.org/nno/ontology#SimpleRNNCell"></see></summary>
    let SimpleRNNCell =
        Namespaced_IRI.parse _namespace_name "SimpleRNNCell" |> NamespacedName

    /// <summary>
    /// Spatial 1D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 1D feature maps instead of individual elements. If adjacent frames within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout1D will help promote independence between feature maps and should be used instead.
    /// <see href="https://w3id.org/nno/ontology#SpatialDropout1D"></see></summary>
    let SpatialDropout1D =
        Namespaced_IRI.parse _namespace_name "SpatialDropout1D" |> NamespacedName

    /// <summary>
    /// Spatial 2D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 2D feature maps instead of individual elements. If adjacent pixels within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout2D will help promote independence between feature maps and should be used instead.
    /// <see href="https://w3id.org/nno/ontology#SpatialDropout2D"></see></summary>
    let SpatialDropout2D =
        Namespaced_IRI.parse _namespace_name "SpatialDropout2D" |> NamespacedName

    /// <summary>
    /// Spatial 3D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 3D feature maps instead of individual elements. If adjacent pixels within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout3D will help promote independence between feature maps and should be used instead.
    /// <see href="https://w3id.org/nno/ontology#SpatialDropout3D"></see></summary>
    let SpatialDropout3D =
        Namespaced_IRI.parse _namespace_name "SpatialDropout3D" |> NamespacedName

    /// <summary>
    /// Upsampling layer for 1D inputs.
    /// <see href="https://w3id.org/nno/ontology#UpSampling1D"></see></summary>
    let UpSampling1D =
        Namespaced_IRI.parse _namespace_name "UpSampling1D" |> NamespacedName

    /// <summary>
    /// Upsampling layer for 2D inputs.
    ///
    /// Repeats the rows and columns of the data by size[0] and size[1] respectively.
    /// <see href="https://w3id.org/nno/ontology#UpSampling2D"></see></summary>
    let UpSampling2D =
        Namespaced_IRI.parse _namespace_name "UpSampling2D" |> NamespacedName

    /// <summary>
    /// Upsampling layer for 3D inputs.
    ///
    /// Repeats the 1st, 2nd and 3rd dimensions of the data by size[0], size[1] and size[2] respectively.
    /// <see href="https://w3id.org/nno/ontology#UpSampling3D"></see></summary>
    let UpSampling3D =
        Namespaced_IRI.parse _namespace_name "UpSampling3D" |> NamespacedName

    /// <summary>
    /// Zero-padding layer for 1D input (e.g. temporal sequence).
    /// <see href="https://w3id.org/nno/ontology#ZeroPadding1D"></see></summary>
    let ZeroPadding1D =
        Namespaced_IRI.parse _namespace_name "ZeroPadding1D" |> NamespacedName

    /// <summary>
    /// Zero-padding layer for 2D input (e.g. picture).
    ///
    /// This layer can add rows and columns of zeros at the top, bottom, left and right side of an image tensor.
    /// <see href="https://w3id.org/nno/ontology#ZeroPadding2D"></see></summary>
    let ZeroPadding2D =
        Namespaced_IRI.parse _namespace_name "ZeroPadding2D" |> NamespacedName

    /// <summary>
    /// Zero-padding layer for 3D data (spatial or spatio-temporal).
    /// <see href="https://w3id.org/nno/ontology#ZeroPadding3D"></see></summary>
    let ZeroPadding3D =
        Namespaced_IRI.parse _namespace_name "ZeroPadding3D" |> NamespacedName

    /// <summary>
    /// Adadelta is a more robust extension of Adagrad that adapts learning rates based on a moving window of gradient updates, instead of accumulating all past gradients. This way, Adadelta continues learning even when many updates have been done. Compared to Adagrad, in the original version of Adadelta you don't have to set an initial learning rate. In this version, initial learning rate and decay factor can be set, as in most other Keras optimizers.
    /// <see href="https://w3id.org/nno/ontology#adadelta"></see></summary>
    let adadelta = Namespaced_IRI.parse _namespace_name "adadelta" |> NamespacedName
    /// <summary>
    /// Adagrad is an optimizer with parameter-specific learning rates, which are adapted relative to how frequently a parameter gets updated during training. The more updates a parameter receives, the smaller the learning rate.
    /// <see href="https://w3id.org/nno/ontology#adagrad"></see></summary>
    let adagrad = Namespaced_IRI.parse _namespace_name "adagrad" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#adam"></see>
    /// </summary>
    let adam = Namespaced_IRI.parse _namespace_name "adam" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#adamax"></see>
    /// </summary>
    let adamax = Namespaced_IRI.parse _namespace_name "adamax" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#binarycrossentropy"></see>
    /// </summary>
    let binarycrossentropy =
        Namespaced_IRI.parse _namespace_name "binarycrossentropy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#categoricalcrossentropy"></see>
    /// </summary>
    let categoricalcrossentropy =
        Namespaced_IRI.parse _namespace_name "categoricalcrossentropy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#categoricalhinge"></see>
    /// </summary>
    let categoricalhinge =
        Namespaced_IRI.parse _namespace_name "categoricalhinge" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#cosineproximity"></see>
    /// </summary>
    let cosineproximity =
        Namespaced_IRI.parse _namespace_name "cosineproximity" |> NamespacedName

    /// <summary>
    /// Custom loss function defined by user
    /// <see href="https://w3id.org/nno/ontology#customloss"></see></summary>
    let customloss = Namespaced_IRI.parse _namespace_name "customloss" |> NamespacedName

    /// <summary>
    /// Custom optimizer defined by user
    /// <see href="https://w3id.org/nno/ontology#customoptimizer"></see></summary>
    let customoptimizer =
        Namespaced_IRI.parse _namespace_name "customoptimizer" |> NamespacedName

    /// <summary>
    /// Describes the used dataset for training and evaluating
    /// <see href="https://w3id.org/nno/ontology#dataset"></see></summary>
    let dataset = Namespaced_IRI.parse _namespace_name "dataset" |> NamespacedName

    /// <summary>
    /// Base model from keras application
    /// <see href="https://w3id.org/nno/ontology#hasBaseModel"></see></summary>
    let hasBaseModel =
        Namespaced_IRI.parse _namespace_name "hasBaseModel" |> NamespacedName

    /// <summary>
    /// Keywords of base model
    /// <see href="https://w3id.org/nno/ontology#hasBaseModelKeywords"></see></summary>
    let hasBaseModelKeywords =
        Namespaced_IRI.parse _namespace_name "hasBaseModelKeywords" |> NamespacedName

    /// <summary>
    /// Number of downloads for this particular model.
    /// <see href="https://w3id.org/nno/ontology#hasDownloadCount"></see></summary>
    let hasDownloadCount =
        Namespaced_IRI.parse _namespace_name "hasDownloadCount" |> NamespacedName

    /// <summary>
    /// Layer of the Neural Network.
    /// <see href="https://w3id.org/nno/ontology#hasLayer"></see></summary>
    let hasLayer = Namespaced_IRI.parse _namespace_name "hasLayer" |> NamespacedName

    /// <summary>
    /// Keywords of a layer
    /// <see href="https://w3id.org/nno/ontology#hasLayerKeywords"></see></summary>
    let hasLayerKeywords =
        Namespaced_IRI.parse _namespace_name "hasLayerKeywords" |> NamespacedName

    /// <summary>
    /// Parameters of a layer
    /// <see href="https://w3id.org/nno/ontology#hasLayerParameters"></see></summary>
    let hasLayerParameters =
        Namespaced_IRI.parse _namespace_name "hasLayerParameters" |> NamespacedName

    /// <summary>
    /// Specifies the sequence of the layers. Starts at 1, the number of layers is n-1, at n: Number of layers.
    /// <see href="https://w3id.org/nno/ontology#hasLayerSequence"></see></summary>
    let hasLayerSequence =
        Namespaced_IRI.parse _namespace_name "hasLayerSequence" |> NamespacedName

    /// <summary>
    /// Loss function used by Neural Network.
    /// <see href="https://w3id.org/nno/ontology#hasLossFunction"></see></summary>
    let hasLossFunction =
        Namespaced_IRI.parse _namespace_name "hasLossFunction" |> NamespacedName

    /// <summary>
    /// Reflects potential real-world impact of the Model.
    /// Determines the Accuracy, Precision etc. of the model.
    /// <see href="https://w3id.org/nno/ontology#hasMetric"></see></summary>
    let hasMetric = Namespaced_IRI.parse _namespace_name "hasMetric" |> NamespacedName
    /// <summary>
    /// Model of the repository.
    /// <see href="https://w3id.org/nno/ontology#hasModel"></see></summary>
    let hasModel = Namespaced_IRI.parse _namespace_name "hasModel" |> NamespacedName

    /// <summary>
    /// Specifies the sequence of models, starts at 1
    /// <see href="https://w3id.org/nno/ontology#hasModelSequence"></see></summary>
    let hasModelSequence =
        Namespaced_IRI.parse _namespace_name "hasModelSequence" |> NamespacedName

    /// <summary>
    /// type of the model
    /// <see href="https://w3id.org/nno/ontology#hasModelType"></see></summary>
    let hasModelType =
        Namespaced_IRI.parse _namespace_name "hasModelType" |> NamespacedName

    /// <summary>
    /// Optimization function used by Neural Network (e.g. SGD, Adam or RMSprop).
    /// <see href="https://w3id.org/nno/ontology#hasOptimizer"></see></summary>
    let hasOptimizer =
        Namespaced_IRI.parse _namespace_name "hasOptimizer" |> NamespacedName

    /// <summary>
    /// Link to the respository (e.g. github) where the model and further information can be found.
    /// <see href="https://w3id.org/nno/ontology#hasRepositoryLink"></see></summary>
    let hasRepositoryLink =
        Namespaced_IRI.parse _namespace_name "hasRepositoryLink" |> NamespacedName

    /// <summary>
    /// Primary intended use and users (domain) for which the Neural Network was trained for.
    /// <see href="https://w3id.org/nno/ontology#hasintendedUse"></see></summary>
    let hasintendedUse =
        Namespaced_IRI.parse _namespace_name "hasintendedUse" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#hinge"></see>
    /// </summary>
    let hinge = Namespaced_IRI.parse _namespace_name "hinge" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#kullbackleiblerdivergence"></see>
    /// </summary>
    let kullbackleiblerdivergence =
        Namespaced_IRI.parse _namespace_name "kullbackleiblerdivergence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#logcosh"></see>
    /// </summary>
    let logcosh = Namespaced_IRI.parse _namespace_name "logcosh" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#meanabsoluteerror"></see>
    /// </summary>
    let meanabsoluteerror =
        Namespaced_IRI.parse _namespace_name "meanabsoluteerror" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#meanabsolutepercentageerror"></see>
    /// </summary>
    let meanabsolutepercentageerror =
        Namespaced_IRI.parse _namespace_name "meanabsolutepercentageerror" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#meansquarederror"></see>
    /// </summary>
    let meansquarederror =
        Namespaced_IRI.parse _namespace_name "meansquarederror" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#meansquaredlogarithmicerror"></see>
    /// </summary>
    let meansquaredlogarithmicerror =
        Namespaced_IRI.parse _namespace_name "meansquaredlogarithmicerror" |> NamespacedName

    /// <summary>
    /// Much like Adam is essentially RMSprop with momentum, Nadam is Adam RMSprop with Nesterov momentum.
    /// <see href="https://w3id.org/nno/ontology#nadam"></see></summary>
    let nadam = Namespaced_IRI.parse _namespace_name "nadam" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#ontologyhuberloss"></see>
    /// </summary>
    let ontologyhuberloss =
        Namespaced_IRI.parse _namespace_name "ontologyhuberloss" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#poisson"></see>
    /// </summary>
    let poisson = Namespaced_IRI.parse _namespace_name "poisson" |> NamespacedName
    /// <summary>
    /// This optimizer is usually a good choice for recurrent neural networks.
    /// <see href="https://w3id.org/nno/ontology#rmsprop"></see></summary>
    let rmsprop = Namespaced_IRI.parse _namespace_name "rmsprop" |> NamespacedName
    /// <summary>
    /// Includes support for momentum, learning rate decay, and Nesterov momentum.
    /// <see href="https://w3id.org/nno/ontology#sgd"></see></summary>
    let sgd = Namespaced_IRI.parse _namespace_name "sgd" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#sparsecategoricalcrossentropy"></see>
    /// </summary>
    let sparsecategoricalcrossentropy =
        Namespaced_IRI.parse _namespace_name "sparsecategoricalcrossentropy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#squaredhinge"></see>
    /// </summary>
    let squaredhinge =
        Namespaced_IRI.parse _namespace_name "squaredhinge" |> NamespacedName

    /// <summary>
    /// indicates watchers count
    /// <see href="https://w3id.org/nno/ontology#stars"></see></summary>
    let stars = Namespaced_IRI.parse _namespace_name "stars" |> NamespacedName

    /// <summary>
    /// Framework (e.g. Keras, Pandas, numpy, etc.) used to create this model.
    /// <see href="https://w3id.org/nno/ontology#usedFramework"></see></summary>
    let usedFramework =
        Namespaced_IRI.parse _namespace_name "usedFramework" |> NamespacedName
