a = int(input('Podaj współczynnik a: '))
b = int(input('Podaj współczynnik b: '))
c = int(input('Podaj współczynnik c: '))
k = int(input('Podaj koniec podziału: '))

i = 1
while i <= k:
    if i%2!=0:
        f= a*i ** 2 + b *i+c
        print('f(',i,')=',f)
    i+=1

