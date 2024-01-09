def generate_odd():
    n = 1

    while True:
        yield n
        n+=2

seq = generate_odd()

for n in range(25):
    print(next(seq))
 
    