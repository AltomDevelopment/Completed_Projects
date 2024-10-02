# YOU MAY NOT USE DICTIONARIES ANYWHERE IN THIS PROGRAM
# YOU MAY NOT USE DICTIONARIES ANYWHERE IN THIS PROGRAM
# YOU MAY NOT USE DICTIONARIES ANYWHERE IN THIS PROGRAM
# YOU MAY NOT USE DICTIONARIES ANYWHERE IN THIS PROGRAM
###
###
# Type your name here: Zachery Altom
###
###
# First, carefully examine the function main below to see how these functions are used
##
##
# Then, complete the functions below as directed in the docstring comments
##
##
# I will test your code by running the main function defined below.
##
# Obviously, as you write each function, you can test it individually
# using the Python shell
##
##
import traceback


def initialize_portfolio(filename):  # 20 points
    """
    read the data contained in the named file
    and return a *list of tuples* representing the data
    For example: [('DD', 1085), ('DIS', 1213), ('GE', 1781), ('GS', 1913),..]
    This is the list referenced as portfolio in the remaining functions below
    """
    file_reader = open('filename', 'w+')
    for line in filename:
        shares = (str(line))
    return shares

    # If you are unable to write this function, uncomment the return statement below
    # That will allow you to write the remaining functions
    # return [('DD', 1085), ('DIS', 1213), ('GE', 1781), ('GS', 1913), ('HD', 1319), ('IBM', 1348), ('INTC', 1562),
    # ('JNJ', 1592), ('JPM', 1079), ('KO', 1774), ('MCD', 1229), ('MMM', 1211), ('MRK', 1408), ('MSFT', 1011),
    # ('NKE', 1733), ('PFE', 1220), ('PG', 1783), ('T', 1661), ('TRV', 1622), ('UNH', 1022), ('UTX', 1956), ('V', 1978),
    # ('VZ', 1517), ('WMT', 1333), ('XOM', 1398), ('XYZ', 50)]


def print_portfolio(portfolio):  # 20 points
    """
    Print the contents of the portfolio in a two-column format as shown below
    The first line is a header
    All the other lines show a stock symbol, and the number of shares
    held of that stock, with a tab "\t" character separating the two,
    like this:
    Symbol    Amount
    DD        1085
    DIS       1213
    GE        1781
    GS        1913
    .....
    This function does not return anything
    """


def total_shares(portfolio):  # 20 points
    """
    return the total number of shares owned (across all stocks) in the portfolio
    """

    return None


def find_amount(portfolio, stock_symbol):  # 20 points
    """
    return the number of shares of the specified stock in the portfolio
    for example, find_amount(portfolio, "DIS") returns 1213
    """
    return None


def update_portfolio(portfolio, filename):  # 20 points
    """
    Open the specified file, read the transactions in it,
    and update the portfolio accordingly
    Return the updated portfolio
    """
    return None


# DO NOT MAKE ANY CHANGES TO THE main FUNCTION BELOW
# DO NOT MAKE ANY CHANGES TO THE main FUNCTION BELOW
def main():
    try:
        portfolio = initialize_portfolio("holdings.txt")
    except:
        print(">>>>>>>> initialize_portfolio has errors")
        traceback.print_exc()

    print("\nHere is your portfolio before any trades\n")

    try:
        print_portfolio(portfolio)
    except:
        print(">>>>>>>> print_portfolio has errors")
        traceback.print_exc()

    try:
        print("\nThe total number of shares in the portfolio is ", total_shares(portfolio))
    except:
        print(">>>>>>>> total_shares has errors")
        traceback.print_exc()

    symbol = input("\nEnter a stock symbol(like IBM): ")

    try:
        print("\nBefore any trades, you hold ", find_amount(portfolio, symbol), " shares of ", symbol)
    except:
        print(">>>>>>>> find_amount has errors")
        traceback.print_exc()

    try:
        portfolio = update_portfolio(portfolio, "trades.txt")
    except:
        print(">>>>>>>> update_portfolio has errors")
        traceback.print_exc()

    print("\nHere is your portfolio after trades\n")

    try:
        print_portfolio(portfolio)
    except:
        print(">>>>>>>> print_portfolio has errors")
        traceback.print_exc()

    symbol = input("\nEnter a stock symbol(like IBM): ")

    try:
        print("\nAfter trades, you hold ", find_amount(portfolio, symbol), " shares of ", symbol)
    except:
        print(">>>>>>>>> find_amount has errors")
        traceback.print_exc()
