namespace DoxAletheia
/// https://github.com/vasturiano/force-graph#api-reference
type Force_API =
    // https://github.com/vasturiano/force-graph#data-input
    | GraphData of  string
    | NodeId of  string
    | LinkSource of  string
    | LinkTarget of  string
    // https://github.com/vasturiano/force-graph#data-input
    | Width of  float
    | Height of  float
    | BackgroundColor of  string
    // https://github.com/vasturiano/force-graph#node-styling
    | NodeRelSize of  float
    | NodeVal of  float
    | NodeLabel of  string
    | NodeVisibility of  bool
    | NodeColor of  string
    | NodeAutoColorBy of  string
    | NodeCanvasObject of  CanvasCustomRenderFn<'N>
    | NodeCanvasObjectMode of  U2<string, CanvasCustomRenderModeFn<'N>>
    | NodePointerAreaPaint of  CanvasPointerAreaPaintFn<'N>
    // https://github.com/vasturiano/force-graph#node-styling
    | LinkLabel of  string
    | LinkVisibility of  bool
    | LinkColor of  string
    | LinkAutoColorBy of  string
    | LinkLineDash of  float
    | LinkWidth of  float
    | LinkCurvature of  float
    | LinkCanvasObject of  CanvasCustomRenderFn<'L>
    | LinkCanvasObjectMode of  U2<string, CanvasCustomRenderModeFn<'L>>
    | LinkDirectionalArrowLength of  float
    | LinkDirectionalArrowColor of  string
    | LinkDirectionalArrowRelPos of  float
    | LinkDirectionalParticles of  float
    | LinkDirectionalParticleSpeed of  float
    | LinkDirectionalParticleOffset of  float
    | LinkDirectionalParticleWidth of  float
    | LinkDirectionalParticleColor of  string
    | LinkDirectionalParticleCanvasObject of  CanvasLinkParticleRenderFn<'L>
    | EmitParticle of  link: 'L -> 'ChainableInstance
    | LinkPointerAreaPaint of  CanvasPointerAreaPaintFn<'L>
    | LinkPointerAreaPaint of  renderFn: CanvasPointerAreaPaintFn<'L> -> 'ChainableInstance
    // https://github.com/vasturiano/force-graph#node-styling
    | AutoPauseRedraw of  bool
    | PauseAnimation of  'ChainableInstance
    | ResumeAnimation of  'ChainableInstance
    | CenterAt of  {| x: float; y: float |}
    | CenterAt of  ?x: float * ?y: float * ?durationMs: float -> 'ChainableInstance
    | Zoom of  float
    | Zoom of  scale: float * ?durationMs: float -> 'ChainableInstance
    | ZoomToFit of  ?durationMs: float * ?padding: float * ?nodeFilter: ('N -> bool) -> 'ChainableInstance
    | MinZoom of  float
    | MinZoom of  scale: float -> 'ChainableInstance
    | MaxZoom of  float
    | MaxZoom of  scale: float -> 'ChainableInstance
    | OnRenderFramePre of  callback: (CanvasRenderingContext2D -> float -> unit) -> 'ChainableInstance
    | OnRenderFramePost of  callback: (CanvasRenderingContext2D -> float -> unit) -> 'ChainableInstance
    // https://github.com/vasturiano/force-graph#node-styling
    | DagMode of  DagMode option
    | DagMode of  mode: DagMode option -> 'ChainableInstance
    | DagLevelDistance of  float option
    | DagLevelDistance of  distance: float -> 'ChainableInstance
    | DagNodeFilter of  ('N -> bool)
    | DagNodeFilter of  filterFn: ('N -> bool) -> 'ChainableInstance
    | OnDagError of  (U2<string, float>[] -> unit)
    | OnDagError of  errorHandleFn: (U2<string, float>[] -> unit) -> 'ChainableInstance
    | D3AlphaMin of  float
    | D3AlphaMin of  alphaMin: float -> 'ChainableInstance
    | D3AlphaDecay of  float
    | D3AlphaDecay of  alphaDecay: float -> 'ChainableInstance
    | D3VelocityDecay of  float
    | D3VelocityDecay of  velocityDecay: float -> 'ChainableInstance
    | D3Force of  forceName: U2<string, string> -> ForceFn<'N> option
    | D3Force of  forceName: U2<string, string> * forceFn: ForceFn<'N> option -> 'ChainableInstance
    | D3ReheatSimulation of  'ChainableInstance
    | WarmupTicks of  float
    | WarmupTicks of  ticks: float -> 'ChainableInstance
    | CooldownTicks of  float
    | CooldownTicks of  ticks: float -> 'ChainableInstance
    | CooldownTime of  float
    | CooldownTime of  milliseconds: float -> 'ChainableInstance
    | OnEngineTick of  callback: (unit) -> 'ChainableInstance
    | OnEngineStop of  callback: (unit) -> 'ChainableInstance
    // https://github.com/vasturiano/force-graph#node-styling
    | OnNodeClick of  callback: ('N -> MouseEvent -> unit) -> 'ChainableInstance
    | OnNodeRightClick of  callback: ('N -> MouseEvent -> unit) -> 'ChainableInstance
    | OnNodeHover of  callback: ('N option -> 'N option -> unit) -> 'ChainableInstance
    | OnNodeDrag of  callback: ('N -> {| x: float; y: float |} -> unit) -> 'ChainableInstance
    | OnNodeDragEnd of  callback: ('N -> {| x: float; y: float |} -> unit) -> 'ChainableInstance
    | OnLinkClick of  callback: ('L -> MouseEvent -> unit) -> 'ChainableInstance
    | OnLinkRightClick of  callback: ('L -> MouseEvent -> unit) -> 'ChainableInstance
    | OnLinkHover of  callback: ('L option -> 'L option -> unit) -> 'ChainableInstance
    | LinkHoverPrecision of  float
    | LinkHoverPrecision of  precision: float -> 'ChainableInstance
    | OnBackgroundClick of  callback: (MouseEvent -> unit) -> 'ChainableInstance
    | OnBackgroundRightClick of  callback: (MouseEvent -> unit) -> 'ChainableInstance
    | ShowPointerCursor of  Accessor<U2<'N, 'L> option, bool>
    | ShowPointerCursor of  objAccessor: Accessor<U2<'N, 'L> option, bool> -> 'ChainableInstance
    | OnZoom of  callback: ({| k: float; x: float; y: float |} -> unit) -> 'ChainableInstance
    | OnZoomEnd of  callback: ({| k: float; x: float; y: float |} -> unit) -> 'ChainableInstance
    | EnableNodeDrag of  bool
    | EnableNodeDrag of  enable: bool -> 'ChainableInstance
    | EnableZoomInteraction of  bool
    | EnableZoomInteraction of  enable: U2<bool, (MouseEvent -> bool)> -> 'ChainableInstance
    | EnablePanInteraction of  bool
    | EnablePanInteraction of  enable: U2<bool, (MouseEvent -> bool)> -> 'ChainableInstance
    | EnablePointerInteraction of  bool
    | EnablePointerInteraction of  ?enable: bool -> 'ChainableInstance
    // https://github.com/vasturiano/force-graph#node-styling
    | GetGraphBbox of  ?nodeFilter: ('N -> bool) -> {| x: float * float; y: float * float |}
    | Screen2GraphCoords of  x: float * y: float -> {| x: float; y: float |}
    | Graph2ScreenCoords of  x: float * y: float -> {| x: float; y: float |}
