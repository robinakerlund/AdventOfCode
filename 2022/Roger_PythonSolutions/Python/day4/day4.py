

with open('day4input.txt') as f:
    data = [i for i in f.read().strip().split('\n')]

pairs_overlapping= 0

for pair in data:
    #All the Pairs looks like: ['37-87', '36-87']

    elf1 = [int(i) for i in pair.split(',')[0].split('-')] #This would hold: [37, 87] as integers
    elf2 = [int(i) for i in pair.split(',')[1].split('-')]

    elf1_nums = list(range(elf1[0], elf1[1] + 1)) #Creates a list of the numbers in the range 
    elf2_nums = list(range(elf2[0], elf2[1] + 1))

    if any(number in elf2_nums for number in elf1_nums) or any(number in elf1_nums for number in elf2_nums):
        pairs_overlapping += 1

print('Pairs overlapping: ', pairs_overlapping)




'''     PART 1

for pair in data:
    #All the Pairs looks like: ['37-87', '36-87']

    elf1 = [int(i) for i in pair.split(',')[0].split('-')] #This would hold: [37, 87] as integers
    elf2 = [int(i) for i in pair.split(',')[1].split('-')]

    elf1_nums = list(range(elf1[0], elf1[1] + 1)) #Creates a list of the numbers in the range 
    elf2_nums = list(range(elf2[0], elf2[1] + 1))

    if all(number in elf2_nums for number in elf1_nums) or all(number in elf1_nums for number in elf2_nums):
        pairs_overlapping += 1
        print(f'elf1: {elf1} - elf2: {elf2}')

print('Pairs overloapping completely: ', pairs_overlapping)

'''






