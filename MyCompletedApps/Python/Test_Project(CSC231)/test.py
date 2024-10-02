import random


def random_list(size=None):
    alist = list(range(size))  # note that size is not defined, yet
    for i in range(len(alist)):
        pos = random.randint(0, size)  # note subtle error here
        temp = alist[i]
        alist[i] = alist[pos]
        alist[pos] = alist[i]


""" Code/InspectCode/ shows all problems within a specific file or the whole project"""


