''' part 1
a, x = rock = 1p
b, y = paper = 2p
c, z = scissor = 3p
loss = 0p
tie = 3p
win = 6p

part 2
a = rock = 1p
b = paper = 2p
c = scissor = 3p

x = loss = 0p
y = tie = 3p
z = win = 6p
'''

with open('input.txt') as f:
	data = [line.strip().split(' ') for line in f.readlines()]

def get_points(choice):
	if choice == 'a':
		points = 1
	elif choice == 'b':
		points = 2
	elif choice == 'c':
		points = 3
			
	return points


sum_points = 0


for i in data:
	outcome = i[1].lower()
	choice = i[0].lower()
	
	if outcome == 'y':
		sum_points += 3 + get_points(choice)
	
	elif outcome == 'x':
		if choice == 'a':
			sum_points += get_points('c')
		elif choice == 'b':
			sum_points += get_points('a')
		elif choice == 'c':
			sum_points += get_points('b')
		
	elif outcome == 'z':
		if choice == 'a':
			sum_points += 6 + get_points('b')
		elif choice == 'b':
			sum_points += 6 + get_points('c')
		elif choice == 'c':
			sum_points += 6 + get_points('a')
			
			
print(sum_points)
		



''' part 1

sum_points = 0

def get_points(choice):
	if choice == 'x':
		points = 1
	elif choice == 'y':
		points = 2
	elif choice == 'z':
		points = 3
			
	return points
	

for i in data:
	op = i[0].lower()
	me = i[1].lower()
	
	if (me == 'x' and op == 'a') or (me == 'y' and op == 'b') or (me == 'z' and op == 'c'):
		sum_points += (3 + get_points(me))
	
	elif (me == 'x' and op == 'c') or (me == 'y' and op == 'a') or (me == 'z' and op == 'b'):
		sum_points += (6 + get_points(me))
		
	else:
		sum_points += get_points(me)
	  	
	  	
print(sum_points)
'''
