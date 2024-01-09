def find_average_marks(marks):
    sum_of_marks = sum(marks)
    total_subjects = len(marks)
    average_marks = sum_of_marks / total_subjects
    return average_marks  

marks = [22, 35, 34, 54, 66]


average_marks = find_average_marks(marks)


print("The average marks is:", average_marks)
