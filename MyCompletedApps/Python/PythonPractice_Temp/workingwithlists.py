class ListFunctions:

    def __init__(self, list_example):
        self.list_example = list_example[None]

    def index_list(self, index):
        while index > 0:
            for lines in self.list_example:
                print(str(lines[index]))
