import random
"""Chapter 2.4 in Textbook"""

def shuffle(s):
    """Returns a shuffled version of string"""
    a_list = list(s)

    for r in range(len(s)):
        a = random.randint(0, len(s) - 1)
        b = random.randint(0, len(s) - 1)
        temp = a_list[b]
        a_list[a] = a_list[b]
        a_list[b] = temp
    return "".join(a_list)

def random_string(size):
    """Return a string composed of random characters of length size"""
    start = ord('a')
    stop = ord('z')
    result = ""
    for r in range(size):
        i = random.randint(start, stop)
        result += chr(i)

    return result

def anagram_solution1(s1,s2): # N squared time complexity
    still_ok = True

    if len(s1) != len(s2):
        still_ok = False
    a_list = list(s2)
    pos1 = 0
    while pos1 < len(s1) and still_ok:
        pos2 = 0
        found = False
        while pos2 < len(a_list) and not found:
            if s1[pos1] == a_list[pos2]:
                found = True
            else:
                pos2 = pos2 + 1
        if found:
            a_list[pos2] = None
        else:
            still_ok = False
            pos1 = (pos1 + 1)

     return still_ok

def anagram_solution2(s1,s2): # N log N time complexity TCC = Time complexity cost
     alist1 = list(s1)
     alist2 = list(s2)
     alist1.sort() # TTC
     alist2.sort() # TTC

     pos = 0
     matches = True
     while pos < len(s1) and matches: # TCC
         if alist1[pos]==alist2[pos]:
             pos = pos + 1
         else:
             matches = False

     return matches

def anagram_solution4(s1,s2): # O(N) time complexity?
    """Counting how many occurrences of the letter in the list and keeping track of them.
        Then compares the values of each list to each other one by one."""

    c1 = [0]*26
    c2 = [0]*26

    for i in range(len(s1)):
        pos = ord(s1[i])-ord('a')
        c1[pos] = c1[pos] + 1

    for i in range(len(s2)):
        pos = ord(s2[i])-ord('a')
        c2[pos] = c2[pos] + 1

    j = 0
    stillOK = True
    while j<26 and stillOK:
        if c1[j]==c2[j]:
            j = j + 1
        else:
            stillOK = False

    return stillOK