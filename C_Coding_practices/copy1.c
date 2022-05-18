//copy one sting to other full not addresses
#include <stdio.h>
#include <cs50.h>
#include <string.h>
#include <ctype.h>
#include <stdlib.h>

int main (void)
{
    //Get a String Input
    char* s = get_string("s: ");
    if(!s)
    {
        return 1;
    }

    //Allocating Memory For Another string
    char *t = malloc(strlen(s) +1 );
    if(!t)
    {
        return 1;
    }

    //copy string into memory
    for (int i = 0, n = strlen(s); i <= n; i++)
    {
        t[i] =  s[i];
    }

    //New string first Letter Captilize
    if (strlen(t) > 0)
    {
        t[0] = toupper(t[0]);
    }

    //output clear
    printf("Output clear\n");
    //print both strings
    printf("s: %s\n", s);
    printf("t: %s\n", t);

}