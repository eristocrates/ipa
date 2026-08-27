namespace https.w3id.org.nno.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nno =
    let _namespace_iri = Namespace_Iri nno |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:nno/ontology#Activation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Applies an activation function to an output."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Activation Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Activation">https://w3id.org/nno/ontology#Activation</seealso>
    let Activation = Prefixed_Name(nno, "Activation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#ActivityRegularization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Layer that applies an update to the cost function based input activity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Activity Regularization Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ActivityRegularization">https://w3id.org/nno/ontology#ActivityRegularization</seealso>
    let ActivityRegularization =
        Prefixed_Name(nno, "ActivityRegularization") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#AveragePooling1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Average pooling for temporal data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Average Pooling 1D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#AveragePooling1D">https://w3id.org/nno/ontology#AveragePooling1D</seealso>
    let AveragePooling1D = Prefixed_Name(nno, "AveragePooling1D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#AveragePooling2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Average pooling operation for spatial data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Average Pooling 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#AveragePooling2D">https://w3id.org/nno/ontology#AveragePooling2D</seealso>
    let AveragePooling2D = Prefixed_Name(nno, "AveragePooling2D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#AveragePooling3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Average pooling operation for 3D data (spatial or spatio-temporal)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Average Pooling 3D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#AveragePooling3D">https://w3id.org/nno/ontology#AveragePooling3D</seealso>
    let AveragePooling3D = Prefixed_Name(nno, "AveragePooling3D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#BaseModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Base model from keras application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Base Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#BaseModel">https://w3id.org/nno/ontology#BaseModel</seealso>
    let BaseModel = Prefixed_Name(nno, "BaseModel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#BatchNormalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Batch normalization layer (Ioffe and Szegedy, 2014).
    ///
    /// Normalize the activations of the previous layer at each batch, i.e. applies a transformation that maintains the mean activation close to 0 and the activation standard deviation close to 1."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Batch Normalization Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#BatchNormalization">https://w3id.org/nno/ontology#BatchNormalization</seealso>
    let BatchNormalization = Prefixed_Name(nno, "BatchNormalization") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Loss function typically used for classification problems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Classification Loss Function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ClassificationLoss">https://w3id.org/nno/ontology#ClassificationLoss</seealso>
    let ClassificationLoss = Prefixed_Name(nno, "ClassificationLoss") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Conv1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"1D convolution layer (e.g. temporal convolution).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input over a single spatial (or temporal) dimension to produce a tensor of outputs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Convolutional 1D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Conv1D">https://w3id.org/nno/ontology#Conv1D</seealso>
    let Conv1D = Prefixed_Name(nno, "Conv1D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Conv2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"2D convolution layer (e.g. spatial convolution over images).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input to produce a tensor of outputs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Convolutional 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Conv2D">https://w3id.org/nno/ontology#Conv2D</seealso>
    let Conv2D = Prefixed_Name(nno, "Conv2D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Conv2DTranspose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Transposed convolution layer (sometimes called Deconvolution).
    ///
    /// The need for transposed convolutions generally arises from the desire to use a transformation going in the opposite direction of a normal convolution, i.e., from something that has the shape of the output of some convolution to something that has the shape of its input while maintaining a connectivity pattern that is compatible with said convolution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Convolutional 2D Transpose Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Conv2DTranspose">https://w3id.org/nno/ontology#Conv2DTranspose</seealso>
    let Conv2DTranspose = Prefixed_Name(nno, "Conv2DTranspose") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Conv3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"3D convolution layer (e.g. spatial convolution over volumes).
    ///
    /// This layer creates a convolution kernel that is convolved with the layer input to produce a tensor of outputs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Convolutional 3D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Conv3D">https://w3id.org/nno/ontology#Conv3D</seealso>
    let Conv3D = Prefixed_Name(nno, "Conv3D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Conv3DTranspose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Transposed convolution layer (sometimes called Deconvolution).
    ///
    /// The need for transposed convolutions generally arises from the desire to use a transformation going in the opposite direction of a normal convolution, i.e., from something that has the shape of the output of some convolution to something that has the shape of its input while maintaining a connectivity pattern that is compatible with said convolution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Convolutional 3D Transpose Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Conv3DTranspose">https://w3id.org/nno/ontology#Conv3DTranspose</seealso>
    let Conv3DTranspose = Prefixed_Name(nno, "Conv3DTranspose") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#ConvLSTM2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Convolutional LSTM.
    ///
    /// It is similar to an LSTM layer, but the input transformations and recurrent transformations are both convolutional."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Convolutional LSTM 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ConvLSTM2D">https://w3id.org/nno/ontology#ConvLSTM2D</seealso>
    let ConvLSTM2D = Prefixed_Name(nno, "ConvLSTM2D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#ConvLSTM2DCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cell class for the ConvLSTM2D layer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Convolutional LSTM 2D Cell Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ConvLSTM2DCell">https://w3id.org/nno/ontology#ConvLSTM2DCell</seealso>
    let ConvLSTM2DCell = Prefixed_Name(nno, "ConvLSTM2DCell") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#ConvolutionalLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Convolutional Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ConvolutionalLayer">https://w3id.org/nno/ontology#ConvolutionalLayer</seealso>
    let ConvolutionalLayer = Prefixed_Name(nno, "ConvolutionalLayer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#CoreLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Core Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#CoreLayer">https://w3id.org/nno/ontology#CoreLayer</seealso>
    let CoreLayer = Prefixed_Name(nno, "CoreLayer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Cropping1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cropping layer for 1D input (e.g. temporal sequence).
    ///
    /// It crops along the time dimension (axis 1)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cropping 1D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Cropping1D">https://w3id.org/nno/ontology#Cropping1D</seealso>
    let Cropping1D = Prefixed_Name(nno, "Cropping1D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Cropping2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cropping layer for 2D input (e.g. picture).
    ///
    /// It crops along spatial dimensions, i.e. height and width."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cropping 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Cropping2D">https://w3id.org/nno/ontology#Cropping2D</seealso>
    let Cropping2D = Prefixed_Name(nno, "Cropping2D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Cropping3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cropping layer for 3D data (e.g. spatial or spatio-temporal)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cropping 3D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Cropping3D">https://w3id.org/nno/ontology#Cropping3D</seealso>
    let Cropping3D = Prefixed_Name(nno, "Cropping3D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#CuDNNGRU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Fast GRU implementation backed by CuDNN.
    ///
    /// Can only be run on GPU, with the TensorFlow backend."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CuDNN GRU Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#CuDNNGRU">https://w3id.org/nno/ontology#CuDNNGRU</seealso>
    let CuDNNGRU = Prefixed_Name(nno, "CuDNNGRU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#CuDNNLSTM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Fast LSTM implementation with CuDNN.
    ///
    /// Can only be run on GPU, with the TensorFlow backend."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CuDNN LSTM Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#CuDNNLSTM">https://w3id.org/nno/ontology#CuDNNLSTM</seealso>
    let CuDNNLSTM = Prefixed_Name(nno, "CuDNNLSTM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#CustomLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Custom layer defined by user"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Custom Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#CustomLayer">https://w3id.org/nno/ontology#CustomLayer</seealso>
    let CustomLayer = Prefixed_Name(nno, "CustomLayer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Dense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Just your regular densely-connected NN layer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dense Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Dense">https://w3id.org/nno/ontology#Dense</seealso>
    let Dense = Prefixed_Name(nno, "Dense") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#DepthwiseConv2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depthwise separable 2D convolution.
    ///
    /// Depthwise Separable convolutions consists in performing just the first step in a depthwise spatial convolution (which acts on each input channel separately)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Depthwise Convolutional 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#DepthwiseConv2D">https://w3id.org/nno/ontology#DepthwiseConv2D</seealso>
    let DepthwiseConv2D = Prefixed_Name(nno, "DepthwiseConv2D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Dropout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Applies Dropout to the input."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dropout Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Dropout">https://w3id.org/nno/ontology#Dropout</seealso>
    let Dropout = Prefixed_Name(nno, "Dropout") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Embedding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Turns positive integers (indexes) into dense vectors of fixed size."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Embedding Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Embedding">https://w3id.org/nno/ontology#Embedding</seealso>
    let Embedding = Prefixed_Name(nno, "Embedding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#EmbeddingLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Embedding Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#EmbeddingLayer">https://w3id.org/nno/ontology#EmbeddingLayer</seealso>
    let EmbeddingLayer = Prefixed_Name(nno, "EmbeddingLayer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Flatten</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Flattens the input. Does not affect the batch size."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Flatten Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Flatten">https://w3id.org/nno/ontology#Flatten</seealso>
    let Flatten = Prefixed_Name(nno, "Flatten") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#GRU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Gated Recurrent Unit - Cho et al. 2014.
    ///
    /// There are two variants. The default one is based on 1406.1078v3 and has reset gate applied to hidden state before matrix multiplication. The other one is based on original 1406.1078v1 and has the order reversed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GRU Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GRU">https://w3id.org/nno/ontology#GRU</seealso>
    let GRU = Prefixed_Name(nno, "GRU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#GRUCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cell class for the GRU layer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GRU Cell Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GRUCell">https://w3id.org/nno/ontology#GRUCell</seealso>
    let GRUCell = Prefixed_Name(nno, "GRUCell") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#GlobalAveragePooling1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Global average pooling operation for temporal data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Global Average Pooling 1D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GlobalAveragePooling1D">https://w3id.org/nno/ontology#GlobalAveragePooling1D</seealso>
    let GlobalAveragePooling1D =
        Prefixed_Name(nno, "GlobalAveragePooling1D") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#GlobalAveragePooling2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Global average pooling operation for spatial data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Global Average Pooling 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GlobalAveragePooling2D">https://w3id.org/nno/ontology#GlobalAveragePooling2D</seealso>
    let GlobalAveragePooling2D =
        Prefixed_Name(nno, "GlobalAveragePooling2D") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#GlobalAveragePooling3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Global Average pooling operation for 3D data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Global Average Pooling 3D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GlobalAveragePooling3D">https://w3id.org/nno/ontology#GlobalAveragePooling3D</seealso>
    let GlobalAveragePooling3D =
        Prefixed_Name(nno, "GlobalAveragePooling3D") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#GlobalMaxPooling1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Global max pooling operation for temporal data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Global Max Pooling 1D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GlobalMaxPooling1D">https://w3id.org/nno/ontology#GlobalMaxPooling1D</seealso>
    let GlobalMaxPooling1D = Prefixed_Name(nno, "GlobalMaxPooling1D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#GlobalMaxPooling2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Global max pooling operation for spatial data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Global Max Pooling 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GlobalMaxPooling2D">https://w3id.org/nno/ontology#GlobalMaxPooling2D</seealso>
    let GlobalMaxPooling2D = Prefixed_Name(nno, "GlobalMaxPooling2D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#GlobalMaxPooling3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Global Max pooling operation for 3D data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Global Max Pooling 3D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#GlobalMaxPooling3D">https://w3id.org/nno/ontology#GlobalMaxPooling3D</seealso>
    let GlobalMaxPooling3D = Prefixed_Name(nno, "GlobalMaxPooling3D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Input() is used to instantiate a Keras tensor.
    ///
    /// A Keras tensor is a tensor object from the underlying backend (Theano, TensorFlow or CNTK), which we augment with certain attributes that allow us to build a Keras model just by knowing the inputs and outputs of the model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Input Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Input">https://w3id.org/nno/ontology#Input</seealso>
    let Input = Prefixed_Name(nno, "Input") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#InputLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Input (e.g. data set)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Input Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#InputLayer">https://w3id.org/nno/ontology#InputLayer</seealso>
    let InputLayer = Prefixed_Name(nno, "InputLayer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#LSTM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Long Short-Term Memory layer - Hochreiter 1997."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LSTM Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#LSTM">https://w3id.org/nno/ontology#LSTM</seealso>
    let LSTM = Prefixed_Name(nno, "LSTM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#LSTMCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Cell class for the LSTM layer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"LSTM Cell Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#LSTMCell">https://w3id.org/nno/ontology#LSTMCell</seealso>
    let LSTMCell = Prefixed_Name(nno, "LSTMCell") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Lambda</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wraps arbitrary expression as a Layer object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lambda Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Lambda">https://w3id.org/nno/ontology#Lambda</seealso>
    let Lambda = Prefixed_Name(nno, "Lambda") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Layer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Layer of the neural network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Layer">https://w3id.org/nno/ontology#Layer</seealso>
    let Layer = Prefixed_Name(nno, "Layer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#Locally-connectedLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Locally-connected Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Locally-connectedLayer">https://w3id.org/nno/ontology#Locally-connectedLayer</seealso>
    let Locally_connectedLayer =
        Prefixed_Name(nno, "Locally-connectedLayer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#LocallyConnected1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Locally-connected layer for 1D inputs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Locally-connected 1D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#LocallyConnected1D">https://w3id.org/nno/ontology#LocallyConnected1D</seealso>
    let LocallyConnected1D = Prefixed_Name(nno, "LocallyConnected1D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#LocallyConnected2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Locally-connected layer for 2D inputs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Locally-connected 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#LocallyConnected2D">https://w3id.org/nno/ontology#LocallyConnected2D</seealso>
    let LocallyConnected2D = Prefixed_Name(nno, "LocallyConnected2D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#LossFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Loss function used by Neural Network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Loss Function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#LossFunction">https://w3id.org/nno/ontology#LossFunction</seealso>
    let LossFunction = Prefixed_Name(nno, "LossFunction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Masking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Masks a sequence by using a mask value to skip timesteps."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Masking Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Masking">https://w3id.org/nno/ontology#Masking</seealso>
    let Masking = Prefixed_Name(nno, "Masking") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#MaxPooling1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Max pooling operation for temporal data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Max Pooling 1D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#MaxPooling1D">https://w3id.org/nno/ontology#MaxPooling1D</seealso>
    let MaxPooling1D = Prefixed_Name(nno, "MaxPooling1D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#MaxPooling2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Max pooling operation for spatial data."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Max Pooling 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#MaxPooling2D">https://w3id.org/nno/ontology#MaxPooling2D</seealso>
    let MaxPooling2D = Prefixed_Name(nno, "MaxPooling2D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#MaxPooling3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Max pooling operation for 3D data (spatial or spatio-temporal)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Max Pooling 3D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#MaxPooling3D">https://w3id.org/nno/ontology#MaxPooling3D</seealso>
    let MaxPooling3D = Prefixed_Name(nno, "MaxPooling3D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Model of the repository."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Model">https://w3id.org/nno/ontology#Model</seealso>
    let Model = Prefixed_Name(nno, "Model") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#NeuralNetwork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Neural Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#NeuralNetwork">https://w3id.org/nno/ontology#NeuralNetwork</seealso>
    let NeuralNetwork = Prefixed_Name(nno, "NeuralNetwork") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#NormalizationLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Normalization Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#NormalizationLayer">https://w3id.org/nno/ontology#NormalizationLayer</seealso>
    let NormalizationLayer = Prefixed_Name(nno, "NormalizationLayer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Optimizer used by Neural Network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Optimizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Optimizer">https://w3id.org/nno/ontology#Optimizer</seealso>
    let Optimizer = Prefixed_Name(nno, "Optimizer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Permute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Permutes the dimensions of the input according to a given pattern.
    ///
    /// Useful for e.g. connecting RNNs and convnets together."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Permute Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Permute">https://w3id.org/nno/ontology#Permute</seealso>
    let Permute = Prefixed_Name(nno, "Permute") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#PoolingLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Pooling Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#PoolingLayer">https://w3id.org/nno/ontology#PoolingLayer</seealso>
    let PoolingLayer = Prefixed_Name(nno, "PoolingLayer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#RNN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nno/ontology#RNN">https://w3id.org/nno/ontology#RNN</seealso>
    let RNN = Prefixed_Name(nno, "RNN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#RecurrentLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Recurrent Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#RecurrentLayer">https://w3id.org/nno/ontology#RecurrentLayer</seealso>
    let RecurrentLayer = Prefixed_Name(nno, "RecurrentLayer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Loss function typically used for regression problems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Regression Loss Function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#RegressiveLoss">https://w3id.org/nno/ontology#RegressiveLoss</seealso>
    let RegressiveLoss = Prefixed_Name(nno, "RegressiveLoss") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#RepeatVector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Repeats the input n times."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Repeat Vector Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#RepeatVector">https://w3id.org/nno/ontology#RepeatVector</seealso>
    let RepeatVector = Prefixed_Name(nno, "RepeatVector") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#Reshape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Reshapes an output to a certain shape."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Reshape Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#Reshape">https://w3id.org/nno/ontology#Reshape</seealso>
    let Reshape = Prefixed_Name(nno, "Reshape") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#SeparableConv1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depthwise separable 1D convolution.
    ///
    /// Separable convolutions consist in first performing a depthwise spatial convolution (which acts on each input channel separately) followed by a pointwise convolution which mixes together the resulting output channels.
    ///
    /// Intuitively, separable convolutions can be understood as a way to factorize a convolution kernel into two smaller kernels, or as an extreme version of an Inception block."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Separable Convolutional 1D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SeparableConv1D">https://w3id.org/nno/ontology#SeparableConv1D</seealso>
    let SeparableConv1D = Prefixed_Name(nno, "SeparableConv1D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#SeparableConv2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Depthwise separable 2D convolution.
    ///
    /// Separable convolutions consist in first performing a depthwise spatial convolution (which acts on each input channel separately) followed by a pointwise convolution which mixes together the resulting output channels.
    ///
    /// Intuitively, separable convolutions can be understood as a way to factorize a convolution kernel into two smaller kernels, or as an extreme version of an Inception block."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Separable Convolutional 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SeparableConv2D">https://w3id.org/nno/ontology#SeparableConv2D</seealso>
    let SeparableConv2D = Prefixed_Name(nno, "SeparableConv2D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#SimpleRNN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Fully-connected RNN where the output is to be fed back to input."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Simple RNN Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SimpleRNN">https://w3id.org/nno/ontology#SimpleRNN</seealso>
    let SimpleRNN = Prefixed_Name(nno, "SimpleRNN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#SimpleRNNCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cell class for SimpleRNN."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Simple RNN Cell Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SimpleRNNCell">https://w3id.org/nno/ontology#SimpleRNNCell</seealso>
    let SimpleRNNCell = Prefixed_Name(nno, "SimpleRNNCell") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#SpatialDropout1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Spatial 1D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 1D feature maps instead of individual elements. If adjacent frames within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout1D will help promote independence between feature maps and should be used instead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spatial Dropout 1D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SpatialDropout1D">https://w3id.org/nno/ontology#SpatialDropout1D</seealso>
    let SpatialDropout1D = Prefixed_Name(nno, "SpatialDropout1D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#SpatialDropout2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Spatial 2D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 2D feature maps instead of individual elements. If adjacent pixels within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout2D will help promote independence between feature maps and should be used instead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spatial Dropout 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SpatialDropout2D">https://w3id.org/nno/ontology#SpatialDropout2D</seealso>
    let SpatialDropout2D = Prefixed_Name(nno, "SpatialDropout2D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#SpatialDropout3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Spatial 3D version of Dropout.
    ///
    /// This version performs the same function as Dropout, however it drops entire 3D feature maps instead of individual elements. If adjacent pixels within feature maps are strongly correlated (as is normally the case in early convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an effective learning rate decrease. In this case, SpatialDropout3D will help promote independence between feature maps and should be used instead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spatial Dropout 3D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#SpatialDropout3D">https://w3id.org/nno/ontology#SpatialDropout3D</seealso>
    let SpatialDropout3D = Prefixed_Name(nno, "SpatialDropout3D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#UpSampling1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Upsampling layer for 1D inputs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Upsampling 1D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#UpSampling1D">https://w3id.org/nno/ontology#UpSampling1D</seealso>
    let UpSampling1D = Prefixed_Name(nno, "UpSampling1D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#UpSampling2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Upsampling layer for 2D inputs.
    ///
    /// Repeats the rows and columns of the data by size[0] and size[1] respectively."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Upsampling 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#UpSampling2D">https://w3id.org/nno/ontology#UpSampling2D</seealso>
    let UpSampling2D = Prefixed_Name(nno, "UpSampling2D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#UpSampling3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Upsampling layer for 3D inputs.
    ///
    /// Repeats the 1st, 2nd and 3rd dimensions of the data by size[0], size[1] and size[2] respectively."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Upsampling 3D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#UpSampling3D">https://w3id.org/nno/ontology#UpSampling3D</seealso>
    let UpSampling3D = Prefixed_Name(nno, "UpSampling3D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#ZeroPadding1D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Zero-padding layer for 1D input (e.g. temporal sequence)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Zero-padding 1D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ZeroPadding1D">https://w3id.org/nno/ontology#ZeroPadding1D</seealso>
    let ZeroPadding1D = Prefixed_Name(nno, "ZeroPadding1D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#ZeroPadding2D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Zero-padding layer for 2D input (e.g. picture).
    ///
    /// This layer can add rows and columns of zeros at the top, bottom, left and right side of an image tensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Zero-padding 2D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ZeroPadding2D">https://w3id.org/nno/ontology#ZeroPadding2D</seealso>
    let ZeroPadding2D = Prefixed_Name(nno, "ZeroPadding2D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#ZeroPadding3D</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Zero-padding layer for 3D data (spatial or spatio-temporal)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Zero-padding 3D Layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ZeroPadding3D">https://w3id.org/nno/ontology#ZeroPadding3D</seealso>
    let ZeroPadding3D = Prefixed_Name(nno, "ZeroPadding3D") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#adadelta</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Adadelta is a more robust extension of Adagrad that adapts learning rates based on a moving window of gradient updates, instead of accumulating all past gradients. This way, Adadelta continues learning even when many updates have been done. Compared to Adagrad, in the original version of Adadelta you don't have to set an initial learning rate. In this version, initial learning rate and decay factor can be set, as in most other Keras optimizers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Adadelta Optimizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#adadelta">https://w3id.org/nno/ontology#adadelta</seealso>
    let adadelta = Prefixed_Name(nno, "adadelta") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#adagrad</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Adagrad is an optimizer with parameter-specific learning rates, which are adapted relative to how frequently a parameter gets updated during training. The more updates a parameter receives, the smaller the learning rate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Adagrad Optimizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#adagrad">https://w3id.org/nno/ontology#adagrad</seealso>
    let adagrad = Prefixed_Name(nno, "adagrad") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#adam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///
    /// labels<para>"Adam Optimizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#adam">https://w3id.org/nno/ontology#adam</seealso>
    let adam = Prefixed_Name(nno, "adam") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#adamax</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Adamax Optimizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#adamax">https://w3id.org/nno/ontology#adamax</seealso>
    let adamax = Prefixed_Name(nno, "adamax") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#binarycrossentropy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Binary Crossentropy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#binarycrossentropy">https://w3id.org/nno/ontology#binarycrossentropy</seealso>
    let binarycrossentropy = Prefixed_Name(nno, "binarycrossentropy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#categoricalcrossentropy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Categorical Crossentropy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#categoricalcrossentropy">https://w3id.org/nno/ontology#categoricalcrossentropy</seealso>
    let categoricalcrossentropy =
        Prefixed_Name(nno, "categoricalcrossentropy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#categoricalhinge</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Categorical Hinge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#categoricalhinge">https://w3id.org/nno/ontology#categoricalhinge</seealso>
    let categoricalhinge = Prefixed_Name(nno, "categoricalhinge") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#cosineproximity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///
    /// labels<para>"Cosine Proximity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#cosineproximity">https://w3id.org/nno/ontology#cosineproximity</seealso>
    let cosineproximity = Prefixed_Name(nno, "cosineproximity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#customloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#LossFunction</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Custom loss function defined by user"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/nno/ontology#customloss">https://w3id.org/nno/ontology#customloss</seealso>
    let customloss = Prefixed_Name(nno, "customloss") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#customoptimizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>"Custom optimizer defined by user"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Custom Optimizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#customoptimizer">https://w3id.org/nno/ontology#customoptimizer</seealso>
    let customoptimizer = Prefixed_Name(nno, "customoptimizer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Describes the used dataset for training and evaluating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"data set"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#dataset">https://w3id.org/nno/ontology#dataset</seealso>
    let dataset = Prefixed_Name(nno, "dataset") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasBaseModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Base model from keras application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has base model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasBaseModel">https://w3id.org/nno/ontology#hasBaseModel</seealso>
    let hasBaseModel = Prefixed_Name(nno, "hasBaseModel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#hasBaseModelKeywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Keywords of base model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has base model keywords"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasBaseModelKeywords">https://w3id.org/nno/ontology#hasBaseModelKeywords</seealso>
    let hasBaseModelKeywords =
        Prefixed_Name(nno, "hasBaseModelKeywords") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#hasDownloadCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Number of downloads for this particular model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has download count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasDownloadCount">https://w3id.org/nno/ontology#hasDownloadCount</seealso>
    let hasDownloadCount = Prefixed_Name(nno, "hasDownloadCount") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasLayer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Layer of the Neural Network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasLayer">https://w3id.org/nno/ontology#hasLayer</seealso>
    let hasLayer = Prefixed_Name(nno, "hasLayer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasLayerKeywords</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Keywords of a layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has layer keywords"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasLayerKeywords">https://w3id.org/nno/ontology#hasLayerKeywords</seealso>
    let hasLayerKeywords = Prefixed_Name(nno, "hasLayerKeywords") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasLayerParameters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Parameters of a layer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has layer parameters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasLayerParameters">https://w3id.org/nno/ontology#hasLayerParameters</seealso>
    let hasLayerParameters = Prefixed_Name(nno, "hasLayerParameters") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasLayerSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the sequence of the layers. Starts at 1, the number of layers is n-1, at n: Number of layers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has layer sequence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasLayerSequence">https://w3id.org/nno/ontology#hasLayerSequence</seealso>
    let hasLayerSequence = Prefixed_Name(nno, "hasLayerSequence") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasLossFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Loss function used by Neural Network."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has loss function"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasLossFunction">https://w3id.org/nno/ontology#hasLossFunction</seealso>
    let hasLossFunction = Prefixed_Name(nno, "hasLossFunction") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Reflects potential real-world impact of the Model.
    /// Determines the Accuracy, Precision etc. of the model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has metric"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasMetric">https://w3id.org/nno/ontology#hasMetric</seealso>
    let hasMetric = Prefixed_Name(nno, "hasMetric") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Model of the repository."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasModel">https://w3id.org/nno/ontology#hasModel</seealso>
    let hasModel = Prefixed_Name(nno, "hasModel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasModelSequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the sequence of models, starts at 1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has model sequence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasModelSequence">https://w3id.org/nno/ontology#hasModelSequence</seealso>
    let hasModelSequence = Prefixed_Name(nno, "hasModelSequence") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasModelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"type of the model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has model type"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasModelType">https://w3id.org/nno/ontology#hasModelType</seealso>
    let hasModelType = Prefixed_Name(nno, "hasModelType") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasOptimizer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Optimization function used by Neural Network (e.g. SGD, Adam or RMSprop)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has optimizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasOptimizer">https://w3id.org/nno/ontology#hasOptimizer</seealso>
    let hasOptimizer = Prefixed_Name(nno, "hasOptimizer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasRepositoryLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Link to the respository (e.g. github) where the model and further information can be found."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has repository link"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasRepositoryLink">https://w3id.org/nno/ontology#hasRepositoryLink</seealso>
    let hasRepositoryLink = Prefixed_Name(nno, "hasRepositoryLink") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hasintendedUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Primary intended use and users (domain) for which the Neural Network was trained for."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has intended use"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hasintendedUse">https://w3id.org/nno/ontology#hasintendedUse</seealso>
    let hasintendedUse = Prefixed_Name(nno, "hasintendedUse") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#hinge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///
    /// labels<para>"Hinge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#hinge">https://w3id.org/nno/ontology#hinge</seealso>
    let hinge = Prefixed_Name(nno, "hinge") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#kullbackleiblerdivergence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///
    /// labels<para>"Kullback Leibler Divergence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#kullbackleiblerdivergence">https://w3id.org/nno/ontology#kullbackleiblerdivergence</seealso>
    let kullbackleiblerdivergence =
        Prefixed_Name(nno, "kullbackleiblerdivergence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#logcosh</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Log Cosh Loss"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#logcosh">https://w3id.org/nno/ontology#logcosh</seealso>
    let logcosh = Prefixed_Name(nno, "logcosh") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#meanabsoluteerror</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///
    /// labels<para>"Mean Absolute Error"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#meanabsoluteerror">https://w3id.org/nno/ontology#meanabsoluteerror</seealso>
    let meanabsoluteerror = Prefixed_Name(nno, "meanabsoluteerror") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#meanabsolutepercentageerror</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///
    /// labels<para>"Mean Absolute Percentage Error"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#meanabsolutepercentageerror">https://w3id.org/nno/ontology#meanabsolutepercentageerror</seealso>
    let meanabsolutepercentageerror =
        Prefixed_Name(nno, "meanabsolutepercentageerror") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#meansquarederror</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mean Squared Error"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#meansquarederror">https://w3id.org/nno/ontology#meansquarederror</seealso>
    let meansquarederror = Prefixed_Name(nno, "meansquarederror") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#meansquaredlogarithmicerror</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mean Squared Logarithmic Error"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#meansquaredlogarithmicerror">https://w3id.org/nno/ontology#meansquaredlogarithmicerror</seealso>
    let meansquaredlogarithmicerror =
        Prefixed_Name(nno, "meansquaredlogarithmicerror") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#nadam</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>"Much like Adam is essentially RMSprop with momentum, Nadam is Adam RMSprop with Nesterov momentum."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nesterov Adam Optimizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#nadam">https://w3id.org/nno/ontology#nadam</seealso>
    let nadam = Prefixed_Name(nno, "nadam") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#ontologyhuberloss</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Huber Loss"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#ontologyhuberloss">https://w3id.org/nno/ontology#ontologyhuberloss</seealso>
    let ontologyhuberloss = Prefixed_Name(nno, "ontologyhuberloss") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#poisson</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#RegressiveLoss</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Poisson"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#poisson">https://w3id.org/nno/ontology#poisson</seealso>
    let poisson = Prefixed_Name(nno, "poisson") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#rmsprop</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This optimizer is usually a good choice for recurrent neural networks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RMSProp Optimizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#rmsprop">https://w3id.org/nno/ontology#rmsprop</seealso>
    let rmsprop = Prefixed_Name(nno, "rmsprop") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#sgd</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:nno/ontology#Optimizer</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Includes support for momentum, learning rate decay, and Nesterov momentum."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stochastic Gradient Descent Optimizer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#sgd">https://w3id.org/nno/ontology#sgd</seealso>
    let sgd = Prefixed_Name(nno, "sgd") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#sparsecategoricalcrossentropy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///
    /// labels<para>"Sparse Categorical Crossentropy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#sparsecategoricalcrossentropy">https://w3id.org/nno/ontology#sparsecategoricalcrossentropy</seealso>
    let sparsecategoricalcrossentropy =
        Prefixed_Name(nno, "sparsecategoricalcrossentropy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:nno/ontology#squaredhinge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:nno/ontology#ClassificationLoss</para>
    ///
    /// labels<para>"Squared Hinge"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#squaredhinge">https://w3id.org/nno/ontology#squaredhinge</seealso>
    let squaredhinge = Prefixed_Name(nno, "squaredhinge") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#stars</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"indicates watchers count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"stars"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#stars">https://w3id.org/nno/ontology#stars</seealso>
    let stars = Prefixed_Name(nno, "stars") |> PrefixedName
    /// <summary>
    ///   <para>w3id:nno/ontology#usedFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Framework (e.g. Keras, Pandas, numpy, etc.) used to create this model."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"used framework"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/nno/ontology#usedFramework">https://w3id.org/nno/ontology#usedFramework</seealso>
    let usedFramework = Prefixed_Name(nno, "usedFramework") |> PrefixedName
