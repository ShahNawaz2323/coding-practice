#include <stdio.h>
#include <cs50.h>
#include <string.h>

int main (void)
{
    //Get Two Strings
    char* s = get_string("s: ");
    //if user sends 0 values
    if (s == NULL)
    {
        return 1;
    }

    char* t = get_string("t: ");
    //if user sends 0 values
    if (t == NULL)
    {
        return 1;
    }

    //Compare strings for equality
    if (strcmp(s,t) == 0)
    {
        printf("same\n");

    }
    else
    {
        printf("difference\n");
    }
    return 0;
}
