# Complete the functions below as directed in the assignment
# Document each function using docstring comments
# test the functions by running test_funcs.py
import fractions


def average(a_list):
    total = 0
    step = 0
    while step < len(a_list):
        total += a_list[step]
        step += 1
    return str(total / step)


def moving_average(a_list):
    # TODO docstring
    """Moving average function,



    """
    output = []
    running_total = 0
    step = 0
    while step < len(a_list):
        running_total += a_list[step]
        average_value = running_total / (step + 1)
        step += 1
        output.append(average_value)
    return str(output)


def is_unique(a_list):
    placeholder = 0
    val_check = 1
    while placeholder < len(a_list):
        while val_check < len(a_list):
            if a_list[placeholder] == a_list[val_check]:
                return False
            elif a_list[placeholder] != a_list[val_check]:
                val_check += 1
        placeholder += 1
    return True


def diff(a_list, b_list):
    output = []
    placeholder = 0
    while placeholder < len(a_list):
        for item in b_list:
            if item == a_list[placeholder]:
                placeholder += 1
            else:
                output.append(a_list[placeholder])
                placeholder += 1
    return str(output)


# [9,3,4,2,6,1]
# [9,3,5,2,5,1]


def quick_sort(a_list):
    # TODO keep iterating over performing swap until (list is in order)<-- lowest val
    # is actually the lowest val and same for highest val
    # indexers
    left = 0
    middle = left + 1
    right = middle + 1
    highest_val = 0
    lowest_val = 0
    while a_list[len(a_list)-1] > highest_val and a_list[0] > lowest_val:
        # middle and left swap
        if a_list[middle] < a_list[left]:
            lowest_val = a_list[left]
            a_list[left] = a_list[middle]
            a_list[middle] = lowest_val
        # middle and right swap
        elif a_list[middle] > a_list[right]:
            highest_val = a_list[right]
            a_list[right] = a_list[middle]
            a_list[middle] = highest_val
        # adding to index
        else:
            right += 1
            left += 1
            middle += 1


def four_letter_words(n):
    letter_list = ["A", "B", "C", "D"]
    output = []
    if n == 1:
        output = letter_list[n]*4
    elif n == 2:
        output.append(letter_list[n])
        output.append(letter_list[n-1])
    pass
