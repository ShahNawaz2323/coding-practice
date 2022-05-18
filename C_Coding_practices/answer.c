#include <cs50.h>
#include <stdio.h>

int main(void)
{
    char c = get_char("answer: ");

    if (c== 'y' || c=='y')
    {
        printf("yes\n");
    }
    else if (c == 'N' || c =='n')
    {
        printf("no\n");
    }
}
