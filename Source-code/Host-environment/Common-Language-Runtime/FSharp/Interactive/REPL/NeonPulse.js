const canvas = document.querySelector('#game'),
  ctx = canvas.getContext('2d'),
  stage = document.querySelector('#stage')
const ui = {
  score: document.querySelector('#score'),
  accuracy: document.querySelector('#accuracy'),
  combo: document.querySelector('#combo'),
  overlay: document.querySelector('#overlay'),
  title: document.querySelector('#title'),
  copy: document.querySelector('#copy'),
  start: document.querySelector('#start'),
  judgment: document.querySelector('#judgment'),
  count: document.querySelector('#count'),
  eyebrow: document.querySelector('#eyebrow'),
  sound: document.querySelector('#sound')
}
const colors = ['#ff4f9a', '#42d9ff', '#b8ff5e', '#9b6cff'],
  keys = {
    KeyD: 0,
    ArrowLeft: 0,
    KeyF: 1,
    ArrowDown: 1,
    KeyJ: 2,
    ArrowUp: 2,
    KeyK: 3,
    ArrowRight: 3
  }
let W = 0,
  H = 0,
  dpr = 1,
  running = false,
  paused = false,
  startTime = 0,
  pauseAt = 0,
  score = 0,
  combo = 0,
  hits = 0,
  totalError = 0,
  judged = 0,
  muted = false,
  audio = null,
  nextBeat = 0,
  raf = 0,
  notes = []
const bpm = 118,
  beat = 60000 / bpm,
  travel = 1700,
  hitY = 0.84
function makeChart() {
  notes = []
  let seed = 718391
  const rand = () =>
    ((seed = (Math.imul(seed, 1664525) + 1013904223) | 0) >>> 0) / 4294967296
  for (let i = 0; i < 80; i++) {
    const base = 2600 + (i * beat) / 2
    if (rand() > 0.22)
      notes.push({
        t: base,
        l: Math.floor(rand() * 4),
        hit: false,
        miss: false
      })
    if (i > 8 && rand() > 0.88)
      notes.push({
        t: base,
        l: Math.floor(rand() * 4),
        hit: false,
        miss: false
      })
  }
  return notes.at(-1).t + 2200
}
let duration = makeChart()
function resize() {
  const r = stage.getBoundingClientRect()
  dpr = Math.min(devicePixelRatio || 1, 2)
  W = r.width
  H = r.height
  canvas.width = W * dpr
  canvas.height = H * dpr
  ctx.setTransform(dpr, 0, 0, dpr, 0, 0)
}
addEventListener('resize', resize)
resize()
function roundRect(x, y, w, h, r) {
  ctx.beginPath()
  ctx.roundRect(x, y, w, h, r)
}
function draw(now) {
  ctx.clearRect(0, 0, W, H)
  const laneW = W / 4,
    hy = H * hitY,
    t = running && !paused ? now - startTime : 0
  ctx.fillStyle = '#0b0913cc'
  roundRect(0, 0, W, H, 22)
  ctx.fill()
  for (let l = 0; l < 4; l++) {
    ctx.fillStyle = l % 2 ? '#ffffff05' : '#ffffff025'
    ctx.fillRect(l * laneW, 0, laneW, H)
    ctx.strokeStyle = '#ffffff10'
    ctx.beginPath()
    ctx.moveTo(l * laneW, 0)
    ctx.lineTo(l * laneW, H)
    ctx.stroke()
  }
  const glow = ctx.createLinearGradient(0, hy - 30, 0, hy + 30)
  glow.addColorStop(0, 'transparent')
  glow.addColorStop(0.5, '#ffffff18')
  glow.addColorStop(1, 'transparent')
  ctx.fillStyle = glow
  ctx.fillRect(0, hy - 30, W, 60)
  ctx.fillStyle = '#f5f1ff'
  ctx.fillRect(0, hy, W, 3)
  for (const n of notes) {
    if (n.hit || n.miss) continue
    const y = hy - ((n.t - t) / travel) * hy
    if (y > H + 30 || y < -30) continue
    ctx.shadowColor = colors[n.l]
    ctx.shadowBlur = 18
    ctx.fillStyle = colors[n.l]
    roundRect(n.l * laneW + 8, y - 10, laneW - 16, 20, 8)
    ctx.fill()
    ctx.shadowBlur = 0
    ctx.fillStyle = '#ffffff80'
    roundRect(n.l * laneW + 14, y - 6, laneW - 28, 4, 2)
    ctx.fill()
  }
  for (let l = 0; l < 4; l++) {
    ctx.strokeStyle = colors[l]
    ctx.lineWidth = 2
    roundRect(l * laneW + 8, hy + 15, laneW - 16, 42, 10)
    ctx.stroke()
    ctx.fillStyle = colors[l] + '18'
    ctx.fill()
    ctx.fillStyle = colors[l]
    ctx.font = '800 15px system-ui'
    ctx.textAlign = 'center'
    ctx.fillText(['D', 'F', 'J', 'K'][l], (l + 0.5) * laneW, hy + 42)
  }
  if (running && !paused) {
    checkMisses(t)
    scheduleAudio(t)
    if (t > duration) endGame()
    else raf = requestAnimationFrame(draw)
  } else raf = requestAnimationFrame(draw)
}
function flash(text, color) {
  ui.judgment.textContent = text
  ui.judgment.style.color = color
  ui.judgment.classList.remove('show')
  void ui.judgment.offsetWidth
  ui.judgment.classList.add('show')
}
function update() {
  ui.score.textContent = String(score).padStart(6, '0')
  ui.combo.textContent = combo + '×'
  ui.accuracy.textContent =
    (judged ? Math.max(0, 100 - totalError / judged) : 100).toFixed(1) + '%'
}
function hit(lane) {
  if (!running || paused) return
  const t = performance.now() - startTime
  let best = null,
    dist = Infinity
  for (const n of notes) {
    if (n.l !== lane || n.hit || n.miss) continue
    const d = Math.abs(n.t - t)
    if (d < dist) {
      dist = d
      best = n
    }
  }
  if (!best || dist > 180) {
    combo = 0
    judged++
    totalError += 100
    flash('MISS', '#ff5a72')
    update()
    return
  }
  best.hit = true
  hits++
  judged++
  let pts, label, c
  if (dist <= 55) {
    pts = 1000
    label = 'PERFECT'
    c = '#b8ff5e'
    totalError += (dist / 55) * 4
  } else if (dist <= 110) {
    pts = 650
    label = 'GREAT'
    c = '#42d9ff'
    totalError += 10
  } else {
    pts = 300
    label = 'GOOD'
    c = '#ffcf5e'
    totalError += 28
  }
  combo++
  score += pts + combo * 10
  flash(label, c)
  tone(220 + lane * 90, 0.055, 0.12)
  update()
}
function checkMisses(t) {
  for (const n of notes)
    if (!n.hit && !n.miss && t - n.t > 180) {
      n.miss = true
      combo = 0
      judged++
      totalError += 100
      flash('MISS', '#ff5a72')
      update()
    }
}
function ensureAudio() {
  if (!audio) audio = new (window.AudioContext || window.webkitAudioContext)()
  if (audio.state === 'suspended') audio.resume()
}
function tone(freq, vol = 0.05, len = 0.09, when = 0) {
  if (muted) return
  ensureAudio()
  const o = audio.createOscillator(),
    g = audio.createGain()
  o.type = 'triangle'
  o.frequency.value = freq
  g.gain.setValueAtTime(vol, audio.currentTime + when)
  g.gain.exponentialRampToValueAtTime(0.001, audio.currentTime + when + len)
  o.connect(g).connect(audio.destination)
  o.start(audio.currentTime + when)
  o.stop(audio.currentTime + when + len)
}
function scheduleAudio(t) {
  if (t > nextBeat) {
    tone(nextBeat % (beat * 4) < 1 ? 110 : 82, 0.035, 0.08)
    nextBeat += beat
  }
}
async function begin() {
  ensureAudio()
  makeChart()
  score = combo = hits = totalError = judged = 0
  update()
  ui.overlay.classList.add('hidden')
  for (const v of ['3', '2', '1', 'GO']) {
    ui.count.textContent = v
    ui.count.classList.remove('pop')
    void ui.count.offsetWidth
    ui.count.classList.add('pop')
    tone(v === 'GO' ? 440 : 180, 0.05, 0.08)
    await new Promise(r => setTimeout(r, 700))
  }
  startTime = performance.now()
  nextBeat = 0
  running = true
  paused = false
}
function endGame() {
  running = false
  const acc = judged ? Math.max(0, 100 - totalError / judged) : 0
  ui.eyebrow.textContent = 'TRACK COMPLETE'
  ui.title.innerHTML =
    acc >= 92
      ? 'PURE<br><span>RHYTHM.</span>'
      : acc >= 75
        ? 'NICE<br><span>FLOW.</span>'
        : 'RUN IT<br><span>BACK.</span>'
  ui.copy.textContent = `${score.toLocaleString()} points · ${acc.toFixed(
    1
  )}% accuracy · ${hits}/${notes.length} notes hit`
  ui.start.textContent = 'PLAY AGAIN'
  ui.overlay.classList.remove('hidden')
}
function togglePause() {
  if (!running) return
  if (paused) {
    startTime += performance.now() - pauseAt
    paused = false
    ui.overlay.classList.add('hidden')
  } else {
    paused = true
    pauseAt = performance.now()
    ui.eyebrow.textContent = 'SESSION PAUSED'
    ui.title.innerHTML = 'HOLD<br><span>STEADY.</span>'
    ui.copy.textContent = 'The track is frozen exactly where you left it.'
    ui.start.textContent = 'RESUME'
    ui.overlay.classList.remove('hidden')
  }
}
addEventListener('keydown', e => {
  if (e.repeat) return
  if (e.code === 'Escape') {
    togglePause()
    return
  }
  if (keys[e.code] !== undefined) {
    e.preventDefault()
    hit(keys[e.code])
  }
})
stage.addEventListener('pointerdown', e => {
  if (!ui.overlay.classList.contains('hidden')) return
  const r = stage.getBoundingClientRect()
  hit(
    Math.max(0, Math.min(3, Math.floor((e.clientX - r.left) / (r.width / 4))))
  )
})
ui.start.addEventListener('click', () => (paused ? togglePause() : begin()))
ui.sound.addEventListener('click', () => {
  muted = !muted
  ui.sound.textContent = muted ? '×' : '♪'
  ui.sound.setAttribute('aria-label', muted ? 'Enable sound' : 'Mute sound')
})
requestAnimationFrame(draw)
