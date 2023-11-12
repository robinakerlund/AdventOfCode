

import string

with open('input.txt') as f:
	data = [i for i in f.read().strip().split('\n')]

steps = 3
total_sum = 0

for i in range(0, len(data), 3):
	rucksacks = data[i:steps]
	steps += 3

	for prio, char in enumerate(string.ascii_letters):
		if char in rucksacks[0] and char in rucksacks[1] and char in rucksacks[2]:
			total_sum += prio + 1

print('part 2: ', total_sum)






'''			PART 1

letters = string.ascii_lowercase + string.ascii_uppercase
sum_of_prio = 0

def get_prio(letter):
	counter = 1
	for i in letters:
		if letter == i:
			return counter
		counter += 1

def extract_prio_item(lst):
	part1 = lst[0]
	part2 = lst[1]

	for i1 in part1:
		for i2 in part2:
			if i1 == i2:
				return get_prio(i1)

def split_half(line):
	line = line.strip()

	f_half = line[:int(len(line)/2)]
	s_half = line[int(len(line)/2):]
	
	return [f_half, s_half]
	

with open('input.txt') as f:
	data = f.readlines()

for sack in data:
	items = split_half(sack)
	prio = extract_prio_item(items)
	sum_of_prio += prio

print(sum_of_prio)
'''


