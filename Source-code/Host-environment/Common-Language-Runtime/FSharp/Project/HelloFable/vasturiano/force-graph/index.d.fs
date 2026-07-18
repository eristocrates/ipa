// ts2fable 0.9.0
module rec moduleName
open System
open Fable.Core
open Fable.Core.JS
open Browser.Types


type [<AllowNullLiteral>] IExports =
    abstract ForceGraphGeneric: ForceGraphGenericStatic
    abstract ForceGraph: ForceGraphStatic

type GraphData =
    GraphData<NodeObject, LinkObject<NodeObject>>

type GraphData<'N when 'N :> NodeObject> =
    GraphData<'N, LinkObject<'N>>

type [<AllowNullLiteral>] GraphData<'N, 'L when 'N :> NodeObject and 'L :> LinkObject<'N>> =
    abstract nodes: 'N[] with get, set
    abstract links: 'L[] with get, set

type [<AllowNullLiteral>] NodeObject =
    abstract id: U2<string, float> option with get, set
    abstract index: float option with get, set
    abstract x: float option with get, set
    abstract y: float option with get, set
    abstract vx: float option with get, set
    abstract vy: float option with get, set
    abstract fx: float option with get, set
    abstract fy: float option with get, set

type LinkObject =
    LinkObject<NodeObject>

type [<AllowNullLiteral>] LinkObject<'N when 'N :> NodeObject> =
    abstract source: U3<string, float, 'N> option with get, set
    abstract target: U3<string, float, 'N> option with get, set

type Accessor<'In, 'Out> =
    U3<'Out, string, ('In -> 'Out)>

type NodeAccessor<'T, 'N> =
    Accessor<'N, 'T>

type LinkAccessor<'T, 'N, 'L> =
    Accessor<'L, 'T>

type Label =
    U2<string, HTMLElement>

type [<StringEnum>] [<RequireQualifiedAccess>] CanvasCustomRenderMode =
    | Replace
    | Before
    | After

type [<AllowNullLiteral>] CanvasCustomRenderModeFn<'T> =
    [<Emit("$0($1...)")>] abstract Invoke: obj: 'T -> U2<CanvasCustomRenderMode, obj option>

type [<AllowNullLiteral>] CanvasCustomRenderFn<'T> =
    [<Emit("$0($1...)")>] abstract Invoke: obj: 'T * canvasContext: CanvasRenderingContext2D * globalScale: float -> unit

type [<AllowNullLiteral>] CanvasPointerAreaPaintFn<'T> =
    [<Emit("$0($1...)")>] abstract Invoke: obj: 'T * paintColor: string * canvasContext: CanvasRenderingContext2D * globalScale: float -> unit

type [<AllowNullLiteral>] CanvasLinkParticleRenderFn<'L> =
    [<Emit("$0($1...)")>] abstract Invoke: x: float * y: float * link: 'L * canvasContext: CanvasRenderingContext2D * globalScale: float -> unit

type [<StringEnum>] [<RequireQualifiedAccess>] DagMode =
    | Td
    | Bu
    | Lr
    | Rl
    | Radialout
    | Radialin

type ForceFn =
    ForceFn<NodeObject>

type [<AllowNullLiteral>] ForceFn<'N when 'N :> NodeObject> =
    [<Emit("$0($1...)")>] abstract Invoke: alpha: float -> unit
    abstract initialize: ('N[] -> obj option[] -> unit) option with get, set
    [<EmitIndexer>] abstract Item: key: string -> obj option with get, set

type ForceGraphGeneric<'ChainableInstance> =
    ForceGraphGeneric<'ChainableInstance, NodeObject, LinkObject<NodeObject>>

type ForceGraphGeneric<'ChainableInstance, 'N when 'N :> NodeObject> =
    ForceGraphGeneric<'ChainableInstance, 'N, LinkObject<'N>>

type [<AllowNullLiteral>] ForceGraphGeneric<'ChainableInstance, 'N, 'L when 'N :> NodeObject and 'L :> LinkObject<'N>> =
    abstract resetProps: unit -> 'ChainableInstance
    abstract _destructor: unit -> unit
    abstract graphData: unit -> GraphData<'N, 'L>
    abstract graphData: data: GraphData<'N, 'L> -> 'ChainableInstance
    abstract nodeId: unit -> string
    abstract nodeId: id: string -> 'ChainableInstance
    abstract linkSource: unit -> string
    abstract linkSource: source: string -> 'ChainableInstance
    abstract linkTarget: unit -> string
    abstract linkTarget: target: string -> 'ChainableInstance
    abstract width: unit -> float
    abstract width: width: float -> 'ChainableInstance
    abstract height: unit -> float
    abstract height: height: float -> 'ChainableInstance
    abstract backgroundColor: unit -> string
    abstract backgroundColor: ?color: string -> 'ChainableInstance
    abstract nodeRelSize: unit -> float
    abstract nodeRelSize: size: float -> 'ChainableInstance
    abstract nodeVal: unit -> NodeAccessor<float, 'N>
    abstract nodeVal: valAccessor: NodeAccessor<float, 'N> -> 'ChainableInstance
    abstract nodeLabel: unit -> NodeAccessor<Label, 'N>
    abstract nodeLabel: labelAccessor: NodeAccessor<Label, 'N> -> 'ChainableInstance
    abstract nodeVisibility: unit -> NodeAccessor<bool, 'N>
    abstract nodeVisibility: visibilityAccessor: NodeAccessor<bool, 'N> -> 'ChainableInstance
    abstract nodeColor: unit -> NodeAccessor<string, 'N>
    abstract nodeColor: colorAccessor: NodeAccessor<string, 'N> -> 'ChainableInstance
    abstract nodeAutoColorBy: unit -> NodeAccessor<string option, 'N>
    abstract nodeAutoColorBy: colorByAccessor: NodeAccessor<string option, 'N> -> 'ChainableInstance
    abstract nodeCanvasObject: unit -> CanvasCustomRenderFn<'N>
    abstract nodeCanvasObject: renderFn: CanvasCustomRenderFn<'N> -> 'ChainableInstance
    abstract nodeCanvasObjectMode: unit -> U2<string, CanvasCustomRenderModeFn<'N>>
    abstract nodeCanvasObjectMode: modeAccessor: U2<string, CanvasCustomRenderModeFn<'N>> -> 'ChainableInstance
    abstract nodePointerAreaPaint: unit -> CanvasPointerAreaPaintFn<'N>
    abstract nodePointerAreaPaint: renderFn: CanvasPointerAreaPaintFn<'N> -> 'ChainableInstance
    abstract linkLabel: unit -> LinkAccessor<Label, 'N, 'L>
    abstract linkLabel: labelAccessor: LinkAccessor<Label, 'N, 'L> -> 'ChainableInstance
    abstract linkVisibility: unit -> LinkAccessor<bool, 'N, 'L>
    abstract linkVisibility: visibilityAccessor: LinkAccessor<bool, 'N, 'L> -> 'ChainableInstance
    abstract linkColor: unit -> LinkAccessor<string, 'N, 'L>
    abstract linkColor: colorAccessor: LinkAccessor<string, 'N, 'L> -> 'ChainableInstance
    abstract linkAutoColorBy: unit -> LinkAccessor<string option, 'N, 'L>
    abstract linkAutoColorBy: colorByAccessor: LinkAccessor<string option, 'N, 'L> -> 'ChainableInstance
    abstract linkLineDash: unit -> LinkAccessor<float[] option, 'N, 'L>
    abstract linkLineDash: linkLineDashAccessor: LinkAccessor<float[] option, 'N, 'L> -> 'ChainableInstance
    abstract linkWidth: unit -> LinkAccessor<float, 'N, 'L>
    abstract linkWidth: widthAccessor: LinkAccessor<float, 'N, 'L> -> 'ChainableInstance
    abstract linkCurvature: unit -> LinkAccessor<float, 'N, 'L>
    abstract linkCurvature: curvatureAccessor: LinkAccessor<float, 'N, 'L> -> 'ChainableInstance
    abstract linkCanvasObject: unit -> CanvasCustomRenderFn<'L>
    abstract linkCanvasObject: renderFn: CanvasCustomRenderFn<'L> -> 'ChainableInstance
    abstract linkCanvasObjectMode: unit -> U2<string, CanvasCustomRenderModeFn<'L>>
    abstract linkCanvasObjectMode: modeAccessor: U2<string, CanvasCustomRenderModeFn<'L>> -> 'ChainableInstance
    abstract linkDirectionalArrowLength: unit -> LinkAccessor<float, 'N, 'L>
    abstract linkDirectionalArrowLength: lengthAccessor: LinkAccessor<float, 'N, 'L> -> 'ChainableInstance
    abstract linkDirectionalArrowColor: unit -> LinkAccessor<string, 'N, 'L>
    abstract linkDirectionalArrowColor: colorAccessor: LinkAccessor<string, 'N, 'L> -> 'ChainableInstance
    abstract linkDirectionalArrowRelPos: unit -> LinkAccessor<float, 'N, 'L>
    abstract linkDirectionalArrowRelPos: fractionAccessor: LinkAccessor<float, 'N, 'L> -> 'ChainableInstance
    abstract linkDirectionalParticles: unit -> LinkAccessor<float, 'N, 'L>
    abstract linkDirectionalParticles: numParticlesAccessor: LinkAccessor<float, 'N, 'L> -> 'ChainableInstance
    abstract linkDirectionalParticleSpeed: unit -> LinkAccessor<float, 'N, 'L>
    abstract linkDirectionalParticleSpeed: relDistancePerFrameAccessor: LinkAccessor<float, 'N, 'L> -> 'ChainableInstance
    abstract linkDirectionalParticleOffset: unit -> LinkAccessor<float, 'N, 'L>
    abstract linkDirectionalParticleOffset: relOffset: LinkAccessor<float, 'N, 'L> -> 'ChainableInstance
    abstract linkDirectionalParticleWidth: unit -> LinkAccessor<float, 'N, 'L>
    abstract linkDirectionalParticleWidth: widthAccessor: LinkAccessor<float, 'N, 'L> -> 'ChainableInstance
    abstract linkDirectionalParticleColor: unit -> LinkAccessor<string, 'N, 'L>
    abstract linkDirectionalParticleColor: colorAccessor: LinkAccessor<string, 'N, 'L> -> 'ChainableInstance
    abstract linkDirectionalParticleCanvasObject: unit -> CanvasLinkParticleRenderFn<'L>
    abstract linkDirectionalParticleCanvasObject: renderFn: CanvasLinkParticleRenderFn<'L> -> 'ChainableInstance
    abstract emitParticle: link: 'L -> 'ChainableInstance
    abstract linkPointerAreaPaint: unit -> CanvasPointerAreaPaintFn<'L>
    abstract linkPointerAreaPaint: renderFn: CanvasPointerAreaPaintFn<'L> -> 'ChainableInstance
    abstract autoPauseRedraw: unit -> bool
    abstract autoPauseRedraw: ?enable: bool -> 'ChainableInstance
    abstract pauseAnimation: unit -> 'ChainableInstance
    abstract resumeAnimation: unit -> 'ChainableInstance
    abstract centerAt: unit -> {| x: float; y: float |}
    abstract centerAt: ?x: float * ?y: float * ?durationMs: float -> 'ChainableInstance
    abstract zoom: unit -> float
    abstract zoom: scale: float * ?durationMs: float -> 'ChainableInstance
    abstract zoomToFit: ?durationMs: float * ?padding: float * ?nodeFilter: ('N -> bool) -> 'ChainableInstance
    abstract minZoom: unit -> float
    abstract minZoom: scale: float -> 'ChainableInstance
    abstract maxZoom: unit -> float
    abstract maxZoom: scale: float -> 'ChainableInstance
    abstract onRenderFramePre: callback: (CanvasRenderingContext2D -> float -> unit) -> 'ChainableInstance
    abstract onRenderFramePost: callback: (CanvasRenderingContext2D -> float -> unit) -> 'ChainableInstance
    abstract dagMode: unit -> DagMode option
    abstract dagMode: mode: DagMode option -> 'ChainableInstance
    abstract dagLevelDistance: unit -> float option
    abstract dagLevelDistance: distance: float -> 'ChainableInstance
    abstract dagNodeFilter: unit -> ('N -> bool)
    abstract dagNodeFilter: filterFn: ('N -> bool) -> 'ChainableInstance
    abstract onDagError: unit -> (U2<string, float>[] -> unit)
    abstract onDagError: errorHandleFn: (U2<string, float>[] -> unit) -> 'ChainableInstance
    abstract d3AlphaMin: unit -> float
    abstract d3AlphaMin: alphaMin: float -> 'ChainableInstance
    abstract d3AlphaDecay: unit -> float
    abstract d3AlphaDecay: alphaDecay: float -> 'ChainableInstance
    abstract d3VelocityDecay: unit -> float
    abstract d3VelocityDecay: velocityDecay: float -> 'ChainableInstance
    abstract d3Force: forceName: U2<string, string> -> ForceFn<'N> option
    abstract d3Force: forceName: U2<string, string> * forceFn: ForceFn<'N> option -> 'ChainableInstance
    abstract d3ReheatSimulation: unit -> 'ChainableInstance
    abstract warmupTicks: unit -> float
    abstract warmupTicks: ticks: float -> 'ChainableInstance
    abstract cooldownTicks: unit -> float
    abstract cooldownTicks: ticks: float -> 'ChainableInstance
    abstract cooldownTime: unit -> float
    abstract cooldownTime: milliseconds: float -> 'ChainableInstance
    abstract onEngineTick: callback: (unit -> unit) -> 'ChainableInstance
    abstract onEngineStop: callback: (unit -> unit) -> 'ChainableInstance
    abstract onNodeClick: callback: ('N -> MouseEvent -> unit) -> 'ChainableInstance
    abstract onNodeRightClick: callback: ('N -> MouseEvent -> unit) -> 'ChainableInstance
    abstract onNodeHover: callback: ('N option -> 'N option -> unit) -> 'ChainableInstance
    abstract onNodeDrag: callback: ('N -> {| x: float; y: float |} -> unit) -> 'ChainableInstance
    abstract onNodeDragEnd: callback: ('N -> {| x: float; y: float |} -> unit) -> 'ChainableInstance
    abstract onLinkClick: callback: ('L -> MouseEvent -> unit) -> 'ChainableInstance
    abstract onLinkRightClick: callback: ('L -> MouseEvent -> unit) -> 'ChainableInstance
    abstract onLinkHover: callback: ('L option -> 'L option -> unit) -> 'ChainableInstance
    abstract linkHoverPrecision: unit -> float
    abstract linkHoverPrecision: precision: float -> 'ChainableInstance
    abstract onBackgroundClick: callback: (MouseEvent -> unit) -> 'ChainableInstance
    abstract onBackgroundRightClick: callback: (MouseEvent -> unit) -> 'ChainableInstance
    abstract showPointerCursor: unit -> Accessor<U2<'N, 'L> option, bool>
    abstract showPointerCursor: objAccessor: Accessor<U2<'N, 'L> option, bool> -> 'ChainableInstance
    abstract onZoom: callback: ({| k: float; x: float; y: float |} -> unit) -> 'ChainableInstance
    abstract onZoomEnd: callback: ({| k: float; x: float; y: float |} -> unit) -> 'ChainableInstance
    abstract enableNodeDrag: unit -> bool
    abstract enableNodeDrag: enable: bool -> 'ChainableInstance
    abstract enableZoomInteraction: unit -> bool
    abstract enableZoomInteraction: enable: U2<bool, (MouseEvent -> bool)> -> 'ChainableInstance
    abstract enablePanInteraction: unit -> bool
    abstract enablePanInteraction: enable: U2<bool, (MouseEvent -> bool)> -> 'ChainableInstance
    abstract enablePointerInteraction: unit -> bool
    abstract enablePointerInteraction: ?enable: bool -> 'ChainableInstance
    abstract getGraphBbox: ?nodeFilter: ('N -> bool) -> {| x: float * float; y: float * float |}
    abstract screen2GraphCoords: x: float * y: float -> {| x: float; y: float |}
    abstract graph2ScreenCoords: x: float * y: float -> {| x: float; y: float |}

type [<AllowNullLiteral>] ForceGraphGenericStatic =
    [<EmitConstructor>] abstract Create: element: HTMLElement -> ForceGraphGeneric<'ChainableInstance, 'N, 'L>

type ForceGraph =
    ForceGraph<NodeObject, LinkObject<NodeObject>>

type ForceGraph<'N when 'N :> NodeObject> =
    ForceGraph<'N, LinkObject<'N>>

type [<AllowNullLiteral>] ForceGraph<'N, 'L when 'N :> NodeObject and 'L :> LinkObject<'N>> =
    inherit ForceGraphGeneric<ForceGraph<'N, 'L>, 'N, 'L>

type [<AllowNullLiteral>] ForceGraphStatic =
    [<EmitConstructor>] abstract Create: element: HTMLElement -> ForceGraph<'N, 'L>