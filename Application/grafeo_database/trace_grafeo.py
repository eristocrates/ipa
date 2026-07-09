import dlltracer

with open("dll-log.txt", "w") as f:
    with dlltracer.Trace(out=f):
        import grafeo