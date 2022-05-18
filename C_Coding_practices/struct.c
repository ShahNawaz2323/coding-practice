#include <stdio.h>
#include <cs50.h>
#include <ctype.h>
#include <string.h>

#include "struct.h"

int main(void)
{
    //space forstudents
    int enrollment = get_int("Enrollment: ");
    student students[enrollment];

    //Prompt for students
    for (int i = 0 ; i < enrollment; i++)
    {
        students[i].name = get_string("Name: ");
        students[i].dorm = get_string("Dorm: ");
    }
}