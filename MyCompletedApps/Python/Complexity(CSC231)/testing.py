# module testing
import traceback


def test(expected, function, *params):
    funcName = str(function).split()[1]
    p = ""
    for x in params:
        p += str(x) + ","
    p = p[:len(p) - 1]

    print("Testing " + funcName + "(" + str(p) + ")")
    try:
        actual = function(*params)
        print("\tActual result = ", actual, ", Expected result = ", expected)
        if are_equal(actual, expected):
            print("\tTest Passed")
        else:
            print("\tTest Failed")
    except:
        print(funcName + " has errors")
        traceback.print_exc()


def are_equal(arg1, arg2):
    if type(arg1) == list:
        return have_same_values(arg1, arg2)
    else:
        return arg1 == arg2


def have_same_values(list1, list2):
    list1.sort()
    list2.sort()
    return list1 == list2
