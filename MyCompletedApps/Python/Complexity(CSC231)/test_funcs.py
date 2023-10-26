from testing import *
from funcs import *


def main():
    a = [9, 4, 2, 3, 5, 9, 10]
    c = [9, 4, 2, 3, 5, 9, 11]
    b = [3, 4, -1, 9, 99, 12, 34]

    test(sum(a) / len(a), average, a)

    test([9 / 1, 13 / 2, 15 / 3, 18 / 4, 23 / 5, 32 / 6, 42 / 7], moving_average, a)

    test([3 / 1, 7 / 2, 6 / 3, 15 / 4, 114 / 5, 126 / 6, 160 / 7], moving_average, b)

    test(False, is_unique, a)

    test(False, is_unique, c)

    test(True, is_unique, b)

    test([10, 11], diff, a, c)

    test([-1, 2, 5, 10, 12, 34, 99], diff, a, b)

    test(['AAAA', 'AAAB', 'AABA', 'AABB', 'ABAA', 'ABAB', 'ABBA', 'ABBB', 'BAAA',
          'BAAB', 'BABA', 'BABB', 'BBAA', 'BBAB', 'BBBA', 'BBBB'], four_letter_words, 2)


main()