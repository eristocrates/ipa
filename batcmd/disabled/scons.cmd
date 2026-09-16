@echo off
python -c "import sys; from SCons.Script import main as m; sys.exit(m())" %*
