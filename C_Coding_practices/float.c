#include <cs50.h>
#include <stdio.h>

int main(void)
{
    //promp user for x
    double x = get_double("x: ");

    //promp user for y
    double y = get_double("y: ");

    //Perfor Devision 

    printf("x/y = %.50f\n", x / y);
}
