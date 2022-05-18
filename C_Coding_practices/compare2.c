#include <stdio.h>
#include <cs50.h>
#include <string.h>

bool compare_strings(string a , string b);

int main(void)
{
    string s = get_string("i: ");
    string t = get_string("j: ");

    if(compare_strings(s,t))
    {
        printf("same\n");
    }
    else
    {
        printf("difference\n");
    }
}

bool compare_strings(string a , string b)
{
    if (strlen(a) != strlen(b))
    {
        return false;
    }

    for (int i = 0 ,n = strlen(a); i < n; i++)
    {
        if (a[i] != b[i])
        return false;
    }

    return true;
}