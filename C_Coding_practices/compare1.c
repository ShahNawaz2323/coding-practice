#include <stdio.h>
#include <cs50.h>

int main(void)
{
    string s = get_string("i: ");
    string t = get_string("j: ");

    if(s==t)
    {
        printf("same\n");
    }
    else
    {
        printf("difference\n");
    }
}