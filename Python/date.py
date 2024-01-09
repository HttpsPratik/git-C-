import datetime as dt

current_date = dt.datetime.now()
new_year = dt.datetime(2025,1,1)

remaining_date = new_year - current_date  
print(remaining_date)

string_date = current_date.strftime("%A, %B %d, %Y")
print(string_date)