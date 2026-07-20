namespace https.w3id.org.nno.ontology.hash

open DoxAletheia

module nno =
    let _namespace_name = "https://w3id.org/nno/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#NeuralNetwork"></see>
    /// </summary>
    let NeuralNetwork = _prefix "NeuralNetwork"
    /// <summary>
    /// Layer of the neural network.
    /// <see href="https://w3id.org/nno/ontology#Layer"></see></summary>
    let Layer = _prefix "Layer"
    /// <summary>
    /// Applies an activation function to an output.
    /// <see href="https://w3id.org/nno/ontology#Activation"></see></summary>
    let Activation = _prefix "Activation"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#CoreLayer"></see>
    /// </summary>
    let CoreLayer = _prefix "CoreLayer"
    /// <summary>
    /// Layer that applies an update to the cost function based input activity.
    /// <see href="https://w3id.org/nno/ontology#ActivityRegularization"></see></summary>
    let ActivityRegularization = _prefix "ActivityRegularization"
    /// <summary>
    /// Average pooling for temporal data.
    /// <see href="https://w3id.org/nno/ontology#AveragePooling1D"></see></summary>
    let AveragePooling1D = _prefix "AveragePooling1D"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#PoolingLayer"></see>
    /// </summary>
    let PoolingLayer = _prefix "PoolingLayer"
    /// <summary>
    /// Average pooling operation for spatial data.
    /// <see href="https://w3id.org/nno/ontology#AveragePooling2D"></see></summary>
    let AveragePooling2D = _prefix "AveragePooling2D"
    /// <summary>
    /// Average pooling operation for 3D data (spatial or spatio-temporal).
    /// <see href="https://w3id.org/nno/ontology#AveragePooling3D"></see></summary>
    let AveragePooling3D = _prefix "AveragePooling3D"
    /// <summary>
    /// Base model from keras application
    /// <see href="https://w3id.org/nno/ontology#BaseModel"></see></summary>
    let BaseModel = _prefix "BaseModel"
    /// <summary>
    /// Batch normalization layer (Ioffe and Szegedy, 2014).
    ///
    /// Normalize the activations of the previous layer at each batch, i.e. applies a transformation that maintains the mean activation close to 0 and the activation standard deviation close to 1.
    /// <see href="https://w3id.org/nno/ontology#BatchNormalization"></see></summary>
    let BatchNormalization = _prefix "BatchNormalization"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#NormalizationLayer"></see>
    /// </summary>
    let NormalizationLayer = _prefix "NormalizationLayer"
    /// <summary>
    /// Loss function typically used for classification problems.
    /// <see href="https://w3id.org/nno/ontology#ClassificationLoss"></see></summary>
    let ClassificationLoss = _prefix "ClassificationLoss"
    /// <summary>
    /// Loss function used by Neural Network.
    /// <see href="https://w3id.org/nno/ontology#LossFunction"></see></summary>
    let LossFunction = _prefix "LossFunction"
    /// <summary>
    /// 1D convolution layer (e.g. temporal convolution).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input over a single spatial (or temporal) dimension to produce a tensor of outputs.
    /// <see href="https://w3id.org/nno/ontology#Conv1D"></see></summary>
    let Conv1D = _prefix "Conv1D"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#ConvolutionalLayer"></see>
    /// </summary>
    let ConvolutionalLayer = _prefix "ConvolutionalLayer"
    /// <summary>
    /// 2D convolution layer (e.g. spatial convolution over images).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input to produce a tensor of outputs.
    /// <see href="https://w3id.org/nno/ontology#Conv2D"></see></summary>
    let Conv2D = _prefix "Conv2D"
    /// <summary>
    /// Transposed convolution layer (sometimes called Deconvolution).
    ///
    /// The need for transposed convolutions generally arises from the desire to use a transformation going in the opposite direction of a normal convolution, i.e., from something that has the shape of the output of some convolution to something that has the shape of its input while maintaining a connectivity pattern that is compatible with said convolution.
    /// <see href="https://w3id.org/nno/ontology#Conv2DTranspose"></see></summary>
    let Conv2DTranspose = _prefix "Conv2DTranspose"
    /// <summary>
    /// 3D convolution layer (e.g. spatial convolution over volumes).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input to produce a tensor of outputs.
    /// <see href="https://w3id.org/nno/ontology#Conv3D"></see></summary>
    let Conv3D = _prefix "Conv3D"
    /// <summary>
    /// Transposed convolution layer (sometimes called Deconvolution).
    ///
    /// The need for transposed convolutions generally arises from the desire to use a transformation going in the opposite direction of a normal convolution, i.e., from something that has the shape of the output of some convolution to something that has the shape of its input while maintaining a connectivity pattern that is compatible with said convolution.
    /// <see href="https://w3id.org/nno/ontology#Conv3DTranspose"></see></summary>
    let Conv3DTranspose = _prefix "Conv3DTranspose"
    /// <summary>
    /// Convolutional LSTM.
    ///
    /// It is similar to an LSTM layer, but the input transformations and recurrent transformations are both convolutional.
    /// <see href="https://w3id.org/nno/ontology#ConvLSTM2D"></see></summary>
    let ConvLSTM2D = _prefix "ConvLSTM2D"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#RecurrentLayer"></see>
    /// </summary>
    let RecurrentLayer = _prefix "RecurrentLayer"
    /// <summary>
    /// Cell class for the ConvLSTM2D layer.
    /// <see href="https://w3id.org/nno/ontology#ConvLSTM2DCell"></see></summary>
    let ConvLSTM2DCell = _prefix "ConvLSTM2DCell"
    /// <summary>
    /// Cropping layer for 1D input (e.g. temporal sequence).
    ///
    /// It crops along the time dimension (axis 1).
    /// <see href="https://w3id.org/nno/ontology#Cropping1D"></see></summary>
    let Cropping1D = _prefix "Cropping1D"
    /// <summary>
    /// Cropping layer for 2D input (e.g. picture).
    ///
    /// It crops along spatial dimensions, i.e. height and width.
    /// <see href="https://w3id.org/nno/ontology#Cropping2D"></see></summary>
    let Cropping2D = _prefix "Cropping2D"
    /// <summary>
    /// Cropping layer for 3D data (e.g. spatial or spatio-temporal).
    /// <see href="https://w3id.org/nno/ontology#Cropping3D"></see></summary>
    let Cropping3D = _prefix "Cropping3D"
    /// <summary>
    /// Fast GRU implementation backed by CuDNN.
    ///
    /// Can only be run on GPU, with the TensorFlow backend.
    /// <see href="https://w3id.org/nno/ontology#CuDNNGRU"></see></summary>
    let CuDNNGRU = _prefix "CuDNNGRU"
    /// <summary>
    /// Fast LSTM implementation with CuDNN.
    ///
    /// Can only be run on GPU, with the TensorFlow backend.
    /// <see href="https://w3id.org/nno/ontology#CuDNNLSTM"></see></summary>
    let CuDNNLSTM = _prefix "CuDNNLSTM"
    /// <summary>
    /// Custom layer defined by user
    /// <see href="https://w3id.org/nno/ontology#CustomLayer"></see></summary>
    let CustomLayer = _prefix "CustomLayer"
    /// <summary>
    /// Just your regular densely-connected NN layer.
    /// <see href="https://w3id.org/nno/ontology#Dense"></see></summary>
    let Dense = _prefix "Dense"
    /// <summary>
    /// Depthwise separable 2D convolution.
    ///
    /// Depthwise Separable convolutions consists in performing just the first step in a depthwise spatial convolution (which acts on each input channel separately).
    /// <see href="https://w3id.org/nno/ontology#DepthwiseConv2D"></see></summary>
    let DepthwiseConv2D = _prefix "DepthwiseConv2D"
    /// <summary>
    /// Applies Dropout to the input.
    /// <see href="https://w3id.org/nno/ontology#Dropout"></see></summary>
    let Dropout = _prefix "Dropout"
    /// <summary>
    /// Turns positive integers (indexes) into dense vectors of fixed size.
    /// <see href="https://w3id.org/nno/ontology#Embedding"></see></summary>
    let Embedding = _prefix "Embedding"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#EmbeddingLayer"></see>
    /// </summary>
    let EmbeddingLayer = _prefix "EmbeddingLayer"
    /// <summary>
    /// Flattens the input. Does not affect the batch size.
    /// <see href="https://w3id.org/nno/ontology#Flatten"></see></summary>
    let Flatten = _prefix "Flatten"
    /// <summary>
    /// Gated Recurrent Unit - Cho et al. 2014.
    ///
    /// There are two variants. The default one is based on 1406.1078v3 and has reset gate applied to hidden state before matrix multiplication. The other one is based on original 1406.1078v1 and has the order reversed.
    /// <see href="https://w3id.org/nno/ontology#GRU"></see></summary>
    let GRU = _prefix "GRU"
    /// <summary>
    /// Cell class for the GRU layer.
    /// <see href="https://w3id.org/nno/ontology#GRUCell"></see></summary>
    let GRUCell = _prefix "GRUCell"
    /// <summary>
    /// Global average pooling operation for temporal data.
    /// <see href="https://w3id.org/nno/ontology#GlobalAveragePooling1D"></see></summary>
    let GlobalAveragePooling1D = _prefix "GlobalAveragePooling1D"
    /// <summary>
    /// Global average pooling operation for spatial data.
    /// <see href="https://w3id.org/nno/ontology#GlobalAveragePooling2D"></see></summary>
    let GlobalAveragePooling2D = _prefix "GlobalAveragePooling2D"
    /// <summary>
    /// Global Average pooling operation for 3D data.
    /// <see href="https://w3id.org/nno/ontology#GlobalAveragePooling3D"></see></summary>
    let GlobalAveragePooling3D = _prefix "GlobalAveragePooling3D"
    /// <summary>
    /// Global max pooling operation for temporal data.
    /// <see href="https://w3id.org/nno/ontology#GlobalMaxPooling1D"></see></summary>
    let GlobalMaxPooling1D = _prefix "GlobalMaxPooling1D"
    /// <summary>
    /// Global max pooling operation for spatial data.
    /// <see href="https://w3id.org/nno/ontology#GlobalMaxPooling2D"></see></summary>
    let GlobalMaxPooling2D = _prefix "GlobalMaxPooling2D"
    /// <summary>
    /// Global Max pooling operation for 3D data.
    /// <see href="https://w3id.org/nno/ontology#GlobalMaxPooling3D"></see></summary>
    let GlobalMaxPooling3D = _prefix "GlobalMaxPooling3D"
    /// <summary>
    /// Input() is used to instantiate a Keras tensor.
    ///
    /// A Keras tensor is a tensor object from the underlying backend (Theano, TensorFlow or CNTK), which we augment with certain attributes that allow us to build a Keras model just by knowing the inputs and outputs of the model.
    /// <see href="https://w3id.org/nno/ontology#Input"></see></summary>
    let Input = _prefix "Input"
    /// <summary>
    /// Input (e.g. data set).
    /// <see href="https://w3id.org/nno/ontology#InputLayer"></see></summary>
    let InputLayer = _prefix "InputLayer"
    /// <summary>
    /// Long Short-Term Memory layer - Hochreiter 1997.
    /// <see href="https://w3id.org/nno/ontology#LSTM"></see></summary>
    let LSTM = _prefix "LSTM"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#LSTMCell"></see>
    /// </summary>
    let LSTMCell = _prefix "LSTMCell"
    /// <summary>
    /// Wraps arbitrary expression as a Layer object.
    /// <see href="https://w3id.org/nno/ontology#Lambda"></see></summary>
    let Lambda = _prefix "Lambda"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#Locally-connectedLayer"></see>
    /// </summary>
    let ``Locally-connectedLayer`` = _prefix "Locally-connectedLayer"
    /// <summary>
    /// Locally-connected layer for 1D inputs.
    /// <see href="https://w3id.org/nno/ontology#LocallyConnected1D"></see></summary>
    let LocallyConnected1D = _prefix "LocallyConnected1D"
    /// <summary>
    /// Locally-connected layer for 2D inputs.
    /// <see href="https://w3id.org/nno/ontology#LocallyConnected2D"></see></summary>
    let LocallyConnected2D = _prefix "LocallyConnected2D"
    /// <summary>
    /// Masks a sequence by using a mask value to skip timesteps.
    /// <see href="https://w3id.org/nno/ontology#Masking"></see></summary>
    let Masking = _prefix "Masking"
    /// <summary>
    /// Max pooling operation for temporal data.
    /// <see href="https://w3id.org/nno/ontology#MaxPooling1D"></see></summary>
    let MaxPooling1D = _prefix "MaxPooling1D"
    /// <summary>
    /// Max pooling operation for spatial data.
    /// <see href="https://w3id.org/nno/ontology#MaxPooling2D"></see></summary>
    let MaxPooling2D = _prefix "MaxPooling2D"
    /// <summary>
    /// Max pooling operation for 3D data (spatial or spatio-temporal).
    /// <see href="https://w3id.org/nno/ontology#MaxPooling3D"></see></summary>
    let MaxPooling3D = _prefix "MaxPooling3D"
    /// <summary>
    /// Model of the repository.
    /// <see href="https://w3id.org/nno/ontology#Model"></see></summary>
    let Model = _prefix "Model"
    /// <summary>
    /// Optimizer used by Neural Network.
    /// <see href="https://w3id.org/nno/ontology#Optimizer"></see></summary>
    let Optimizer = _prefix "Optimizer"
    /// <summary>
    /// Permutes the dimensions of the input according to a given pattern.
    ///
    /// Useful for e.g. connecting RNNs and convnets together.
    /// <see href="https://w3id.org/nno/ontology#Permute"></see></summary>
    let Permute = _prefix "Permute"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#RNN"></see>
    /// </summary>
    let RNN = _prefix "RNN"
    /// <summary>
    /// Loss function typically used for regression problems.
    /// <see href="https://w3id.org/nno/ontology#RegressiveLoss"></see></summary>
    let RegressiveLoss = _prefix "RegressiveLoss"
    /// <summary>
    /// Repeats the input n times.
    /// <see href="https://w3id.org/nno/ontology#RepeatVector"></see></summary>
    let RepeatVector = _prefix "RepeatVector"
    /// <summary>
    /// Reshapes an output to a certain shape.
    /// <see href="https://w3id.org/nno/ontology#Reshape"></see></summary>
    let Reshape = _prefix "Reshape"
    /// <summary>
    /// Depthwise separable 1D convolution.
    ///
    /// Separable convolutions consist in first performing a depthwise spatial convolution (which acts on each input channel separately) followed by a pointwise convolution which mixes together the resulting output channels.
    ///
    /// Intuitively, separable convolutions can be understood as a way to factorize a convolution kernel into two smaller kernels, or as an extreme version of an Inception block.
    /// <see href="https://w3id.org/nno/ontology#SeparableConv1D"></see></summary>
    let SeparableConv1D = _prefix "SeparableConv1D"
    /// <summary>
    /// Depthwise separable 2D convolution.
    ///
    /// Separable convolutions consist in first performing a depthwise spatial convolution (which acts on each input channel separately) followed by a pointwise convolution which mixes together the resulting output channels.
    ///
    /// Intuitively, separable convolutions can be understood as a way to factorize a convolution kernel into two smaller kernels, or as an extreme version of an Inception block.
    /// <see href="https://w3id.org/nno/ontology#SeparableConv2D"></see></summary>
    let SeparableConv2D = _prefix "SeparableConv2D"
    /// <summary>
    /// Fully-connected RNN where the output is to be fed back to input.
    /// <see href="https://w3id.org/nno/ontology#SimpleRNN"></see></summary>
    let SimpleRNN = _prefix "SimpleRNN"
    /// <summary>
    /// Cell class for SimpleRNN.
    /// <see href="https://w3id.org/nno/ontology#SimpleRNNCell"></see></summary>
    let SimpleRNNCell = _prefix "SimpleRNNCell"
    /// <summary>
    /// Spatial 1D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 1D feature maps instead of individual elements. If adjacent frames within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout1D will help promote independence between feature maps and should be used instead.
    /// <see href="https://w3id.org/nno/ontology#SpatialDropout1D"></see></summary>
    let SpatialDropout1D = _prefix "SpatialDropout1D"
    /// <summary>
    /// Spatial 2D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 2D feature maps instead of individual elements. If adjacent pixels within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout2D will help promote independence between feature maps and should be used instead.
    /// <see href="https://w3id.org/nno/ontology#SpatialDropout2D"></see></summary>
    let SpatialDropout2D = _prefix "SpatialDropout2D"
    /// <summary>
    /// Spatial 3D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 3D feature maps instead of individual elements. If adjacent pixels within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout3D will help promote independence between feature maps and should be used instead.
    /// <see href="https://w3id.org/nno/ontology#SpatialDropout3D"></see></summary>
    let SpatialDropout3D = _prefix "SpatialDropout3D"
    /// <summary>
    /// Upsampling layer for 1D inputs.
    /// <see href="https://w3id.org/nno/ontology#UpSampling1D"></see></summary>
    let UpSampling1D = _prefix "UpSampling1D"
    /// <summary>
    /// Upsampling layer for 2D inputs.
    ///
    /// Repeats the rows and columns of the data by size[0] and size[1] respectively.
    /// <see href="https://w3id.org/nno/ontology#UpSampling2D"></see></summary>
    let UpSampling2D = _prefix "UpSampling2D"
    /// <summary>
    /// Upsampling layer for 3D inputs.
    ///
    /// Repeats the 1st, 2nd and 3rd dimensions of the data by size[0], size[1] and size[2] respectively.
    /// <see href="https://w3id.org/nno/ontology#UpSampling3D"></see></summary>
    let UpSampling3D = _prefix "UpSampling3D"
    /// <summary>
    /// Zero-padding layer for 1D input (e.g. temporal sequence).
    /// <see href="https://w3id.org/nno/ontology#ZeroPadding1D"></see></summary>
    let ZeroPadding1D = _prefix "ZeroPadding1D"
    /// <summary>
    /// Zero-padding layer for 2D input (e.g. picture).
    ///
    /// This layer can add rows and columns of zeros at the top, bottom, left and right side of an image tensor.
    /// <see href="https://w3id.org/nno/ontology#ZeroPadding2D"></see></summary>
    let ZeroPadding2D = _prefix "ZeroPadding2D"
    /// <summary>
    /// Zero-padding layer for 3D data (spatial or spatio-temporal).
    /// <see href="https://w3id.org/nno/ontology#ZeroPadding3D"></see></summary>
    let ZeroPadding3D = _prefix "ZeroPadding3D"
    /// <summary>
    /// Adadelta is a more robust extension of Adagrad that adapts learning rates based on a moving window of gradient updates, instead of accumulating all past gradients. This way, Adadelta continues learning even when many updates have been done. Compared to Adagrad, in the original version of Adadelta you don't have to set an initial learning rate. In this version, initial learning rate and decay factor can be set, as in most other Keras optimizers.
    /// <see href="https://w3id.org/nno/ontology#adadelta"></see></summary>
    let adadelta = _prefix "adadelta"
    /// <summary>
    /// Adagrad is an optimizer with parameter-specific learning rates, which are adapted relative to how frequently a parameter gets updated during training. The more updates a parameter receives, the smaller the learning rate.
    /// <see href="https://w3id.org/nno/ontology#adagrad"></see></summary>
    let adagrad = _prefix "adagrad"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#adam"></see>
    /// </summary>
    let adam = _prefix "adam"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#adamax"></see>
    /// </summary>
    let adamax = _prefix "adamax"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#binarycrossentropy"></see>
    /// </summary>
    let binarycrossentropy = _prefix "binarycrossentropy"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#categoricalcrossentropy"></see>
    /// </summary>
    let categoricalcrossentropy = _prefix "categoricalcrossentropy"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#categoricalhinge"></see>
    /// </summary>
    let categoricalhinge = _prefix "categoricalhinge"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#cosineproximity"></see>
    /// </summary>
    let cosineproximity = _prefix "cosineproximity"
    /// <summary>
    /// Custom loss function defined by user
    /// <see href="https://w3id.org/nno/ontology#customloss"></see></summary>
    let customloss = _prefix "customloss"
    /// <summary>
    /// Custom optimizer defined by user
    /// <see href="https://w3id.org/nno/ontology#customoptimizer"></see></summary>
    let customoptimizer = _prefix "customoptimizer"
    /// <summary>
    /// Describes the used dataset for training and evaluating
    /// <see href="https://w3id.org/nno/ontology#dataset"></see></summary>
    let dataset = _prefix "dataset"
    /// <summary>
    /// Base model from keras application
    /// <see href="https://w3id.org/nno/ontology#hasBaseModel"></see></summary>
    let hasBaseModel = _prefix "hasBaseModel"
    /// <summary>
    /// Keywords of base model
    /// <see href="https://w3id.org/nno/ontology#hasBaseModelKeywords"></see></summary>
    let hasBaseModelKeywords = _prefix "hasBaseModelKeywords"
    /// <summary>
    /// Number of downloads for this particular model.
    /// <see href="https://w3id.org/nno/ontology#hasDownloadCount"></see></summary>
    let hasDownloadCount = _prefix "hasDownloadCount"
    /// <summary>
    /// Layer of the Neural Network.
    /// <see href="https://w3id.org/nno/ontology#hasLayer"></see></summary>
    let hasLayer = _prefix "hasLayer"
    /// <summary>
    /// Keywords of a layer
    /// <see href="https://w3id.org/nno/ontology#hasLayerKeywords"></see></summary>
    let hasLayerKeywords = _prefix "hasLayerKeywords"
    /// <summary>
    /// Parameters of a layer
    /// <see href="https://w3id.org/nno/ontology#hasLayerParameters"></see></summary>
    let hasLayerParameters = _prefix "hasLayerParameters"
    /// <summary>
    /// Specifies the sequence of the layers. Starts at 1, the number of layers is n-1, at n: Number of layers.
    /// <see href="https://w3id.org/nno/ontology#hasLayerSequence"></see></summary>
    let hasLayerSequence = _prefix "hasLayerSequence"
    /// <summary>
    /// Loss function used by Neural Network.
    /// <see href="https://w3id.org/nno/ontology#hasLossFunction"></see></summary>
    let hasLossFunction = _prefix "hasLossFunction"
    /// <summary>
    /// Reflects potential real-world impact of the Model.
    /// Determines the Accuracy, Precision etc. of the model.
    /// <see href="https://w3id.org/nno/ontology#hasMetric"></see></summary>
    let hasMetric = _prefix "hasMetric"
    /// <summary>
    /// Model of the repository.
    /// <see href="https://w3id.org/nno/ontology#hasModel"></see></summary>
    let hasModel = _prefix "hasModel"
    /// <summary>
    /// Specifies the sequence of models, starts at 1
    /// <see href="https://w3id.org/nno/ontology#hasModelSequence"></see></summary>
    let hasModelSequence = _prefix "hasModelSequence"
    /// <summary>
    /// type of the model
    /// <see href="https://w3id.org/nno/ontology#hasModelType"></see></summary>
    let hasModelType = _prefix "hasModelType"
    /// <summary>
    /// Optimization function used by Neural Network (e.g. SGD, Adam or RMSprop).
    /// <see href="https://w3id.org/nno/ontology#hasOptimizer"></see></summary>
    let hasOptimizer = _prefix "hasOptimizer"
    /// <summary>
    /// Link to the respository (e.g. github) where the model and further information can be found.
    /// <see href="https://w3id.org/nno/ontology#hasRepositoryLink"></see></summary>
    let hasRepositoryLink = _prefix "hasRepositoryLink"
    /// <summary>
    /// Primary intended use and users (domain) for which the Neural Network was trained for.
    /// <see href="https://w3id.org/nno/ontology#hasintendedUse"></see></summary>
    let hasintendedUse = _prefix "hasintendedUse"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#hinge"></see>
    /// </summary>
    let hinge = _prefix "hinge"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#kullbackleiblerdivergence"></see>
    /// </summary>
    let kullbackleiblerdivergence = _prefix "kullbackleiblerdivergence"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#logcosh"></see>
    /// </summary>
    let logcosh = _prefix "logcosh"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#meanabsoluteerror"></see>
    /// </summary>
    let meanabsoluteerror = _prefix "meanabsoluteerror"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#meanabsolutepercentageerror"></see>
    /// </summary>
    let meanabsolutepercentageerror = _prefix "meanabsolutepercentageerror"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#meansquarederror"></see>
    /// </summary>
    let meansquarederror = _prefix "meansquarederror"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#meansquaredlogarithmicerror"></see>
    /// </summary>
    let meansquaredlogarithmicerror = _prefix "meansquaredlogarithmicerror"
    /// <summary>
    /// Much like Adam is essentially RMSprop with momentum, Nadam is Adam RMSprop with Nesterov momentum.
    /// <see href="https://w3id.org/nno/ontology#nadam"></see></summary>
    let nadam = _prefix "nadam"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#ontologyhuberloss"></see>
    /// </summary>
    let ontologyhuberloss = _prefix "ontologyhuberloss"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#poisson"></see>
    /// </summary>
    let poisson = _prefix "poisson"
    /// <summary>
    /// This optimizer is usually a good choice for recurrent neural networks.
    /// <see href="https://w3id.org/nno/ontology#rmsprop"></see></summary>
    let rmsprop = _prefix "rmsprop"
    /// <summary>
    /// Includes support for momentum, learning rate decay, and Nesterov momentum.
    /// <see href="https://w3id.org/nno/ontology#sgd"></see></summary>
    let sgd = _prefix "sgd"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#sparsecategoricalcrossentropy"></see>
    /// </summary>
    let sparsecategoricalcrossentropy = _prefix "sparsecategoricalcrossentropy"
    /// <summary>
    ///   <see href="https://w3id.org/nno/ontology#squaredhinge"></see>
    /// </summary>
    let squaredhinge = _prefix "squaredhinge"
    /// <summary>
    /// indicates watchers count
    /// <see href="https://w3id.org/nno/ontology#stars"></see></summary>
    let stars = _prefix "stars"
    /// <summary>
    /// Framework (e.g. Keras, Pandas, numpy, etc.) used to create this model.
    /// <see href="https://w3id.org/nno/ontology#usedFramework"></see></summary>
    let usedFramework = _prefix "usedFramework"
