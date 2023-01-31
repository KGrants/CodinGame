def calculate_cell(line, cell_dict):
    if line["solved"] == False:
        for arg in ["num1", "num2"]:
            if "$" in line["args"][arg]:
                arg_value = line["args"][arg].replace("$", "")
                calculate_cell(cell_dict[int(arg_value)], cell_dict)
                line["args"][arg] = cell_dict[int(arg_value)]["value"]

        if line["args"]["string"] == "VALUE":
            line["value"] = line["args"]["num1"]
        
        elif line["args"]["string"] == "ADD":
            line["value"] = int(line["args"]["num1"]) + int(line["args"]["num2"])

        elif line["args"]["string"] == "SUB":
            line["value"] = int(line["args"]["num1"]) - int(line["args"]["num2"])

        else:
            line["value"] = int(line["args"]["num1"]) * int(line["args"]["num2"])

        line["solved"] = True



n = int(input())
cell_dict = {}

for i in range(n):
    operation, arg_1, arg_2 = input().split()
    cell_dict[i] = {"value" : None,
                    "solved" : False,
                    "args" : {
                        "string" : operation,
                        "num1" : arg_1,
                        "num2" : arg_2,},
                    }

for i in range(n):
    calculate_cell(cell_dict[i],cell_dict)
    print(cell_dict[i]["value"])
