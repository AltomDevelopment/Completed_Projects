# 9 points
class PhoneCall:
    """
    Complete this so that it models a phone call object as described in the test
    """
    call_lists = []

    def __init__(self, date, total_time, callee_num, caller_num):
        self.id = "empty"
        self.date = date
        self.total_time = total_time
        self.callee_num = callee_num
        self.caller_num = caller_num

    # (9 points)
    def read_data(self, filename):
        """
        Reads the data in the specified file,
        creates PhoneCall objects corresponding to each line,
        and returns a list of PhoneCall objects

        Parameters:
                filename: name of file containing phone call data

        Returns:
                a list of PhoneCall objects
        """
        read_file = open(filename, "r")
        read_file.readlines()
        keeper = []
        for lines in read_file:
            lines.split(",")
            keeper.append(lines)
            for info in keeper:
                new_call = PhoneCall(info[0], info[1], info[2], info[3])
                new_call.id = str(len(PhoneCall.call_lists))
                PhoneCall.call_lists.append(new_call)
        return str(PhoneCall.call_lists)

        # (9 points)

    def search(self, call_list, caller_num, callee_num):
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
        output = []
        for calls in call_list:
            if calls.callee_num == callee_num and calls.caller_num == caller_num:
                output.append(calls)
        return str(output)

    # (9 points)
    def find_longest_call(self, call_list):
        """
        Searches call_list and returns the object representing
        the longest phone call in the call_list

        Parameters:
                call_list: list of phone call objects

        Returns:
                Object representing the longest phone call in the list
        """
        longest_call = 0
        for calls in call_list:
            if calls.total_time > longest_call:
                longest_call += calls.total_time
        return str(longest_call)

    def __str__(self):
        time_adjust = self.total_time.split(":")
        print("call " + self.id + "on " + self.date + "for " + time_adjust[0] +
              " minutes and " + time_adjust[1] + "seconds")
        # call 1 on 9/21/2017 for 1 minutes and 41 seconds
