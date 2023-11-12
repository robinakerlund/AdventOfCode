


with open('day10_input.txt') as f:
    data = f.read().split('\n')


cycle = 1
reg_x = 1
cycle_dict = {}

def check_cycle(cycle):
    if cycle >= 19 and cycle <= 20:
        print(f'20 th cycle, regX: {reg_x} - cycle: {cycle}')
        cycle_dict[str(cycle)] = reg_x

    elif cycle >= 59 and cycle <= 60:
        print(f'60 th cycle, regX: {reg_x} - cycle: {cycle}')
        cycle_dict[str(cycle)] = reg_x

    elif cycle >= 99 and cycle <= 100:
        print(f'100 th cycle, regX: {reg_x} - cycle: {cycle}')
        cycle_dict[str(cycle)] = reg_x

    elif cycle >= 139 and cycle <= 140:
        print(f'140 th cycle, regX: {reg_x} - cycle: {cycle}')
        cycle_dict[str(cycle)] = reg_x

    elif cycle >= 179 and cycle <= 180:
        print(f'180 th cycle, regX: {reg_x} - cycle: {cycle}')
        cycle_dict[str(cycle)] = reg_x

    elif cycle >= 219 and cycle <= 220:
        print(f'220 th cycle, regX: {reg_x} - cycle: {cycle}')
        cycle_dict[str(cycle)] = reg_x



for i in data:
    command = i.split(' ')[0]

    if command == 'addx':

        check_cycle(cycle)       

        value = int(i.split(' ')[1])
        cycle += 2
        reg_x += value

        check_cycle(cycle)

    elif command == 'noop':
        cycle += 1

print(cycle_dict)