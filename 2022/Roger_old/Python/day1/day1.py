

with open('input.txt') as f:
	data = f.readlines()
	list = [line.strip() for line in data]
	
sum_list = []
count = 0

for i in list:
	
	if i == '':
		sum_list.append(count)
		count = 0
	else:
		count += int(i)

sorted_sums = sorted(sum_list, reverse=True)
print(sorted_sums[0])

top_3 = sum(sorted_sums[:3])
print(top_3)
		
	
