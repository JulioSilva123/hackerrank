
#!/bin/python3

import sys



def sumn(n, d): 
    n //= d
    return d*n*(n+1) // 2


a, b = 3, 5  


print ('número de repetições: ')
t = int(input().strip())



for a0 in range(t):
    print ('digite um número para o calculo: ')
    n = int(input().strip())
    s = sumn(n-1, a) + sumn(n-1, b) - sumn(n-1, a*b)
    print (s)