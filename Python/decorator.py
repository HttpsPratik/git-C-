import datetime as dt

def msg(func):
    def wrapper():
        func()
        print("Hello")
    return wrapper    

@msg
def do_this():
    print(dt.datetime.now())

@msg
def do_that():
    print(dt.datetime.today())

do_this()
do_that()
print("Done")