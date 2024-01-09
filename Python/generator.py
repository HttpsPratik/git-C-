def even_generator(max):
    n = 2

    while n <=max:
        yield n 
        n+=2

numbers = even_generator(6)
print(next(numbers))
print(next(numbers))
print(next(numbers))



