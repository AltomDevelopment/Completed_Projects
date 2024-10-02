__author__ = 'narayans'
import random
from time_this import *


# shuffle the passed list, in place
# return the shuffled list
def shuffle(a_list):
    # shuffle the list
    p = len(a_list)

    for i in range(p):
        s = random.randint(0, p - 1)
        t = random.randint(0, p - 1)
        temp = a_list[s]
        a_list[s] = a_list[t]
        a_list[t] = temp

    return a_list


# return a list containing integers 0..(size-1)
# randomly arranged in the list
def scrambled_list(size):
    # initialize the list with numbers 0..(size-1)
    a = [r for r in range(size)]

    return shuffle(a)


# return a list of length size filled with random ints in the range low-->high
def random_list(size, low, high):
    random.seed()
    a = [random.randint(low, high) for r in range(size)]
    return a


# Return index of num in the list numbers
# return -1 on failure
def search(numbers, num):
    i = 0

    while i < len(numbers):
        if numbers[i] == num:
            return i
        i += 1

    return -1


# n**2 algorithm for finding min of a list
def my_min2(a_list):
    small_count = 0
    for m in a_list:
        count = 0
        for n in a_list:
            if m <= n:
                count = count + 1
        if count > small_count:
            small_count = count
            smallest = m
    return smallest


def my_min1(a_list):
    smallest = a_list[0]
    for item in a_list:
        if item < smallest:
            smallest = item

    return smallest


def test_search(detail=False):
    size = input("Enter list size: ")
    num = int(input("Enter search number: "))

    total_effort = 0
    num_trials = 100
    for r in range(num_trials):
        # generate a new "shuffled" list of numbers of given size
        numbers = scrambled_list(int(size))

        elapsed_time, count = time_this(search, numbers, num)
        total_effort += elapsed_time
        if detail:
            print("List size = ", size, ";Found ", num, "after ", format(elapsed_time, ".6f"))

    print("Searching :", size, ":Average time = ", total_effort / num_trials)


def test_min(detail=False):
    size = input("Enter list size: ")

    total_effort = 0
    num_trials = 100
    for r in range(num_trials):
        # generate a new "shuffled" list of numbers of given size
        numbers = scrambled_list(int(size))

        elapsed_time, count = time_this(my_min2, numbers)
        total_effort += elapsed_time
        if detail:
            print("List size = ", size, ";Found ", count, "after ", format(elapsed_time, ".6f"))

    print("Searching :", size, ":Average time = ", total_effort / num_trials)


def bubble_sort(numbers):
    i = 0
    while i < len(numbers):
        j = 0
        while j < len(numbers) - 1:
            # compare adjacent numbers
            if numbers[j + 1] < numbers[j]:
                # swap the two numbers
                temp = numbers[j]
                numbers[j] = numbers[j + 1]
                numbers[j + 1] = temp
            j += 1
        i += 1


def py_sort(numbers):
    numbers.sort()


def test_sort(detail=False):
    size = input("Enter list size: ")
    total_effort = 0
    num_trials = 25
    for r in range(num_trials):
        # generate a new "shuffled" list of numbers of given size
        numbers = scrambled_list(int(size))

        elapsed_time, result = time_this(py_sort, numbers)
        total_effort += elapsed_time
        if detail:
            print("Sorted list ", size, ": in ", elapsed_time)

    print("Sorting: ", size, ": Average time = ", total_effort / num_trials)
