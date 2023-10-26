from phone_call import PhoneCall


# (9 points)
def read_data(filename):
    """
    Reads the data in the specified file,
    creates PhoneCall objects corresponding to each line,
    and returns a list of PhoneCall objects

    Parameters:
            filename: name of file containing phone call data

    Returns:
            a list of PhoneCall objects
    """

    return []


# (9 points)
def search(call_list, caller_num, callee_num):
    """
    Searches call_list and returns a list of PhoneCall objects
    representing phone calls made from caller_num to callee_num

    Parameters:
            call_list: list of phone call objects
            caller_num: phone number of caller
            callee_num: phone number of callee

    Returns:
            a list of PhoneCall objects representing phone calls
            made from caller_num to callee_num
    """
    return []


# (9 points)
def find_longest_call(call_list):
    """
    Searches call_list and returns the object representing
    the longest phone call in the call_list

    Parameters:
            call_list: list of phone call objects

    Returns:
            Object representing the longest phone call in the list
    """

    return None


## MAKE NO CHANGES TO THE MAIN FUNCTION BELOW ###
## MAKE NO CHANGES TO THE MAIN FUNCTION BELOW ###
## MAKE NO CHANGES TO THE MAIN FUNCTION BELOW ###
def print_info(call_list):
    """
    Prints details of phone call objects in call_list

    Parameters:
            call_list: list of phone call objects

    Returns:
            Nothing
    """
    print("call list has " + str(len(call_list)) + " phone calls")
    for call in call_list:
        print(str(call))


def main():
    master_list = read_data("PhoneCallData.txt")

    print("Here is the master list of phone calls")
    print_info(master_list)

    caller = input("Enter caller number: ")
    callee = input("Enter callee number: ")

    call_list = search(master_list, caller, callee)

    print("Here are all the calls made from " + str(caller) + " to " + str(callee))
    print_info(call_list)

    longest_call = find_longest_call(call_list)

    print("The longest call from " + str(caller) + " to " + str(callee) + " was " + str(longest_call))


main()
