

from collections import Counter

with open('day6_input.txt') as f:
    data = f.read()

string_to_check = data[:14]
check_list = [i for i in range(2, 14)]
counter = 14

for char in data[14:]:

    cnt = Counter(string_to_check)
    cnt_list = [int(cnt[i]) for i in string_to_check]


    if  max(cnt_list) > 1:
        string_to_check = string_to_check[1:] + char
        
    else:
        print (f'counter är: {counter} strängen är {string_to_check}')
        print(cnt_list)
        break

    counter += 1



'''     PART 1

from collections import Counter

with open('day6_input.txt') as f:
    data = f.read()

print (len(data))

string_to_check = data[:4]
counter = 4

for char in data[4:]:

    cnt = Counter(string_to_check)
    cnt_list = [cnt[i] for i in string_to_check]

    if 2 in cnt_list or 3 in cnt_list or 4 in cnt_list:
        string_to_check = string_to_check[1:] + char
        
    else:
        print (f'counter är: {counter} strängen är {string_to_check}')
        break

    counter += 1
  
'''        