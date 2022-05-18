#include <cs50.h>
#include <stdio.h>

int main(void)
{
    int score1 = get_int("Score 1: ");
    int score2 = get_int("Score 2: ");
    int score3 = get_int("Score 3: ");

      //score1
    printf("Score 1: ");

    for (int i = 0; i < score1; i++)
    {
        printf("#");
    }
    printf("\n");

      //score2
    printf("Score 2: ");

    for (int i = 0; i < score2; i++)
    {
        printf("#");
    }
    printf("\n");


      //score3
    printf("Score 3: ");

    for (int i = 0; i < score3; i++)
    {
        printf("#");
    }
    printf("\n");
}
