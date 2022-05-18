from cs50 import get_string

s = get_string("Name: ")
for c in s:
    print(c.upper(), end="")
print()

print(get_string("Name: ").upper())