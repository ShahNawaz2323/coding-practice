#include <stdio.h>
#include <cs50.h>
#include <string.h>
#include <ctype.h>

int main (void)
{
    //Get a String Input
    string s = get_string("s: ");

    //Copy the string Address
    string t = s;

    //Captilize the first letter in string
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